using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                // يمكنك إضافة المزيد من العناوين والعناصر هنا
            };
        }

        private async void PingTimer_Tick(object sender, EventArgs e)
        {
            // تنفيذ عملية الـ Ping
            await PingHostAsync();
        }

        private async Task PingHostAsync()
        {
            foreach (var ipAddressControlPair in ipAddressControls)
            {
                string ipAddress = ipAddressControlPair.Key;
                var (label, pictureLatency) = ipAddressControlPair.Value;

                using (Ping ping = new Ping())
                {
                    try
                    {
                        PingReply reply = await Task.Run(() => ping.Send(ipAddress));

                        if (reply.Status == IPStatus.Success)
                        {
                            // تحديث عنصر الواجهة الرسومية lbl_latency1 أو lbl_latency2 أو lbl_latency3 بناءً على العنوان IP
                            UpdateLabel(ipAddress, reply.RoundtripTime, label);

                            // تحديث عنصر الواجهة الرسومية الآخر كـ pictureLatency
                            ReactToPing(reply.RoundtripTime, label, pictureLatency);
                        }
                        else
                        {
                            // في حالة عدم نجاح الـ Ping
                            UpdateLabel(ipAddress, -1, label); // قم بتحديث مع قيمة سالبة للإشارة عن عدم نجاح الـ Ping
                            pictureLatency.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        // في حالة حدوث خطأ أثناء القياس
                        UpdateLabel(ipAddress, -1, label); // قم بتحديث مع قيمة سالبة للإشارة عن وجود خطأ
                        pictureLatency.Image = null;
                    }
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
            // تفاعل مع قيمة البنق هنا
            Console.WriteLine(pingValue); // قم بطباعة قيمة pingValue للتحقق

            if (pingValue >= 50 && pingValue < 100)
            {
                pictureLatency.Image = Properties.Resources.signalGreen; // أخضر
            }
            else if (pingValue >= 100 && pingValue < 150)
            {
                pictureLatency.Image = Properties.Resources.signalYellow; // أصفر
            }
            else if (pingValue >= 150)
            {
                pictureLatency.Image = Properties.Resources.signalRed; // أحمر
            }
            else
            {
                // أي قيمة أقل من 50، يمكنك تعيين صورة أخرى أو التعامل بطريقة أخرى
                pictureLatency.Image = Properties.Resources.error; // صورة أخرى
            }

            // تحديث نص الـ Label ليتضمن قيمة البنق
            label.Text = $" {label.Tag} {pingValue} ms";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // تحديث الـ Ping عند النقر على زر التحديث
            PingHostAsync();
        }

        private void frm_language_Load(object sender, EventArgs e)
        {

        }
    }
}