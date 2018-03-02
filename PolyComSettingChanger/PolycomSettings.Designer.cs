namespace PolyComSettingChanger
{
    partial class PolycomSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SavePolling = new System.Windows.Forms.Button();
            this.Requester = new System.Windows.Forms.CheckBox();
            this.PollUrl = new System.Windows.Forms.CheckBox();
            this.Usernameval = new System.Windows.Forms.TextBox();
            this.Passwordval = new System.Windows.Forms.TextBox();
            this.Phonebackup = new System.Windows.Forms.Button();
            this.IpofPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.configbtn = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.callstatechangeurl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentuserval = new System.Windows.Forms.TextBox();
            this.curruserpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.olduserpass = new System.Windows.Forms.TextBox();
            this.newuserpass = new System.Windows.Forms.TextBox();
            this.confirmuserpass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SaveAdminLogin = new System.Windows.Forms.Button();
            this.GetIpsbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VehicleRegInfo = new System.Windows.Forms.Button();
            this.Importbtn = new System.Windows.Forms.Button();
            this.Importfilepath = new System.Windows.Forms.TextBox();
            this.Importfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.Restorebtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Installservice = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.servicepath = new System.Windows.Forms.TextBox();
            this.servicepathlabel = new System.Windows.Forms.Label();
            this.installservicedialoga = new System.Windows.Forms.OpenFileDialog();
            this.attachbtn = new System.Windows.Forms.Button();
            this.servicelisteneriplablel = new System.Windows.Forms.Label();
            this.ServiceIp = new System.Windows.Forms.TextBox();
            this.Servicelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.serviceinstallpanel = new System.Windows.Forms.Panel();
            this.DoneInstall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.serviceinstallpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // PhoneState
            // 
            this.PhoneState.AutoSize = true;
            this.PhoneState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneState.Location = new System.Drawing.Point(135, 41);
            this.PhoneState.Name = "PhoneState";
            this.PhoneState.Size = new System.Drawing.Size(201, 25);
            this.PhoneState.TabIndex = 1;
            this.PhoneState.Text = "Phone State Polling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Response Mode";
            // 
            // SavePolling
            // 
            this.SavePolling.Location = new System.Drawing.Point(136, 480);
            this.SavePolling.Name = "SavePolling";
            this.SavePolling.Size = new System.Drawing.Size(75, 23);
            this.SavePolling.TabIndex = 8;
            this.SavePolling.Text = "Save";
            this.SavePolling.UseVisualStyleBackColor = true;
            this.SavePolling.Click += new System.EventHandler(this.Savepolling_Onclick);
            // 
            // Requester
            // 
            this.Requester.AutoSize = true;
            this.Requester.Location = new System.Drawing.Point(272, 334);
            this.Requester.Name = "Requester";
            this.Requester.Size = new System.Drawing.Size(75, 17);
            this.Requester.TabIndex = 5;
            this.Requester.Text = "Requester";
            this.Requester.UseVisualStyleBackColor = true;
            this.Requester.CheckedChanged += new System.EventHandler(this.Requester_CheckedChanged);
            // 
            // PollUrl
            // 
            this.PollUrl.AutoSize = true;
            this.PollUrl.Location = new System.Drawing.Point(140, 334);
            this.PollUrl.Name = "PollUrl";
            this.PollUrl.Size = new System.Drawing.Size(56, 17);
            this.PollUrl.TabIndex = 4;
            this.PollUrl.Text = "PollUrl";
            this.PollUrl.UseVisualStyleBackColor = true;
            this.PollUrl.CheckedChanged += new System.EventHandler(this.PollUrl_CheckedChanged);
            // 
            // Usernameval
            // 
            this.Usernameval.Location = new System.Drawing.Point(140, 232);
            this.Usernameval.MaxLength = 20;
            this.Usernameval.Name = "Usernameval";
            this.Usernameval.Size = new System.Drawing.Size(207, 20);
            this.Usernameval.TabIndex = 2;
            // 
            // Passwordval
            // 
            this.Passwordval.Location = new System.Drawing.Point(140, 283);
            this.Passwordval.MaxLength = 20;
            this.Passwordval.Name = "Passwordval";
            this.Passwordval.PasswordChar = '*';
            this.Passwordval.Size = new System.Drawing.Size(207, 20);
            this.Passwordval.TabIndex = 3;
            // 
            // Phonebackup
            // 
            this.Phonebackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Phonebackup.Location = new System.Drawing.Point(704, 378);
            this.Phonebackup.Name = "Phonebackup";
            this.Phonebackup.Size = new System.Drawing.Size(91, 70);
            this.Phonebackup.TabIndex = 15;
            this.Phonebackup.Text = "PhoneBackup";
            this.Phonebackup.UseVisualStyleBackColor = false;
            this.Phonebackup.Click += new System.EventHandler(this.Phonebackup_Click);
            // 
            // IpofPhone
            // 
            this.IpofPhone.Location = new System.Drawing.Point(138, 378);
            this.IpofPhone.MaxLength = 15;
            this.IpofPhone.Name = "IpofPhone";
            this.IpofPhone.Size = new System.Drawing.Size(207, 20);
            this.IpofPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PolycomIPAddress";
            // 
            // configbtn
            // 
            this.configbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.configbtn.Location = new System.Drawing.Point(510, 378);
            this.configbtn.Name = "configbtn";
            this.configbtn.Size = new System.Drawing.Size(91, 70);
            this.configbtn.TabIndex = 13;
            this.configbtn.Text = "ConfigBackup";
            this.configbtn.UseVisualStyleBackColor = false;
            this.configbtn.Click += new System.EventHandler(this.configbtn_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Restart.Location = new System.Drawing.Point(607, 378);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(91, 70);
            this.Restart.TabIndex = 14;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // callstatechangeurl
            // 
            this.callstatechangeurl.Location = new System.Drawing.Point(136, 428);
            this.callstatechangeurl.MaxLength = 30;
            this.callstatechangeurl.Name = "callstatechangeurl";
            this.callstatechangeurl.Size = new System.Drawing.Size(207, 20);
            this.callstatechangeurl.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "CallChangeListener";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Controls";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "CurrentUserName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "CurrentPassword";
            // 
            // currentuserval
            // 
            this.currentuserval.Enabled = false;
            this.currentuserval.Location = new System.Drawing.Point(140, 121);
            this.currentuserval.Name = "currentuserval";
            this.currentuserval.Size = new System.Drawing.Size(207, 20);
            this.currentuserval.TabIndex = 0;
            this.currentuserval.Text = "Polycom";
            // 
            // curruserpass
            // 
            this.curruserpass.Location = new System.Drawing.Point(140, 173);
            this.curruserpass.Name = "curruserpass";
            this.curruserpass.PasswordChar = '*';
            this.curruserpass.Size = new System.Drawing.Size(207, 20);
            this.curruserpass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Change Admin Login ";
            // 
            // olduserpass
            // 
            this.olduserpass.Location = new System.Drawing.Point(514, 121);
            this.olduserpass.Name = "olduserpass";
            this.olduserpass.PasswordChar = '*';
            this.olduserpass.Size = new System.Drawing.Size(236, 20);
            this.olduserpass.TabIndex = 9;
            // 
            // newuserpass
            // 
            this.newuserpass.Location = new System.Drawing.Point(514, 176);
            this.newuserpass.Name = "newuserpass";
            this.newuserpass.PasswordChar = '*';
            this.newuserpass.Size = new System.Drawing.Size(236, 20);
            this.newuserpass.TabIndex = 10;
            // 
            // confirmuserpass
            // 
            this.confirmuserpass.Location = new System.Drawing.Point(514, 229);
            this.confirmuserpass.Name = "confirmuserpass";
            this.confirmuserpass.PasswordChar = '*';
            this.confirmuserpass.Size = new System.Drawing.Size(236, 20);
            this.confirmuserpass.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "OldPassword";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "NewPassword";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(392, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "ConfirmPassword";
            // 
            // SaveAdminLogin
            // 
            this.SaveAdminLogin.Location = new System.Drawing.Point(514, 279);
            this.SaveAdminLogin.Name = "SaveAdminLogin";
            this.SaveAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.SaveAdminLogin.TabIndex = 12;
            this.SaveAdminLogin.Text = "Save";
            this.SaveAdminLogin.UseVisualStyleBackColor = true;
            this.SaveAdminLogin.Click += new System.EventHandler(this.SaveAdminLogin_Click);
            // 
            // GetIpsbtn
            // 
            this.GetIpsbtn.Location = new System.Drawing.Point(924, 378);
            this.GetIpsbtn.Name = "GetIpsbtn";
            this.GetIpsbtn.Size = new System.Drawing.Size(91, 70);
            this.GetIpsbtn.TabIndex = 16;
            this.GetIpsbtn.Text = "Get Polycom\r\n";
            this.GetIpsbtn.UseVisualStyleBackColor = true;
            this.GetIpsbtn.Click += new System.EventHandler(this.GetIpsbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(801, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 257);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // VehicleRegInfo
            // 
            this.VehicleRegInfo.Location = new System.Drawing.Point(591, 525);
            this.VehicleRegInfo.Name = "VehicleRegInfo";
            this.VehicleRegInfo.Size = new System.Drawing.Size(75, 23);
            this.VehicleRegInfo.TabIndex = 18;
            this.VehicleRegInfo.Text = "VehicleRegInfo";
            this.VehicleRegInfo.UseVisualStyleBackColor = true;
            this.VehicleRegInfo.Visible = false;
            this.VehicleRegInfo.Click += new System.EventHandler(this.VehicleRegInfo_Click);
            // 
            // Importbtn
            // 
            this.Importbtn.Location = new System.Drawing.Point(704, 480);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(75, 23);
            this.Importbtn.TabIndex = 19;
            this.Importbtn.Text = "Import";
            this.Importbtn.UseVisualStyleBackColor = true;
            this.Importbtn.Click += new System.EventHandler(this.Importbtn_Click);
            // 
            // Importfilepath
            // 
            this.Importfilepath.Location = new System.Drawing.Point(510, 482);
            this.Importfilepath.Name = "Importfilepath";
            this.Importfilepath.Size = new System.Drawing.Size(188, 20);
            this.Importfilepath.TabIndex = 20;
            // 
            // Importfiledialog
            // 
            this.Importfiledialog.DefaultExt = "pbu";
            this.Importfiledialog.FileName = "Importfiledialog";
            this.Importfiledialog.Filter = "Pbu Files (*.pbu)|*.pbu";
            // 
            // Restorebtn
            // 
            this.Restorebtn.Location = new System.Drawing.Point(510, 525);
            this.Restorebtn.Name = "Restorebtn";
            this.Restorebtn.Size = new System.Drawing.Size(75, 23);
            this.Restorebtn.TabIndex = 21;
            this.Restorebtn.Text = "Restore";
            this.Restorebtn.UseVisualStyleBackColor = true;
            this.Restorebtn.Visible = false;
            this.Restorebtn.Click += new System.EventHandler(this.Restorebtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(899, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "IP Address";
            // 
            // Installservice
            // 
            this.Installservice.Location = new System.Drawing.Point(132, 625);
            this.Installservice.Name = "Installservice";
            this.Installservice.Size = new System.Drawing.Size(89, 41);
            this.Installservice.TabIndex = 22;
            this.Installservice.Text = "Install";
            this.Installservice.UseVisualStyleBackColor = true;
            this.Installservice.Click += new System.EventHandler(this.Installservice_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // servicepath
            // 
            this.servicepath.Location = new System.Drawing.Point(145, 32);
            this.servicepath.Name = "servicepath";
            this.servicepath.Size = new System.Drawing.Size(188, 20);
            this.servicepath.TabIndex = 24;
            // 
            // servicepathlabel
            // 
            this.servicepathlabel.AutoSize = true;
            this.servicepathlabel.Location = new System.Drawing.Point(27, 39);
            this.servicepathlabel.Name = "servicepathlabel";
            this.servicepathlabel.Size = new System.Drawing.Size(68, 13);
            this.servicepathlabel.TabIndex = 8;
            this.servicepathlabel.Text = "Service Path";
            // 
            // installservicedialoga
            // 
            this.installservicedialoga.DefaultExt = "exe";
            this.installservicedialoga.FileName = "Attach Service";
            this.installservicedialoga.Filter = "Exe Files (*.exe)|*.exe";
            // 
            // attachbtn
            // 
            this.attachbtn.Location = new System.Drawing.Point(339, 29);
            this.attachbtn.Name = "attachbtn";
            this.attachbtn.Size = new System.Drawing.Size(81, 23);
            this.attachbtn.TabIndex = 25;
            this.attachbtn.Text = "Attach";
            this.attachbtn.UseVisualStyleBackColor = true;
            this.attachbtn.Click += new System.EventHandler(this.Attachservice_Onclick);
            // 
            // servicelisteneriplablel
            // 
            this.servicelisteneriplablel.AutoSize = true;
            this.servicelisteneriplablel.Location = new System.Drawing.Point(27, 77);
            this.servicelisteneriplablel.Name = "servicelisteneriplablel";
            this.servicelisteneriplablel.Size = new System.Drawing.Size(94, 13);
            this.servicelisteneriplablel.TabIndex = 8;
            this.servicelisteneriplablel.Text = "PolycomListenerIP";
            // 
            // ServiceIp
            // 
            this.ServiceIp.Location = new System.Drawing.Point(145, 70);
            this.ServiceIp.Name = "ServiceIp";
            this.ServiceIp.Size = new System.Drawing.Size(188, 20);
            this.ServiceIp.TabIndex = 26;
            this.ServiceIp.Text = "123";
            // 
            // Servicelabel
            // 
            this.Servicelabel.AutoSize = true;
            this.Servicelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicelabel.Location = new System.Drawing.Point(131, 556);
            this.Servicelabel.Name = "Servicelabel";
            this.Servicelabel.Size = new System.Drawing.Size(84, 25);
            this.Servicelabel.TabIndex = 1;
            this.Servicelabel.Text = "Service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Uninstall";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Uninstall_Onclick);
            // 
            // serviceinstallpanel
            // 
            this.serviceinstallpanel.Controls.Add(this.DoneInstall);
            this.serviceinstallpanel.Controls.Add(this.servicepathlabel);
            this.serviceinstallpanel.Controls.Add(this.servicelisteneriplablel);
            this.serviceinstallpanel.Controls.Add(this.servicepath);
            this.serviceinstallpanel.Controls.Add(this.ServiceIp);
            this.serviceinstallpanel.Controls.Add(this.attachbtn);
            this.serviceinstallpanel.Location = new System.Drawing.Point(364, 586);
            this.serviceinstallpanel.Name = "serviceinstallpanel";
            this.serviceinstallpanel.Size = new System.Drawing.Size(458, 155);
            this.serviceinstallpanel.TabIndex = 28;
            this.serviceinstallpanel.Visible = false;
            // 
            // DoneInstall
            // 
            this.DoneInstall.Location = new System.Drawing.Point(145, 118);
            this.DoneInstall.Name = "DoneInstall";
            this.DoneInstall.Size = new System.Drawing.Size(75, 23);
            this.DoneInstall.TabIndex = 27;
            this.DoneInstall.Text = "Done";
            this.DoneInstall.UseVisualStyleBackColor = true;
            this.DoneInstall.Click += new System.EventHandler(this.ServiceDone_Click);
            // 
            // PolycomSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 753);
            this.Controls.Add(this.serviceinstallpanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Installservice);
            this.Controls.Add(this.Restorebtn);
            this.Controls.Add(this.Importfilepath);
            this.Controls.Add(this.Importbtn);
            this.Controls.Add(this.VehicleRegInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetIpsbtn);
            this.Controls.Add(this.SaveAdminLogin);
            this.Controls.Add(this.confirmuserpass);
            this.Controls.Add(this.newuserpass);
            this.Controls.Add(this.olduserpass);
            this.Controls.Add(this.curruserpass);
            this.Controls.Add(this.currentuserval);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.configbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.callstatechangeurl);
            this.Controls.Add(this.IpofPhone);
            this.Controls.Add(this.Phonebackup);
            this.Controls.Add(this.Passwordval);
            this.Controls.Add(this.Usernameval);
            this.Controls.Add(this.Requester);
            this.Controls.Add(this.PollUrl);
            this.Controls.Add(this.SavePolling);
            this.Controls.Add(this.Servicelabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PolycomSettings";
            this.Text = "Polycom Configuration Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.serviceinstallpanel.ResumeLayout(false);
            this.serviceinstallpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PhoneState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SavePolling;
        private System.Windows.Forms.CheckBox Requester;
        private System.Windows.Forms.CheckBox PollUrl;
        private System.Windows.Forms.TextBox Usernameval;
        private System.Windows.Forms.TextBox Passwordval;
        private System.Windows.Forms.Button Phonebackup;
        private System.Windows.Forms.TextBox IpofPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button configbtn;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TextBox callstatechangeurl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox currentuserval;
        private System.Windows.Forms.TextBox curruserpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox olduserpass;
        private System.Windows.Forms.TextBox newuserpass;
        private System.Windows.Forms.TextBox confirmuserpass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SaveAdminLogin;
        private System.Windows.Forms.Button GetIpsbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button VehicleRegInfo;
        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.TextBox Importfilepath;
        private System.Windows.Forms.OpenFileDialog Importfiledialog;
        private System.Windows.Forms.Button Restorebtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label servicepathlabel;
        private System.Windows.Forms.OpenFileDialog installservicedialoga;
        private System.Windows.Forms.Button attachbtn;
        private System.Windows.Forms.Label servicelisteneriplablel;
        private System.Windows.Forms.Label Servicelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DoneInstall;
        private System.Windows.Forms.Button Installservice;
        protected System.Windows.Forms.Panel serviceinstallpanel;
        protected System.Windows.Forms.TextBox servicepath;
        protected System.Windows.Forms.TextBox ServiceIp;
        //private System.Windows.Forms.Button ServiceAttach;
    }
}

