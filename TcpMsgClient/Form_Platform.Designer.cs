namespace TcpMsgClient
{
    partial class Form_Platform
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientSendMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnListenServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBeep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRelay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSmog = new System.Windows.Forms.TextBox();
            this.txtHum = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.txtDSN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxHum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSmog = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLEDOn = new System.Windows.Forms.Button();
            this.btnLEDOff = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(259, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 33);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "清空数据";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseConn.Location = new System.Drawing.Point(32, 192);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(88, 33);
            this.btnCloseConn.TabIndex = 45;
            this.btnCloseConn.Text = "断开连接";
            this.btnCloseConn.UseVisualStyleBackColor = true;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(141, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 33);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "软件退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendMsg.Location = new System.Drawing.Point(608, 189);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(88, 33);
            this.btnSendMsg.TabIndex = 44;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(360, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "下发:";
            // 
            // txtClientSendMsg
            // 
            this.txtClientSendMsg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClientSendMsg.Location = new System.Drawing.Point(404, 194);
            this.txtClientSendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientSendMsg.Name = "txtClientSendMsg";
            this.txtClientSendMsg.Size = new System.Drawing.Size(194, 23);
            this.txtClientSendMsg.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(344, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "接收区:";
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(405, 12);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(291, 173);
            this.txtMsg.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "本地端口:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(101, 47);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(156, 23);
            this.txtIP.TabIndex = 37;
            // 
            // btnListenServer
            // 
            this.btnListenServer.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnListenServer.Location = new System.Drawing.Point(141, 130);
            this.btnListenServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnListenServer.Name = "btnListenServer";
            this.btnListenServer.Size = new System.Drawing.Size(88, 33);
            this.btnListenServer.TabIndex = 36;
            this.btnListenServer.Text = "连接服务端";
            this.btnListenServer.UseVisualStyleBackColor = true;
            this.btnListenServer.Click += new System.EventHandler(this.btnListenServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "IP地址:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBeep);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtRelay);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSmog);
            this.groupBox1.Controls.Add(this.txtHum);
            this.groupBox1.Controls.Add(this.txtTemp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(28, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 96);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实时数据";
            // 
            // txtBeep
            // 
            this.txtBeep.Location = new System.Drawing.Point(396, 58);
            this.txtBeep.Name = "txtBeep";
            this.txtBeep.ReadOnly = true;
            this.txtBeep.Size = new System.Drawing.Size(77, 23);
            this.txtBeep.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "蜂鸣器状态(ON/OFF):";
            // 
            // txtRelay
            // 
            this.txtRelay.Location = new System.Drawing.Point(146, 58);
            this.txtRelay.Name = "txtRelay";
            this.txtRelay.ReadOnly = true;
            this.txtRelay.Size = new System.Drawing.Size(77, 23);
            this.txtRelay.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "继电器状态(ON/OFF):";
            // 
            // txtSmog
            // 
            this.txtSmog.Location = new System.Drawing.Point(423, 20);
            this.txtSmog.Name = "txtSmog";
            this.txtSmog.ReadOnly = true;
            this.txtSmog.Size = new System.Drawing.Size(77, 23);
            this.txtSmog.TabIndex = 1;
            this.txtSmog.TextChanged += new System.EventHandler(this.txtSmog_TextChanged);
            // 
            // txtHum
            // 
            this.txtHum.Location = new System.Drawing.Point(228, 20);
            this.txtHum.Name = "txtHum";
            this.txtHum.ReadOnly = true;
            this.txtHum.Size = new System.Drawing.Size(77, 23);
            this.txtHum.TabIndex = 1;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(73, 20);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(61, 23);
            this.txtTemp.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "烟雾浓度(ppm):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "湿度(%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "温度(℃):";
            // 
            // btnGetIP
            // 
            this.btnGetIP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetIP.Location = new System.Drawing.Point(32, 129);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(88, 33);
            this.btnGetIP.TabIndex = 49;
            this.btnGetIP.Text = "获取本地IP";
            this.btnGetIP.UseVisualStyleBackColor = true;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(259, 192);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(88, 33);
            this.btnQuery.TabIndex = 50;
            this.btnQuery.Text = "查看数据库";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "6534",
            "8080",
            "8086"});
            this.comboBoxPort.Location = new System.Drawing.Point(101, 84);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(156, 22);
            this.comboBoxPort.TabIndex = 51;
            this.comboBoxPort.Text = "8086";
            // 
            // txtDSN
            // 
            this.txtDSN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDSN.Location = new System.Drawing.Point(101, 12);
            this.txtDSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtDSN.Name = "txtDSN";
            this.txtDSN.Size = new System.Drawing.Size(156, 23);
            this.txtDSN.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(33, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = "DNS地址:";
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Items.AddRange(new object[] {
            "25",
            "30",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "45"});
            this.comboBoxTemp.Location = new System.Drawing.Point(126, 247);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(50, 22);
            this.comboBoxTemp.TabIndex = 55;
            this.comboBoxTemp.Text = "35";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(28, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 54;
            this.label9.Text = "温度阈值(℃):";
            // 
            // comboBoxHum
            // 
            this.comboBoxHum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxHum.FormattingEnabled = true;
            this.comboBoxHum.Items.AddRange(new object[] {
            "75",
            "80",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.comboBoxHum.Location = new System.Drawing.Point(282, 247);
            this.comboBoxHum.Name = "comboBoxHum";
            this.comboBoxHum.Size = new System.Drawing.Size(50, 22);
            this.comboBoxHum.TabIndex = 57;
            this.comboBoxHum.Text = "95";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(190, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 14);
            this.label10.TabIndex = 56;
            this.label10.Text = "湿度阈值(%):";
            // 
            // comboBoxSmog
            // 
            this.comboBoxSmog.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSmog.FormattingEnabled = true;
            this.comboBoxSmog.Items.AddRange(new object[] {
            "200",
            "300",
            "350",
            "450",
            "550",
            "650",
            "750",
            "850",
            "950",
            "1000"});
            this.comboBoxSmog.Location = new System.Drawing.Point(476, 248);
            this.comboBoxSmog.Name = "comboBoxSmog";
            this.comboBoxSmog.Size = new System.Drawing.Size(50, 22);
            this.comboBoxSmog.TabIndex = 59;
            this.comboBoxSmog.Text = "460";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(346, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 14);
            this.label13.TabIndex = 58;
            this.label13.Text = "烟雾浓度阈值(ppm):";
            // 
            // btnLEDOn
            // 
            this.btnLEDOn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLEDOn.Location = new System.Drawing.Point(37, 27);
            this.btnLEDOn.Name = "btnLEDOn";
            this.btnLEDOn.Size = new System.Drawing.Size(88, 33);
            this.btnLEDOn.TabIndex = 60;
            this.btnLEDOn.Text = "LED开";
            this.btnLEDOn.UseVisualStyleBackColor = true;
            this.btnLEDOn.Click += new System.EventHandler(this.btnLEDOn_Click);
            // 
            // btnLEDOff
            // 
            this.btnLEDOff.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLEDOff.Location = new System.Drawing.Point(37, 72);
            this.btnLEDOff.Name = "btnLEDOff";
            this.btnLEDOff.Size = new System.Drawing.Size(88, 33);
            this.btnLEDOff.TabIndex = 61;
            this.btnLEDOff.Text = "LED关";
            this.btnLEDOff.UseVisualStyleBackColor = true;
            this.btnLEDOff.Click += new System.EventHandler(this.btnLEDOff_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLEDOff);
            this.groupBox2.Controls.Add(this.btnLEDOn);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(542, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 123);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下发控制";
            // 
            // Form_Platform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxSmog);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxHum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTemp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnGetIP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCloseConn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientSendMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnListenServer);
            this.Controls.Add(this.label1);
            this.Name = "Form_Platform";
            this.Text = "TcpClient";
            this.Load += new System.EventHandler(this.Form_Platform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCloseConn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientSendMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnListenServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBeep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRelay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSmog;
        private System.Windows.Forms.TextBox txtHum;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.TextBox txtDSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxHum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSmog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLEDOn;
        private System.Windows.Forms.Button btnLEDOff;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}