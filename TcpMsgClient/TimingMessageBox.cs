using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpMsgClient
{
    public partial class TimingMessageBox : Form
    {
        public TimingMessageBox()
        {
            InitializeComponent();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\DiamondBlue.ssk";  //选择皮肤文件
            skinEngine1.DisableTag = 9999;      //设置不需要被渲染的控件Tag值为9999
                                                //this.BackgroundImage = Image.FromFile(@"C:\E盘(文件)\MyC\StudentInformationSystem\StudentInformationSystem\Resources\1.jpg");
                                                // BackgroundImage = this.imageList1.Images[0];

        }

        private void TimingMessageBox_Load(object sender, EventArgs e)
        {

        }
        private int second;

        private int counter;
        public TimingMessageBox(string message, int second)
        {
            InitializeComponent();
            this.labelMessage.Text = message;
            this.second = second;
            this.counter = 0;
            this.buttonOK.Text = string.Format("确定({0})", this.second - this.counter);

            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.counter <= this.second)
            {
                this.buttonOK.Text = string.Format("确定({0})", this.second - this.counter);
                this.Refresh();
                this.counter++;
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                this.Close();
            }
        }

    }
}
