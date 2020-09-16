using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpMsgClient
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\DiamondBlue.ssk";  //选择皮肤文件
            skinEngine1.DisableTag = 9999;      //设置不需要被渲染的控件Tag值为9999
                                                //this.BackgroundImage = Image.FromFile(@"C:\E盘(文件)\MyC\StudentInformationSystem\StudentInformationSystem\Resources\1.jpg");
                                                // BackgroundImage = this.imageList1.Images[0];
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
        int flag;
        public static string str;//public类型的实例字段,static变量被所有对象所共有，也可以被所有对象所改变
        public static string str1;  //用户保存密码
        private void Form_main_Load(object sender, EventArgs e)
        {

        }
        private bool judge()

        {
            //用if来判断框的内容

            if (textBox1.Text == "")

                return false;

            if (textBox2.Text == "")

                return false;

            return true;

        }
        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }
        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (!judge())
            {

                MessageBox.Show("账号或密码为空,请正确输入信息", "提示");

                return;

            }

            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=FireMoistureProofMonitoringAlarmSystem";
                SqlConnection connection = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();

                if (flag == 2) //radioButton1_stu  判断是否为学生用户
                {
                    string sql = "Select *from adminInfo where adminID ='" + textBox1.Text.Trim() +
                        "' and adminPassword='" + this.textBox2.Text.Trim() + "'";
                    connection.Open();
                    SqlDataAdapter mycommand = new SqlDataAdapter(sql, connection);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "adminInfo");
                    connection.Close();

                    if (myDataSet.Tables["adminInfo"].Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！", "提示");
                        this.Visible = false;
                        Form_Platform a = new Form_Platform();
                        str = textBox1.Text;//注意，这句不能放在stu.Show();的后面，否则将传值不到其他窗体；会先执行textBox2.Text =stu.str;再执行str = textBox1.Text;
                        str1 = textBox2.Text;//保存密码
                        a.Show();
                    }
                    else
                        MessageBox.Show("用户名或密码错误！", "提示");
                }
                else if (flag == 1)
                {
                    MessageBox.Show("当前用户暂未开放！", "提示");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
