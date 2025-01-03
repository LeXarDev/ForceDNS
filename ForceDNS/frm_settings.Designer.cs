﻿namespace ForceDNS
{
    partial class frm_settings
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
            this.pnl_container = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_networkInformation = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.cb_autoUpdate = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ts_discordRPC = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.cb_minimizeInTray = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.cb_launchOnWindows = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.lbl_automaticUpdate = new System.Windows.Forms.Label();
            this.lbl_minimizeInTray = new System.Windows.Forms.Label();
            this.btn_languagePanel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateSofware = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_launchOnWindows = new System.Windows.Forms.Label();
            this.lbl_discordDescription = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.BorderRadius = 10;
            this.pnl_container.Controls.Add(this.btn_networkInformation);
            this.pnl_container.Controls.Add(this.guna2Shapes1);
            this.pnl_container.Controls.Add(this.cb_autoUpdate);
            this.pnl_container.Controls.Add(this.ts_discordRPC);
            this.pnl_container.Controls.Add(this.cb_minimizeInTray);
            this.pnl_container.Controls.Add(this.cb_launchOnWindows);
            this.pnl_container.Controls.Add(this.lbl_theme);
            this.pnl_container.Controls.Add(this.lbl_automaticUpdate);
            this.pnl_container.Controls.Add(this.lbl_minimizeInTray);
            this.pnl_container.Controls.Add(this.btn_updateSofware);
            this.pnl_container.Controls.Add(this.lbl_launchOnWindows);
            this.pnl_container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.pnl_container.Location = new System.Drawing.Point(100, 21);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(685, 362);
            this.pnl_container.TabIndex = 0;
            // 
            // btn_networkInformation
            // 
            this.btn_networkInformation.Animated = true;
            this.btn_networkInformation.BorderColor = System.Drawing.Color.White;
            this.btn_networkInformation.BorderRadius = 5;
            this.btn_networkInformation.BorderThickness = 1;
            this.btn_networkInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_networkInformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_networkInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_networkInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_networkInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_networkInformation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btn_networkInformation.Font = new System.Drawing.Font("Cairo", 11F);
            this.btn_networkInformation.ForeColor = System.Drawing.Color.White;
            this.btn_networkInformation.Image = global::ForceDNS.Properties.Resources.network;
            this.btn_networkInformation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_networkInformation.Location = new System.Drawing.Point(454, 301);
            this.btn_networkInformation.Name = "btn_networkInformation";
            this.btn_networkInformation.Size = new System.Drawing.Size(207, 36);
            this.btn_networkInformation.TabIndex = 26;
            this.btn_networkInformation.Text = "مـعلومات الشبكة";
            this.btn_networkInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_networkInformation.Click += new System.EventHandler(this.btn_networkInformation_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Silver;
            this.guna2Shapes1.LineThickness = 1;
            this.guna2Shapes1.Location = new System.Drawing.Point(28, 280);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(625, 10);
            this.guna2Shapes1.TabIndex = 24;
            this.guna2Shapes1.Zoom = 100;
            // 
            // cb_autoUpdate
            // 
            this.cb_autoUpdate.Animated = true;
            this.cb_autoUpdate.AutoRoundedCorners = true;
            this.cb_autoUpdate.BackColor = System.Drawing.Color.Transparent;
            this.cb_autoUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_autoUpdate.CheckedState.BorderRadius = 11;
            this.cb_autoUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_autoUpdate.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cb_autoUpdate.CheckedState.InnerBorderRadius = 7;
            this.cb_autoUpdate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb_autoUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_autoUpdate.Location = new System.Drawing.Point(606, 205);
            this.cb_autoUpdate.Name = "cb_autoUpdate";
            this.cb_autoUpdate.Size = new System.Drawing.Size(55, 24);
            this.cb_autoUpdate.TabIndex = 23;
            this.cb_autoUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_autoUpdate.UncheckedState.BorderRadius = 11;
            this.cb_autoUpdate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_autoUpdate.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cb_autoUpdate.UncheckedState.InnerBorderRadius = 7;
            this.cb_autoUpdate.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.cb_autoUpdate.CheckedChanged += new System.EventHandler(this.cb_autoUpdate_CheckedChanged);
            // 
            // ts_discordRPC
            // 
            this.ts_discordRPC.Animated = true;
            this.ts_discordRPC.AutoRoundedCorners = true;
            this.ts_discordRPC.BackColor = System.Drawing.Color.Transparent;
            this.ts_discordRPC.Checked = true;
            this.ts_discordRPC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_discordRPC.CheckedState.BorderRadius = 11;
            this.ts_discordRPC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_discordRPC.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_discordRPC.CheckedState.InnerBorderRadius = 7;
            this.ts_discordRPC.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_discordRPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ts_discordRPC.Location = new System.Drawing.Point(606, 149);
            this.ts_discordRPC.Name = "ts_discordRPC";
            this.ts_discordRPC.Size = new System.Drawing.Size(55, 24);
            this.ts_discordRPC.TabIndex = 23;
            this.ts_discordRPC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_discordRPC.UncheckedState.BorderRadius = 11;
            this.ts_discordRPC.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_discordRPC.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_discordRPC.UncheckedState.InnerBorderRadius = 7;
            this.ts_discordRPC.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_discordRPC.CheckedChanged += new System.EventHandler(this.ts_discordRPC_CheckedChanged);
            // 
            // cb_minimizeInTray
            // 
            this.cb_minimizeInTray.Animated = true;
            this.cb_minimizeInTray.AutoRoundedCorners = true;
            this.cb_minimizeInTray.BackColor = System.Drawing.Color.Transparent;
            this.cb_minimizeInTray.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_minimizeInTray.CheckedState.BorderRadius = 11;
            this.cb_minimizeInTray.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_minimizeInTray.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cb_minimizeInTray.CheckedState.InnerBorderRadius = 7;
            this.cb_minimizeInTray.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb_minimizeInTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_minimizeInTray.Location = new System.Drawing.Point(606, 97);
            this.cb_minimizeInTray.Name = "cb_minimizeInTray";
            this.cb_minimizeInTray.Size = new System.Drawing.Size(55, 24);
            this.cb_minimizeInTray.TabIndex = 23;
            this.cb_minimizeInTray.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_minimizeInTray.UncheckedState.BorderRadius = 11;
            this.cb_minimizeInTray.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_minimizeInTray.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cb_minimizeInTray.UncheckedState.InnerBorderRadius = 7;
            this.cb_minimizeInTray.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.cb_minimizeInTray.CheckedChanged += new System.EventHandler(this.cb_minimizeInTray_CheckedChanged);
            // 
            // cb_launchOnWindows
            // 
            this.cb_launchOnWindows.Animated = true;
            this.cb_launchOnWindows.AutoRoundedCorners = true;
            this.cb_launchOnWindows.BackColor = System.Drawing.Color.Transparent;
            this.cb_launchOnWindows.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_launchOnWindows.CheckedState.BorderRadius = 11;
            this.cb_launchOnWindows.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_launchOnWindows.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cb_launchOnWindows.CheckedState.InnerBorderRadius = 7;
            this.cb_launchOnWindows.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb_launchOnWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_launchOnWindows.Location = new System.Drawing.Point(606, 35);
            this.cb_launchOnWindows.Name = "cb_launchOnWindows";
            this.cb_launchOnWindows.Size = new System.Drawing.Size(55, 24);
            this.cb_launchOnWindows.TabIndex = 23;
            this.cb_launchOnWindows.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_launchOnWindows.UncheckedState.BorderRadius = 11;
            this.cb_launchOnWindows.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_launchOnWindows.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cb_launchOnWindows.UncheckedState.InnerBorderRadius = 7;
            this.cb_launchOnWindows.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.cb_launchOnWindows.CheckedChanged += new System.EventHandler(this.cb_launchOnWindows_CheckedChanged);
            // 
            // lbl_theme
            // 
            this.lbl_theme.BackColor = System.Drawing.Color.Transparent;
            this.lbl_theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_theme.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_theme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_theme.Location = new System.Drawing.Point(503, 146);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(226, 28);
            this.lbl_theme.TabIndex = 21;
            this.lbl_theme.Text = "حالة الدسكورد";
            this.lbl_theme.Click += new System.EventHandler(this.lbl_theme_Click);
            // 
            // lbl_automaticUpdate
            // 
            this.lbl_automaticUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_automaticUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_automaticUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_automaticUpdate.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_automaticUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_automaticUpdate.Location = new System.Drawing.Point(494, 202);
            this.lbl_automaticUpdate.Name = "lbl_automaticUpdate";
            this.lbl_automaticUpdate.Size = new System.Drawing.Size(239, 28);
            this.lbl_automaticUpdate.TabIndex = 21;
            this.lbl_automaticUpdate.Text = "التحديث التلقائي";
            this.lbl_automaticUpdate.Click += new System.EventHandler(this.lbl_automaticUpdate_Click);
            // 
            // lbl_minimizeInTray
            // 
            this.lbl_minimizeInTray.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minimizeInTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimizeInTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_minimizeInTray.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_minimizeInTray.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_minimizeInTray.Location = new System.Drawing.Point(509, 94);
            this.lbl_minimizeInTray.Name = "lbl_minimizeInTray";
            this.lbl_minimizeInTray.Size = new System.Drawing.Size(226, 28);
            this.lbl_minimizeInTray.TabIndex = 21;
            this.lbl_minimizeInTray.Text = "تصغير البرنامج";
            this.lbl_minimizeInTray.Click += new System.EventHandler(this.lbl_minimizeInTray_Click);
            // 
            // btn_languagePanel
            // 
            this.btn_languagePanel.Animated = true;
            this.btn_languagePanel.AnimatedGIF = true;
            this.btn_languagePanel.BackColor = System.Drawing.Color.Transparent;
            this.btn_languagePanel.BorderColor = System.Drawing.Color.White;
            this.btn_languagePanel.BorderRadius = 5;
            this.btn_languagePanel.BorderThickness = 1;
            this.btn_languagePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_languagePanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_languagePanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_languagePanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_languagePanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_languagePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btn_languagePanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_languagePanel.ForeColor = System.Drawing.Color.White;
            this.btn_languagePanel.Image = global::ForceDNS.Properties.Resources.united_kingdom;
            this.btn_languagePanel.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_languagePanel.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_languagePanel.Location = new System.Drawing.Point(898, 286);
            this.btn_languagePanel.Name = "btn_languagePanel";
            this.btn_languagePanel.Size = new System.Drawing.Size(106, 36);
            this.btn_languagePanel.TabIndex = 22;
            this.btn_languagePanel.Text = "EN";
            this.btn_languagePanel.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btn_languagePanel.Visible = false;
            this.btn_languagePanel.Click += new System.EventHandler(this.btn_languagePanel_Click);
            // 
            // btn_updateSofware
            // 
            this.btn_updateSofware.Animated = true;
            this.btn_updateSofware.AnimatedGIF = true;
            this.btn_updateSofware.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateSofware.BorderColor = System.Drawing.Color.White;
            this.btn_updateSofware.BorderRadius = 5;
            this.btn_updateSofware.BorderThickness = 1;
            this.btn_updateSofware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateSofware.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateSofware.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateSofware.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateSofware.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateSofware.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btn_updateSofware.Font = new System.Drawing.Font("Cairo", 11F);
            this.btn_updateSofware.ForeColor = System.Drawing.Color.White;
            this.btn_updateSofware.Image = global::ForceDNS.Properties.Resources.update;
            this.btn_updateSofware.Location = new System.Drawing.Point(31, 301);
            this.btn_updateSofware.Name = "btn_updateSofware";
            this.btn_updateSofware.Size = new System.Drawing.Size(173, 36);
            this.btn_updateSofware.TabIndex = 22;
            this.btn_updateSofware.Text = "التحقق من التحديثات";
            this.btn_updateSofware.Click += new System.EventHandler(this.btn_updateSofware_Click);
            // 
            // lbl_launchOnWindows
            // 
            this.lbl_launchOnWindows.BackColor = System.Drawing.Color.Transparent;
            this.lbl_launchOnWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_launchOnWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_launchOnWindows.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_launchOnWindows.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_launchOnWindows.Location = new System.Drawing.Point(482, 35);
            this.lbl_launchOnWindows.Name = "lbl_launchOnWindows";
            this.lbl_launchOnWindows.Size = new System.Drawing.Size(239, 28);
            this.lbl_launchOnWindows.TabIndex = 21;
            this.lbl_launchOnWindows.Text = "التشغيل مع النظام";
            this.lbl_launchOnWindows.Click += new System.EventHandler(this.lbl_launchOnWindows_Click);
            // 
            // lbl_discordDescription
            // 
            this.lbl_discordDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discordDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_discordDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discordDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_discordDescription.Location = new System.Drawing.Point(895, 228);
            this.lbl_discordDescription.Name = "lbl_discordDescription";
            this.lbl_discordDescription.Size = new System.Drawing.Size(279, 42);
            this.lbl_discordDescription.TabIndex = 21;
            this.lbl_discordDescription.Text = "Show your active service in your activity";
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(884, 408);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.btn_languagePanel);
            this.Controls.Add(this.lbl_discordDescription);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_setttings_Load);
            this.pnl_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_container;
        private Guna.UI2.WinForms.Guna2ToggleSwitch cb_launchOnWindows;
        private System.Windows.Forms.Label lbl_launchOnWindows;
        private Guna.UI2.WinForms.Guna2ToggleSwitch cb_autoUpdate;
        private System.Windows.Forms.Label lbl_automaticUpdate;
        private Guna.UI2.WinForms.Guna2ToggleSwitch cb_minimizeInTray;
        private System.Windows.Forms.Label lbl_minimizeInTray;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ts_discordRPC;
        private System.Windows.Forms.Label lbl_theme;
        private Guna.UI2.WinForms.Guna2Button btn_networkInformation;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Button btn_updateSofware;
        private Guna.UI2.WinForms.Guna2Button btn_languagePanel;
        private System.Windows.Forms.Label lbl_discordDescription;
    }
}