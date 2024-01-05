using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using NetFwTypeLib;

namespace ForceDNS
{
    public partial class frm_block : Form
    {
        private Button browseButton;
        private Button blockButton;
        private Button unblockButton;
        private string externalIPsFile = "https://example.com/external-ips.txt";
        private List<string> blockedIPs = new List<string>();
        public frm_block()
        {
            InitializeComponent();
        }

        private void frm_block_Load(object sender, EventArgs e)
        {

        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // Open file dialog to select the program path
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe";
            openFileDialog.Title = "Select Program File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                programPathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            // Load blocked IPs from the external file
            blockedIPs = LoadBlockedIPsFromExternalFile(externalIPsFile);

            // Block IPs for the selected program path
            BlockIPsForProgram(programPathTextBox.Text);
        }

        private void UnblockButton_Click(object sender, EventArgs e)
        {
            // Unblock IPs for the selected program path
            UnblockIPsForProgram(programPathTextBox.Text);
        }

        private List<string> LoadBlockedIPsFromExternalFile(string fileUrl)
        {
            List<string> ips = new List<string>();

            try
            {
                using (WebClient client = new WebClient())
                {
                    // Download the content of the external file
                    string content = client.DownloadString(fileUrl);

                    // Split the content into lines
                    string[] lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    // Add each line (IP) to the ips list
                    ips.AddRange(lines);

                    Console.WriteLine($"Blocked IPs loaded from {fileUrl}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading blocked IPs: {ex.Message}");
            }

            return ips;
        }

        private void BlockIPsForProgram(string programPath)
        {
            try
            {
                // Create the firewall manager object
                Type type = Type.GetTypeFromProgID("HNetCfg.FwMgr");
                dynamic fwMgr = Activator.CreateInstance(type);

                // Get the current profile
                dynamic profile = fwMgr.LocalPolicy.CurrentProfile;

                foreach (string ipAddress in blockedIPs)
                {
                    // Create a new rule for each blocked IP
                    dynamic firewallRule = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

                    // Set rule properties
                    firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                    firewallRule.Description = $"Block access to {ipAddress} for {programPath}";
                    firewallRule.RemoteAddresses = ipAddress;
                    firewallRule.ApplicationName = programPath; // Set the program path
                    firewallRule.Enabled = true;

                    // Add the rule to the inbound rules
                    profile.GloballyOpenPorts.Add(firewallRule);

                    Console.WriteLine($"Firewall rule added to block access to {ipAddress} for {programPath}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void UnblockIPsForProgram(string programPath)
        {
            try
            {
                // Create the firewall manager object
                Type type = Type.GetTypeFromProgID("HNetCfg.FwMgr");
                dynamic fwMgr = Activator.CreateInstance(type);

                // Get the current profile
                dynamic profile = fwMgr.LocalPolicy.CurrentProfile;

                // Remove rules based on the program path
                foreach (dynamic rule in profile.GloballyOpenPorts)
                {
                    if (rule.ApplicationName == programPath)
                    {
                        profile.GloballyOpenPorts.Remove(rule.Name);
                        Console.WriteLine($"Firewall rule removed for {programPath}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_block());

        }
    }
}
