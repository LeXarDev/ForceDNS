namespace ForceDNS
{
    partial class frm_networkAdapter
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
            this.bf_form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbl_hintNetworkAdapter = new System.Windows.Forms.Label();
            this.cb_selectNetworkAdapter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_networkInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_interface = new System.Windows.Forms.Label();
            this.lbl_intrfaceName = new System.Windows.Forms.Label();
            this.lbl_intrfaceStatus = new System.Windows.Forms.Label();
            this.lbl_intrfaceDesc = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_networkInformation.SuspendLayout();
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
            // lbl_hintNetworkAdapter
            // 
            this.lbl_hintNetworkAdapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lbl_hintNetworkAdapter.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_hintNetworkAdapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_hintNetworkAdapter.Location = new System.Drawing.Point(49, 54);
            this.lbl_hintNetworkAdapter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hintNetworkAdapter.Name = "lbl_hintNetworkAdapter";
            this.lbl_hintNetworkAdapter.Size = new System.Drawing.Size(157, 15);
            this.lbl_hintNetworkAdapter.TabIndex = 34;
            this.lbl_hintNetworkAdapter.Text = "Select a Network Adapter";
            this.lbl_hintNetworkAdapter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_hintNetworkAdapter.UseCompatibleTextRendering = true;
            // 
            // cb_selectNetworkAdapter
            // 
            this.cb_selectNetworkAdapter.BackColor = System.Drawing.Color.Transparent;
            this.cb_selectNetworkAdapter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cb_selectNetworkAdapter.BorderRadius = 5;
            this.cb_selectNetworkAdapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_selectNetworkAdapter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cb_selectNetworkAdapter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_selectNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_selectNetworkAdapter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cb_selectNetworkAdapter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_selectNetworkAdapter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_selectNetworkAdapter.Font = new System.Drawing.Font("Cairo", 11F);
            this.cb_selectNetworkAdapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_selectNetworkAdapter.ItemHeight = 40;
            this.cb_selectNetworkAdapter.Location = new System.Drawing.Point(41, 42);
            this.cb_selectNetworkAdapter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_selectNetworkAdapter.Name = "cb_selectNetworkAdapter";
            this.cb_selectNetworkAdapter.Size = new System.Drawing.Size(240, 46);
            this.cb_selectNetworkAdapter.TabIndex = 35;
            this.cb_selectNetworkAdapter.TextOffset = new System.Drawing.Point(20, 0);
            this.cb_selectNetworkAdapter.SelectedIndexChanged += new System.EventHandler(this.cb_selectNetworkAdapter_SelectedIndexChanged);
            // 
            // pnl_networkInformation
            // 
            this.pnl_networkInformation.BorderColor = System.Drawing.Color.White;
            this.pnl_networkInformation.BorderRadius = 5;
            this.pnl_networkInformation.BorderThickness = 1;
            this.pnl_networkInformation.Controls.Add(this.label5);
            this.pnl_networkInformation.Controls.Add(this.label7);
            this.pnl_networkInformation.Controls.Add(this.label6);
            this.pnl_networkInformation.Controls.Add(this.lbl_interface);
            this.pnl_networkInformation.Controls.Add(this.lbl_intrfaceName);
            this.pnl_networkInformation.Controls.Add(this.lbl_intrfaceStatus);
            this.pnl_networkInformation.Controls.Add(this.lbl_intrfaceDesc);
            this.pnl_networkInformation.Location = new System.Drawing.Point(41, 99);
            this.pnl_networkInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_networkInformation.Name = "pnl_networkInformation";
            this.pnl_networkInformation.Size = new System.Drawing.Size(239, 177);
            this.pnl_networkInformation.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description: ";
            // 
            // lbl_interface
            // 
            this.lbl_interface.AutoSize = true;
            this.lbl_interface.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interface.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interface.ForeColor = System.Drawing.Color.White;
            this.lbl_interface.Location = new System.Drawing.Point(19, 20);
            this.lbl_interface.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_interface.Name = "lbl_interface";
            this.lbl_interface.Size = new System.Drawing.Size(122, 17);
            this.lbl_interface.TabIndex = 5;
            this.lbl_interface.Text = "Network Interface:";
            // 
            // lbl_intrfaceName
            // 
            this.lbl_intrfaceName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrfaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrfaceName.ForeColor = System.Drawing.Color.White;
            this.lbl_intrfaceName.Location = new System.Drawing.Point(117, 62);
            this.lbl_intrfaceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intrfaceName.Name = "lbl_intrfaceName";
            this.lbl_intrfaceName.Size = new System.Drawing.Size(105, 18);
            this.lbl_intrfaceName.TabIndex = 6;
            this.lbl_intrfaceName.Text = "???";
            // 
            // lbl_intrfaceStatus
            // 
            this.lbl_intrfaceStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrfaceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrfaceStatus.ForeColor = System.Drawing.Color.White;
            this.lbl_intrfaceStatus.Location = new System.Drawing.Point(117, 133);
            this.lbl_intrfaceStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intrfaceStatus.Name = "lbl_intrfaceStatus";
            this.lbl_intrfaceStatus.Size = new System.Drawing.Size(105, 18);
            this.lbl_intrfaceStatus.TabIndex = 7;
            this.lbl_intrfaceStatus.Text = "???";
            // 
            // lbl_intrfaceDesc
            // 
            this.lbl_intrfaceDesc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrfaceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrfaceDesc.ForeColor = System.Drawing.Color.White;
            this.lbl_intrfaceDesc.Location = new System.Drawing.Point(117, 99);
            this.lbl_intrfaceDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intrfaceDesc.Name = "lbl_intrfaceDesc";
            this.lbl_intrfaceDesc.Size = new System.Drawing.Size(105, 18);
            this.lbl_intrfaceDesc.TabIndex = 8;
            this.lbl_intrfaceDesc.Text = "???";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Animated = true;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BorderRadius = 5;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Font = new System.Drawing.Font("Cairo", 11F);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(41, 291);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(116, 32);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Animated = true;
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BorderColor = System.Drawing.Color.White;
            this.btn_confirm.BorderRadius = 5;
            this.btn_confirm.BorderThickness = 1;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btn_confirm.Font = new System.Drawing.Font("Cairo", 11F);
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(162, 291);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(118, 32);
            this.btn_confirm.TabIndex = 31;
            this.btn_confirm.Text = "تاكيد";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // frm_networkAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(321, 365);
            this.Controls.Add(this.lbl_hintNetworkAdapter);
            this.Controls.Add(this.cb_selectNetworkAdapter);
            this.Controls.Add(this.pnl_networkInformation);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_networkAdapter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_networkAdapter";
            this.Load += new System.EventHandler(this.frm_networkAdapter_Load);
            this.pnl_networkInformation.ResumeLayout(false);
            this.pnl_networkInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm bf_form;
        private System.Windows.Forms.Label lbl_hintNetworkAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox cb_selectNetworkAdapter;
        private Guna.UI2.WinForms.Guna2Panel pnl_networkInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_interface;
        private System.Windows.Forms.Label lbl_intrfaceName;
        private System.Windows.Forms.Label lbl_intrfaceStatus;
        private System.Windows.Forms.Label lbl_intrfaceDesc;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_confirm;
    }
}