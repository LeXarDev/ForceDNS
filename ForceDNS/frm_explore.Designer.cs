namespace ForceDNS
{
    partial class frm_explore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_cardDns = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pb_dnsPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_latency = new System.Windows.Forms.Label();
            this.lbl_previewAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.pnl_counterServices = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pb_latencyPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_deleteService = new Guna.UI2.WinForms.Guna2Button();
            this.btn_openServices = new Guna.UI2.WinForms.Guna2Button();
            this.btn_previous = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_next = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnl_cardDns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dnsPicture)).BeginInit();
            this.pnl_counterServices.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_latencyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_cardDns
            // 
            this.pnl_cardDns.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cardDns.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_cardDns.BorderRadius = 10;
            this.pnl_cardDns.Controls.Add(this.pb_dnsPicture);
            this.pnl_cardDns.Controls.Add(this.btn_refresh);
            this.pnl_cardDns.Controls.Add(this.lbl_name);
            this.pnl_cardDns.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.pnl_cardDns.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.pnl_cardDns.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.pnl_cardDns.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.pnl_cardDns.Font = new System.Drawing.Font("Cairo", 11F);
            this.pnl_cardDns.Location = new System.Drawing.Point(184, 89);
            this.pnl_cardDns.Name = "pnl_cardDns";
            this.pnl_cardDns.Size = new System.Drawing.Size(299, 68);
            this.pnl_cardDns.TabIndex = 1;
            this.pnl_cardDns.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cardDns_Paint);
            // 
            // pb_dnsPicture
            // 
            this.pb_dnsPicture.BackColor = System.Drawing.Color.Transparent;
            this.pb_dnsPicture.Image = global::ForceDNS.Properties.Resources.shecan;
            this.pb_dnsPicture.ImageRotate = 0F;
            this.pb_dnsPicture.Location = new System.Drawing.Point(18, 11);
            this.pb_dnsPicture.Name = "pb_dnsPicture";
            this.pb_dnsPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_dnsPicture.Size = new System.Drawing.Size(48, 48);
            this.pb_dnsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_dnsPicture.TabIndex = 13;
            this.pb_dnsPicture.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Animated = true;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.BorderRadius = 10;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = global::ForceDNS.Properties.Resources.sync;
            this.btn_refresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_refresh.Location = new System.Drawing.Point(235, 18);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 35);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(81, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(148, 38);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Shecan";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_latency
            // 
            this.lbl_latency.BackColor = System.Drawing.Color.Transparent;
            this.lbl_latency.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_latency.ForeColor = System.Drawing.Color.White;
            this.lbl_latency.Location = new System.Drawing.Point(33, 1);
            this.lbl_latency.Name = "lbl_latency";
            this.lbl_latency.Size = new System.Drawing.Size(59, 22);
            this.lbl_latency.TabIndex = 9;
            this.lbl_latency.Text = "??? ms";
            this.lbl_latency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_previewAddress
            // 
            this.lbl_previewAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_previewAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_previewAddress.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_previewAddress.ForeColor = System.Drawing.Color.White;
            this.lbl_previewAddress.Location = new System.Drawing.Point(-11, -8);
            this.lbl_previewAddress.Name = "lbl_previewAddress";
            this.lbl_previewAddress.Size = new System.Drawing.Size(245, 46);
            this.lbl_previewAddress.TabIndex = 10;
            this.lbl_previewAddress.Text = "178.22.122.100 185.51.200.2";
            this.lbl_previewAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_previewAddress.Click += new System.EventHandler(this.lbl_previewAddress_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "التأخير \\ البنق";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_counter
            // 
            this.lbl_counter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_counter.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_counter.ForeColor = System.Drawing.Color.White;
            this.lbl_counter.Location = new System.Drawing.Point(9, 4);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(111, 31);
            this.lbl_counter.TabIndex = 9;
            this.lbl_counter.Text = "? / ?";
            this.lbl_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_counterServices
            // 
            this.pnl_counterServices.AutoRoundedCorners = true;
            this.pnl_counterServices.BorderRadius = 18;
            this.pnl_counterServices.Controls.Add(this.lbl_counter);
            this.pnl_counterServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.pnl_counterServices.Location = new System.Drawing.Point(373, 345);
            this.pnl_counterServices.Name = "pnl_counterServices";
            this.pnl_counterServices.Size = new System.Drawing.Size(129, 39);
            this.pnl_counterServices.TabIndex = 10;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel4);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(184, 175);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(299, 122);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cairo", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(124, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = ": العنوان";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 6;
            this.guna2Panel4.Controls.Add(this.lbl_previewAddress);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.guna2Panel4.Location = new System.Drawing.Point(47, 62);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(228, 31);
            this.guna2Panel4.TabIndex = 48;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2Panel2);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(500, 175);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(189, 122);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.pb_latencyPicture);
            this.guna2Panel2.Controls.Add(this.lbl_latency);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2Panel2.Location = new System.Drawing.Point(48, 62);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(97, 31);
            this.guna2Panel2.TabIndex = 46;
            // 
            // pb_latencyPicture
            // 
            this.pb_latencyPicture.FillColor = System.Drawing.Color.Transparent;
            this.pb_latencyPicture.Image = global::ForceDNS.Properties.Resources.signalGreen;
            this.pb_latencyPicture.ImageRotate = 0F;
            this.pb_latencyPicture.Location = new System.Drawing.Point(4, 1);
            this.pb_latencyPicture.Name = "pb_latencyPicture";
            this.pb_latencyPicture.Size = new System.Drawing.Size(28, 26);
            this.pb_latencyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_latencyPicture.TabIndex = 15;
            this.pb_latencyPicture.TabStop = false;
            // 
            // btn_deleteService
            // 
            this.btn_deleteService.Animated = true;
            this.btn_deleteService.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteService.BorderColor = System.Drawing.Color.White;
            this.btn_deleteService.BorderRadius = 10;
            this.btn_deleteService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btn_deleteService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteService.ForeColor = System.Drawing.Color.White;
            this.btn_deleteService.Image = global::ForceDNS.Properties.Resources.delete1;
            this.btn_deleteService.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_deleteService.Location = new System.Drawing.Point(499, 89);
            this.btn_deleteService.Name = "btn_deleteService";
            this.btn_deleteService.Size = new System.Drawing.Size(92, 68);
            this.btn_deleteService.TabIndex = 0;
            this.btn_deleteService.Click += new System.EventHandler(this.btn_deleteService_Click);
            // 
            // btn_openServices
            // 
            this.btn_openServices.Animated = true;
            this.btn_openServices.BackColor = System.Drawing.Color.Transparent;
            this.btn_openServices.BorderColor = System.Drawing.Color.White;
            this.btn_openServices.BorderRadius = 10;
            this.btn_openServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openServices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_openServices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_openServices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_openServices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_openServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btn_openServices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_openServices.ForeColor = System.Drawing.Color.White;
            this.btn_openServices.Image = global::ForceDNS.Properties.Resources.folder;
            this.btn_openServices.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_openServices.Location = new System.Drawing.Point(597, 89);
            this.btn_openServices.Name = "btn_openServices";
            this.btn_openServices.Size = new System.Drawing.Size(92, 68);
            this.btn_openServices.TabIndex = 0;
            this.btn_openServices.Click += new System.EventHandler(this.btn_openServices_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.FillColor = System.Drawing.Color.Transparent;
            this.btn_previous.Image = global::ForceDNS.Properties.Resources.previous;
            this.btn_previous.ImageRotate = 0F;
            this.btn_previous.Location = new System.Drawing.Point(32, 163);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_previous.Size = new System.Drawing.Size(53, 51);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_previous.TabIndex = 0;
            this.btn_previous.TabStop = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FillColor = System.Drawing.Color.Transparent;
            this.btn_next.Image = global::ForceDNS.Properties.Resources.next;
            this.btn_next.ImageRotate = 0F;
            this.btn_next.Location = new System.Drawing.Point(796, 163);
            this.btn_next.Name = "btn_next";
            this.btn_next.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_next.Size = new System.Drawing.Size(53, 51);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 0;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // frm_explore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(884, 408);
            this.Controls.Add(this.pnl_counterServices);
            this.Controls.Add(this.btn_deleteService);
            this.Controls.Add(this.btn_openServices);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pnl_cardDns);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frm_explore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.frm_explore_Load);
            this.pnl_cardDns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dnsPicture)).EndInit();
            this.pnl_counterServices.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_latencyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnl_cardDns;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_dnsPicture;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_previewAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_latency;
        private System.Windows.Forms.Label lbl_counter;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_next;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_previous;
        private Guna.UI2.WinForms.Guna2PictureBox pb_latencyPicture;
        private Guna.UI2.WinForms.Guna2Button btn_openServices;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Panel pnl_counterServices;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btn_deleteService;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}