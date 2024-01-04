namespace ForceDNS
{
    partial class frm_ping
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
            this.lbl_descriptionDeveloper = new System.Windows.Forms.Label();
            this.lbl_nameDeveloper = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_github = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pb_aboutPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_instagram = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_telegram = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aboutPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_descriptionDeveloper
            // 
            this.lbl_descriptionDeveloper.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_descriptionDeveloper.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_descriptionDeveloper.Location = new System.Drawing.Point(66, 187);
            this.lbl_descriptionDeveloper.Name = "lbl_descriptionDeveloper";
            this.lbl_descriptionDeveloper.Size = new System.Drawing.Size(209, 35);
            this.lbl_descriptionDeveloper.TabIndex = 1;
            this.lbl_descriptionDeveloper.Text = "Founder , Lead Developer";
            this.lbl_descriptionDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameDeveloper
            // 
            this.lbl_nameDeveloper.Font = new System.Drawing.Font("Cairo Medium", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_nameDeveloper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nameDeveloper.Location = new System.Drawing.Point(98, 158);
            this.lbl_nameDeveloper.Name = "lbl_nameDeveloper";
            this.lbl_nameDeveloper.Size = new System.Drawing.Size(147, 36);
            this.lbl_nameDeveloper.TabIndex = 1;
            this.lbl_nameDeveloper.Text = "Khalid | خـالد";
            this.lbl_nameDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nameDeveloper.Click += new System.EventHandler(this.lbl_nameDeveloper_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_github);
            this.guna2CustomGradientPanel2.Controls.Add(this.pb_aboutPicture);
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_instagram);
            this.guna2CustomGradientPanel2.Controls.Add(this.lbl_nameDeveloper);
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_telegram);
            this.guna2CustomGradientPanel2.Controls.Add(this.lbl_descriptionDeveloper);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(268, 42);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(335, 325);
            this.guna2CustomGradientPanel2.TabIndex = 2;
            this.guna2CustomGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel2_Paint);
            // 
            // btn_github
            // 
            this.btn_github.Animated = true;
            this.btn_github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_github.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_github.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_github.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_github.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_github.FillColor = System.Drawing.Color.Transparent;
            this.btn_github.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_github.ForeColor = System.Drawing.Color.White;
            this.btn_github.Image = global::ForceDNS.Properties.Resources.social;
            this.btn_github.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_github.Location = new System.Drawing.Point(207, 250);
            this.btn_github.Name = "btn_github";
            this.btn_github.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_github.Size = new System.Drawing.Size(48, 46);
            this.btn_github.TabIndex = 2;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            this.btn_github.MouseLeave += new System.EventHandler(this.unFocusSocialMedia);
            this.btn_github.MouseMove += new System.Windows.Forms.MouseEventHandler(this.focusSocialMedia);
            // 
            // pb_aboutPicture
            // 
            this.pb_aboutPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_aboutPicture.FillColor = System.Drawing.Color.Transparent;
            this.pb_aboutPicture.Image = global::ForceDNS.Properties.Resources.lexardev;
            this.pb_aboutPicture.ImageRotate = 0F;
            this.pb_aboutPicture.Location = new System.Drawing.Point(116, 40);
            this.pb_aboutPicture.Name = "pb_aboutPicture";
            this.pb_aboutPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_aboutPicture.Size = new System.Drawing.Size(109, 111);
            this.pb_aboutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_aboutPicture.TabIndex = 0;
            this.pb_aboutPicture.TabStop = false;
            this.pb_aboutPicture.Click += new System.EventHandler(this.pb_aboutPicture_Click);
            // 
            // btn_instagram
            // 
            this.btn_instagram.Animated = true;
            this.btn_instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_instagram.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_instagram.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_instagram.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_instagram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_instagram.FillColor = System.Drawing.Color.Transparent;
            this.btn_instagram.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_instagram.ForeColor = System.Drawing.Color.White;
            this.btn_instagram.Image = global::ForceDNS.Properties.Resources.instagram1;
            this.btn_instagram.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_instagram.Location = new System.Drawing.Point(149, 250);
            this.btn_instagram.Name = "btn_instagram";
            this.btn_instagram.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_instagram.Size = new System.Drawing.Size(48, 46);
            this.btn_instagram.TabIndex = 2;
            this.btn_instagram.Click += new System.EventHandler(this.btn_instagram_Click);
            this.btn_instagram.MouseLeave += new System.EventHandler(this.unFocusSocialMedia);
            this.btn_instagram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.focusSocialMedia);
            // 
            // btn_telegram
            // 
            this.btn_telegram.Animated = true;
            this.btn_telegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_telegram.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_telegram.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_telegram.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_telegram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_telegram.FillColor = System.Drawing.Color.Transparent;
            this.btn_telegram.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_telegram.ForeColor = System.Drawing.Color.White;
            this.btn_telegram.Image = global::ForceDNS.Properties.Resources.twitter;
            this.btn_telegram.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_telegram.Location = new System.Drawing.Point(91, 250);
            this.btn_telegram.Name = "btn_telegram";
            this.btn_telegram.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_telegram.Size = new System.Drawing.Size(48, 46);
            this.btn_telegram.TabIndex = 2;
            this.btn_telegram.Click += new System.EventHandler(this.btn_telegram_Click);
            this.btn_telegram.MouseLeave += new System.EventHandler(this.unFocusSocialMedia);
            this.btn_telegram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.focusSocialMedia);
            // 
            // frm_ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(884, 408);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_ping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frm_ping_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_aboutPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_aboutPicture;
        private System.Windows.Forms.Label lbl_nameDeveloper;
        private System.Windows.Forms.Label lbl_descriptionDeveloper;
        private Guna.UI2.WinForms.Guna2CircleButton btn_telegram;
        private Guna.UI2.WinForms.Guna2CircleButton btn_github;
        private Guna.UI2.WinForms.Guna2CircleButton btn_instagram;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
    }
}