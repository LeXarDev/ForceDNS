using System;

namespace ForceDNS
{
    partial class frm_language
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_language));
            this.bf_form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbl_latency1 = new System.Windows.Forms.Label();
            this.pictureLatency1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_latency2 = new System.Windows.Forms.Label();
            this.pictureLatency2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_latencySection = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_ping = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLatency1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLatency2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnl_latencySection.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bf_form
            // 
            this.bf_form.AnimateWindow = true;
            this.bf_form.AnimationInterval = 250;
            this.bf_form.BorderRadius = 15;
            this.bf_form.ContainerControl = this;
            this.bf_form.DockIndicatorTransparencyValue = 0.6D;
            this.bf_form.ResizeForm = false;
            this.bf_form.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.bf_form.TransparentWhileDrag = true;
            // 
            // lbl_latency1
            // 
            this.lbl_latency1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_latency1.Font = new System.Drawing.Font("Cairo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latency1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_latency1.Location = new System.Drawing.Point(83, 12);
            this.lbl_latency1.Name = "lbl_latency1";
            this.lbl_latency1.Size = new System.Drawing.Size(47, 27);
            this.lbl_latency1.TabIndex = 0;
            this.lbl_latency1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureLatency1
            // 
            this.pictureLatency1.BackColor = System.Drawing.Color.Transparent;
            this.pictureLatency1.Image = ((System.Drawing.Image)(resources.GetObject("pictureLatency1.Image")));
            this.pictureLatency1.ImageRotate = 0F;
            this.pictureLatency1.Location = new System.Drawing.Point(153, 8);
            this.pictureLatency1.Name = "pictureLatency1";
            this.pictureLatency1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureLatency1.Size = new System.Drawing.Size(32, 32);
            this.pictureLatency1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLatency1.TabIndex = 13;
            this.pictureLatency1.TabStop = false;
            this.pictureLatency1.Click += new System.EventHandler(this.pictureLatency_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = ": تحديــث";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_latency2
            // 
            this.lbl_latency2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_latency2.Font = new System.Drawing.Font("Cairo Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_latency2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_latency2.Location = new System.Drawing.Point(83, 12);
            this.lbl_latency2.Name = "lbl_latency2";
            this.lbl_latency2.Size = new System.Drawing.Size(47, 27);
            this.lbl_latency2.TabIndex = 0;
            this.lbl_latency2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureLatency2
            // 
            this.pictureLatency2.BackColor = System.Drawing.Color.Transparent;
            this.pictureLatency2.Image = ((System.Drawing.Image)(resources.GetObject("pictureLatency2.Image")));
            this.pictureLatency2.ImageRotate = 0F;
            this.pictureLatency2.Location = new System.Drawing.Point(153, 9);
            this.pictureLatency2.Name = "pictureLatency2";
            this.pictureLatency2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureLatency2.Size = new System.Drawing.Size(32, 35);
            this.pictureLatency2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLatency2.TabIndex = 13;
            this.pictureLatency2.TabStop = false;
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
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_refresh.Location = new System.Drawing.Point(327, 313);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(48, 38);
            this.btn_refresh.TabIndex = 48;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 11;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ForceDNS.Properties.Resources.callofduty;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 42);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 56;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 13;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::ForceDNS.Properties.Resources.Fortnite_F_lettermark_logo;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(17, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(42, 42);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 57;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Fortnite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cairo", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 59;
            this.label3.Text = "Call Of Duty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_latencySection
            // 
            this.pnl_latencySection.BorderColor = System.Drawing.Color.White;
            this.pnl_latencySection.BorderRadius = 5;
            this.pnl_latencySection.BorderThickness = 1;
            this.pnl_latencySection.Controls.Add(this.pictureLatency1);
            this.pnl_latencySection.Controls.Add(this.lbl_latency1);
            this.pnl_latencySection.Controls.Add(this.btn_ping);
            this.pnl_latencySection.Controls.Add(this.guna2PictureBox1);
            this.pnl_latencySection.Location = new System.Drawing.Point(278, 109);
            this.pnl_latencySection.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_latencySection.Name = "pnl_latencySection";
            this.pnl_latencySection.Size = new System.Drawing.Size(205, 50);
            this.pnl_latencySection.TabIndex = 60;
            // 
            // btn_ping
            // 
            this.btn_ping.Animated = true;
            this.btn_ping.BackColor = System.Drawing.Color.Transparent;
            this.btn_ping.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ping.BorderRadius = 11;
            this.btn_ping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ping.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ping.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ping.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ping.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ping.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ping.Font = new System.Drawing.Font("Cairo", 12F);
            this.btn_ping.ForeColor = System.Drawing.Color.White;
            this.btn_ping.Location = new System.Drawing.Point(72, 12);
            this.btn_ping.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(70, 27);
            this.btn_ping.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbl_latency2);
            this.guna2Panel1.Controls.Add(this.pictureLatency2);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(278, 194);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(205, 50);
            this.guna2Panel1.TabIndex = 61;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 11;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button1.Font = new System.Drawing.Font("Cairo", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(72, 12);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(70, 27);
            this.guna2Button1.TabIndex = 3;
            // 
            // frm_language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 408);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnl_latencySection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_language";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_language";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frm_language_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLatency1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLatency2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnl_latencySection.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void pictureLatency_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bf_form;
        private System.Windows.Forms.Label lbl_latency1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureLatency1;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_latency2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureLatency2;
        private System.Windows.Forms.Timer pingTimer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnl_latencySection;
        private Guna.UI2.WinForms.Guna2Button btn_ping;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}