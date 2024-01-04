namespace ForceDNS
{
    partial class frm_network
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
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_interface = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ipAddress = new System.Windows.Forms.Label();
            this.lbl_hostName = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_activeServices = new System.Windows.Forms.Label();
            this.lbl_intrfaceDesc = new System.Windows.Forms.Label();
            this.lbl_intrfaceStatus = new System.Windows.Forms.Label();
            this.lbl_intrfaceName = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_macAddress = new System.Windows.Forms.Label();
            this.lbl_downloadSpeed = new System.Windows.Forms.Label();
            this.guna2Shapes4 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lbl_uploadSpeed = new System.Windows.Forms.Label();
            this.loadingProgressSpeed = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bf_form
            // 
            this.bf_form.BorderRadius = 15;
            this.bf_form.ContainerControl = this;
            this.bf_form.DockForm = false;
            this.bf_form.DockIndicatorTransparencyValue = 0.6D;
            this.bf_form.HasFormShadow = false;
            this.bf_form.ResizeForm = false;
            this.bf_form.TransparentWhileDrag = true;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.Location = new System.Drawing.Point(48, 303);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes1.Size = new System.Drawing.Size(846, 176);
            this.guna2Shapes1.TabIndex = 0;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Addresses: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host Name: ";
            // 
            // lbl_interface
            // 
            this.lbl_interface.AutoSize = true;
            this.lbl_interface.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interface.Font = new System.Drawing.Font("Cairo", 11F);
            this.lbl_interface.ForeColor = System.Drawing.Color.White;
            this.lbl_interface.Location = new System.Drawing.Point(326, 44);
            this.lbl_interface.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_interface.Name = "lbl_interface";
            this.lbl_interface.Size = new System.Drawing.Size(131, 29);
            this.lbl_interface.TabIndex = 1;
            this.lbl_interface.Text = "Network Interface:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cairo", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "DNS IP Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cairo", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(352, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cairo", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(352, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cairo", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(352, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Status: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cairo", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Speed: ";
            // 
            // lbl_ipAddress
            // 
            this.lbl_ipAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ipAddress.ForeColor = System.Drawing.Color.White;
            this.lbl_ipAddress.Location = new System.Drawing.Point(162, 47);
            this.lbl_ipAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ipAddress.Name = "lbl_ipAddress";
            this.lbl_ipAddress.Size = new System.Drawing.Size(149, 18);
            this.lbl_ipAddress.TabIndex = 1;
            this.lbl_ipAddress.Text = "???";
            // 
            // lbl_hostName
            // 
            this.lbl_hostName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostName.ForeColor = System.Drawing.Color.White;
            this.lbl_hostName.Location = new System.Drawing.Point(162, 120);
            this.lbl_hostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hostName.Name = "lbl_hostName";
            this.lbl_hostName.Size = new System.Drawing.Size(149, 18);
            this.lbl_hostName.TabIndex = 1;
            this.lbl_hostName.Text = "???";
            // 
            // lbl_speed
            // 
            this.lbl_speed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.White;
            this.lbl_speed.Location = new System.Drawing.Point(164, 158);
            this.lbl_speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(148, 18);
            this.lbl_speed.TabIndex = 1;
            this.lbl_speed.Text = "???";
            this.lbl_speed.Click += new System.EventHandler(this.lbl_speed_Click);
            // 
            // lbl_activeServices
            // 
            this.lbl_activeServices.BackColor = System.Drawing.Color.Transparent;
            this.lbl_activeServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activeServices.ForeColor = System.Drawing.Color.White;
            this.lbl_activeServices.Location = new System.Drawing.Point(162, 195);
            this.lbl_activeServices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_activeServices.Name = "lbl_activeServices";
            this.lbl_activeServices.Size = new System.Drawing.Size(316, 27);
            this.lbl_activeServices.TabIndex = 1;
            this.lbl_activeServices.Text = "???";
            // 
            // lbl_intrfaceDesc
            // 
            this.lbl_intrfaceDesc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrfaceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrfaceDesc.ForeColor = System.Drawing.Color.White;
            this.lbl_intrfaceDesc.Location = new System.Drawing.Point(450, 119);
            this.lbl_intrfaceDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intrfaceDesc.Name = "lbl_intrfaceDesc";
            this.lbl_intrfaceDesc.Size = new System.Drawing.Size(128, 18);
            this.lbl_intrfaceDesc.TabIndex = 1;
            this.lbl_intrfaceDesc.Text = "???";
            // 
            // lbl_intrfaceStatus
            // 
            this.lbl_intrfaceStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrfaceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrfaceStatus.ForeColor = System.Drawing.Color.White;
            this.lbl_intrfaceStatus.Location = new System.Drawing.Point(450, 159);
            this.lbl_intrfaceStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intrfaceStatus.Name = "lbl_intrfaceStatus";
            this.lbl_intrfaceStatus.Size = new System.Drawing.Size(128, 18);
            this.lbl_intrfaceStatus.TabIndex = 1;
            this.lbl_intrfaceStatus.Text = "???";
            // 
            // lbl_intrfaceName
            // 
            this.lbl_intrfaceName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrfaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrfaceName.ForeColor = System.Drawing.Color.White;
            this.lbl_intrfaceName.Location = new System.Drawing.Point(450, 81);
            this.lbl_intrfaceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intrfaceName.Name = "lbl_intrfaceName";
            this.lbl_intrfaceName.Size = new System.Drawing.Size(128, 18);
            this.lbl_intrfaceName.TabIndex = 1;
            this.lbl_intrfaceName.Text = "???";
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderColor = System.Drawing.Color.White;
            this.btn_close.BorderRadius = 5;
            this.btn_close.BorderThickness = 1;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btn_close.Font = new System.Drawing.Font("Cairo", 11F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btn_close.Location = new System.Drawing.Point(453, 259);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(116, 39);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "اغلاق";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Animated = true;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.BorderRadius = 5;
            this.btn_refresh.BorderThickness = 1;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.btn_refresh.Font = new System.Drawing.Font("Cairo", 11F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btn_refresh.Location = new System.Drawing.Point(330, 259);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(116, 39);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "تحديث";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cairo", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "MAC Address: ";
            // 
            // lbl_macAddress
            // 
            this.lbl_macAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_macAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_macAddress.ForeColor = System.Drawing.Color.White;
            this.lbl_macAddress.Location = new System.Drawing.Point(162, 84);
            this.lbl_macAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_macAddress.Name = "lbl_macAddress";
            this.lbl_macAddress.Size = new System.Drawing.Size(149, 18);
            this.lbl_macAddress.TabIndex = 1;
            this.lbl_macAddress.Text = "???";
            // 
            // lbl_downloadSpeed
            // 
            this.lbl_downloadSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_downloadSpeed.AutoSize = true;
            this.lbl_downloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_downloadSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_downloadSpeed.ForeColor = System.Drawing.Color.White;
            this.lbl_downloadSpeed.Location = new System.Drawing.Point(106, 5);
            this.lbl_downloadSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_downloadSpeed.Name = "lbl_downloadSpeed";
            this.lbl_downloadSpeed.Size = new System.Drawing.Size(56, 15);
            this.lbl_downloadSpeed.TabIndex = 9;
            this.lbl_downloadSpeed.Text = "?? MBps";
            this.lbl_downloadSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Shapes4
            // 
            this.guna2Shapes4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes4.FillColor = System.Drawing.Color.White;
            this.guna2Shapes4.Location = new System.Drawing.Point(88, 5);
            this.guna2Shapes4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes4.Name = "guna2Shapes4";
            this.guna2Shapes4.PolygonSides = 3;
            this.guna2Shapes4.PolygonSkip = 1;
            this.guna2Shapes4.Rotate = 180F;
            this.guna2Shapes4.Size = new System.Drawing.Size(14, 15);
            this.guna2Shapes4.TabIndex = 10;
            this.guna2Shapes4.Zoom = 80;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BorderRadius = 11;
            this.guna2Panel1.Controls.Add(this.guna2Shapes2);
            this.guna2Panel1.Controls.Add(this.lbl_uploadSpeed);
            this.guna2Panel1.Controls.Add(this.guna2Shapes4);
            this.guna2Panel1.Controls.Add(this.lbl_downloadSpeed);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2Panel1.Location = new System.Drawing.Point(42, 243);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(176, 25);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.FillColor = System.Drawing.Color.White;
            this.guna2Shapes2.Location = new System.Drawing.Point(16, 5);
            this.guna2Shapes2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSides = 3;
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Size = new System.Drawing.Size(14, 15);
            this.guna2Shapes2.TabIndex = 11;
            this.guna2Shapes2.Zoom = 80;
            // 
            // lbl_uploadSpeed
            // 
            this.lbl_uploadSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_uploadSpeed.AutoSize = true;
            this.lbl_uploadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uploadSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uploadSpeed.ForeColor = System.Drawing.Color.White;
            this.lbl_uploadSpeed.Location = new System.Drawing.Point(35, 5);
            this.lbl_uploadSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uploadSpeed.Name = "lbl_uploadSpeed";
            this.lbl_uploadSpeed.Size = new System.Drawing.Size(56, 15);
            this.lbl_uploadSpeed.TabIndex = 8;
            this.lbl_uploadSpeed.Text = "?? MBps";
            this.lbl_uploadSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingProgressSpeed
            // 
            this.loadingProgressSpeed.AnimationSpeed = 40;
            this.loadingProgressSpeed.CircleSize = 1F;
            this.loadingProgressSpeed.Location = new System.Drawing.Point(230, 241);
            this.loadingProgressSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.loadingProgressSpeed.Name = "loadingProgressSpeed";
            this.loadingProgressSpeed.NumberOfCircles = 3;
            this.loadingProgressSpeed.ProgressColor = System.Drawing.Color.White;
            this.loadingProgressSpeed.Size = new System.Drawing.Size(22, 27);
            this.loadingProgressSpeed.TabIndex = 14;
            // 
            // frm_network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.loadingProgressSpeed);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_interface);
            this.Controls.Add(this.lbl_activeServices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_intrfaceName);
            this.Controls.Add(this.lbl_intrfaceStatus);
            this.Controls.Add(this.lbl_intrfaceDesc);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_hostName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_macAddress);
            this.Controls.Add(this.lbl_ipAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Shapes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_network";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Information";
            this.Load += new System.EventHandler(this.frm_network_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bf_form;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_interface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_activeServices;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_hostName;
        private System.Windows.Forms.Label lbl_ipAddress;
        private System.Windows.Forms.Label lbl_intrfaceDesc;
        private System.Windows.Forms.Label lbl_intrfaceStatus;
        private System.Windows.Forms.Label lbl_intrfaceName;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private System.Windows.Forms.Label lbl_macAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_downloadSpeed;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loadingProgressSpeed;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private System.Windows.Forms.Label lbl_uploadSpeed;
    }
}