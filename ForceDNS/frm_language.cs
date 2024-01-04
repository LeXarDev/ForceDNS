using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForceDNS
{
    public partial class frm_language : Form
    {
        private Dictionary<string, (Label, PictureBox)> ipAddressControls;

        public frm_language()
        {
            InitializeComponent();

            // قم بتهيئة المؤقت هنا (على سبيل المثال، يقوم بتنفيذ الـ Ping كل 5 ثوانٍ)
            pingTimer = new Timer();
            pingTimer.Interval = 1000; // بالمللي ثانية
            pingTimer.Tick += PingTimer_Tick;

            // بدء تشغيل المؤقت
            pingTimer.Start();

            // قم بتهيئة العناصر التي ترغب في تتبعها
            InitializeControls();
        }

        private void InitializeControls()
        {
            // قم بتهيئة العناصر التي ترغب في تتبعها هنا
            ipAddressControls = new Dictionary<string, (Label, PictureBox)>
            {
                {"1.1.1.1", (lbl_latency1, pictureLatency1)},
                {"8.8.8.8", (lbl_latency2, pictureLatency2)},
                {"9.9.9.9", (lbl_latency3, pictureLatency3)},
                {"192.168.8.1", (lbl_latency4, pictureLatency4)},
                // يمكنك إضافة المزيد من العناوين والعناصر هنا
            };
        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {
            PingHostAsync();
        }


        private async void PingHostAsync()
        {
            var pingTasks = ipAddressControls.Select(pair => PingAndUpdateAsync(pair.Key, pair.Value.Item1, pair.Value.Item2)).ToList();
            await Task.WhenAll(pingTasks);
        }

        private async Task PingAndUpdateAsync(string ipAddress, Label label, PictureBox pictureLatency)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = await ping.SendPingAsync(ipAddress);

                    if (reply.Status == IPStatus.Success)
                    {
                        UpdateLabel(ipAddress, reply.RoundtripTime, label);
                        ReactToPing(reply.RoundtripTime, label, pictureLatency);
                    }
                    else
                    {
                        UpdateLabel(ipAddress, -1, label);
                        pictureLatency.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    UpdateLabel(ipAddress, -1, label);
                    pictureLatency.Image = null;
                }
            }
        }

        private void UpdateLabel(string ipAddress, long roundtripTime, Label label)
        {
            // اختيار الـ Label المناسب باستخدام العنوان IP
            string labelText = $"Latency for {ipAddress}: ";

            if (roundtripTime >= 0)
            {
                labelText += $"{roundtripTime} ms";
            }
            else
            {
                labelText += "Unable to determine latency";
            }

            Console.WriteLine(roundtripTime); // قم بطباعة قيمة roundtripTime للتحقق

            // تحديث النص في الـ Label
            label.Text = labelText;
        }



        private void ReactToPing(long pingValue, Label label, PictureBox pictureLatency)
        {
            Console.WriteLine(pingValue);

            if (pingValue >= 50 && pingValue < 100)
            {
                pictureLatency.Image = Properties.Resources.signalGreen;
            }
            else if (pingValue >= 100 && pingValue < 150)
            {
                pictureLatency.Image = Properties.Resources.signalYellow;
            }
            else if (pingValue >= 150)
            {
                pictureLatency.Image = Properties.Resources.signalRed;
            }
            else
            {
                pictureLatency.Image = Properties.Resources.error;
            }

            // تحديث نص الـ Label ليتضمن قيمة البنق باستخدام BeginInvoke
            BeginInvoke(new Action(() => label.Text = $" {label.Tag} {pingValue} ms"));
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // تحديث الـ Ping عند النقر على زر التحديث
            PingHostAsync();
        }

        private void frm_language_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}