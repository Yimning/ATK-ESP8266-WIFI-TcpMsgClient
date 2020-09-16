namespace TcpMsgClient
{
    partial class Form_Main
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
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Image = global::TcpMsgClient.Properties.Resources.wzlogo;
            this.button4.Location = new System.Drawing.Point(239, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 134);
            this.button4.TabIndex = 56;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(54, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "基于ESP8266WiFi的仓库防火防潮监测报警应用系统";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancel.Location = new System.Drawing.Point(323, 340);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 36);
            this.button_cancel.TabIndex = 64;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.Location = new System.Drawing.Point(190, 340);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 36);
            this.button_login.TabIndex = 63;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_admin.Location = new System.Drawing.Point(323, 295);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(74, 20);
            this.radioButton_admin.TabIndex = 62;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_user.Location = new System.Drawing.Point(207, 295);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(58, 20);
            this.radioButton_user.TabIndex = 61;
            this.radioButton_user.Text = "用户";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(257, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '.';
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(257, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(187, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "账  号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(187, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "密  码:";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 422);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Main";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}