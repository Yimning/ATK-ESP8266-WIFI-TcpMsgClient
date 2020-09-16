using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpMsgClient
{
    public partial class Form_Platform : Form
    {
        public Form_Platform()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }


        private void Form_Platform_Load(object sender, EventArgs e)
        {
            this.btnCloseConn.Enabled = false;
            this.btnListenServer.Enabled = false;
        }
        //创建 1个客户端套接字 和1个负责监听服务端请求的线程  
        Socket socketClient = null;
        Thread threadClient = null;

        /// <summary>
        /// 连接服务端事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListenServer_Click(object sender, EventArgs e)
        {
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //需要获取文本框中的IP地址
            IPAddress ipaddress = IPAddress.Parse(this.txtDSN.Text.Trim());  //用网关地址
            //将获取的ip地址和端口号绑定到网络节点endpoint上
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(this.comboBoxPort.Text.Trim()));
            //这里客户端套接字连接到网络节点(服务端)用的方法是Connect 而不是Bind
            try
            {
                socketClient.Connect(endpoint);
                this.txtMsg.AppendText("客户端连接服务端成功！" + "\r\n");
                this.btnListenServer.Enabled = false;
                this.btnCloseConn.Enabled = true;
                this.btnGetIP.Enabled = false;
                //创建一个线程 用于监听服务端发来的消息
                threadClient = new Thread(RecMsg);
                //将窗体线程设置为与后台同步
                threadClient.IsBackground = true;
                //启动线程
                threadClient.Start();
            }
            catch (Exception ex)
            {
                this.txtMsg.AppendText("远程服务端断开，连接失败！" + "\r\n");
            }
        }

        /// <summary>
        /// 接收服务端发来信息的方法
        /// </summary>
        private void RecMsg()
        {
            while (true) //持续监听服务端发来的消息
            {
                try
                {
                    //定义一个1M的内存缓冲区 用于临时性存储接收到的信息
                    byte[] arrRecMsg = new byte[1024 * 1024];
                    //将客户端套接字接收到的数据存入内存缓冲区, 并获取其长度
                    int length = socketClient.Receive(arrRecMsg);
                    //将套接字获取到的字节数组转换为人可以看懂的字符串
                    string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                    //将发送的信息追加到聊天内容文本框中
                    txtMsg.AppendText("服务端 " + GetCurrentTime() + "\r\n\r\n" + strRecMsg + "\r\n");
                    txtTemp.Text = strRecMsg.Substring(0, 2);
                    txtHum.Text = strRecMsg.Substring(2, 2);
                    txtSmog.Text = strRecMsg.Substring(4, 4);
                    txtRelay.Text = strRecMsg.Substring(8, 3);
                    txtBeep.Text = strRecMsg.Substring(11, 3);
                    if (int.Parse(txtTemp.Text) >= int.Parse(comboBoxTemp.Text))
                    {
                        txtTemp.ForeColor = Color.Red;
                        TimingMessageBox messageBox = new TimingMessageBox("超标温度：" + int.Parse(txtTemp.Text) + "℃," + "蜂鸣器响", 1);
                        messageBox.ShowDialog();
                    }

                    if (int.Parse(txtHum.Text) >= int.Parse(comboBoxHum.Text))
                    {
                        txtHum.ForeColor = Color.Red;
                        TimingMessageBox messageBox = new TimingMessageBox("超标湿度：" + int.Parse(txtHum.Text) + "%," + "继电器开", 1);
                        messageBox.ShowDialog();
                    }

                    if (int.Parse(txtSmog.Text) >= int.Parse(comboBoxSmog.Text))
                    {
                        txtSmog.ForeColor = Color.Red;
                        TimingMessageBox messageBox = new TimingMessageBox("超标气体浓度：" + int.Parse(txtSmog.Text) + "ppm," + "蜂鸣器响", 1);
                        messageBox.ShowDialog();
                    }
                    writeDataSource();  //写入数据库

                }
                catch (Exception ex)
                {
                    this.txtMsg.AppendText("远程服务器已中断连接！" + "\r\n");
                    this.btnListenServer.Enabled = true;
                    break;
                }
            }
        }


        public void writeDataSource()
        {
            try
            {
                string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=WiFiFireMoistureProofMonitoringAlarmSystem";
                SqlConnection myconn = new SqlConnection(strCon);
                DataSet myDataSet = new DataSet();
                string strcom = "Select *from recordTable";
                string str = "insert into recordTable(temperatureValue,humidValue,smog,relayState,beepState,timestamp) VALUES ('" + txtTemp.Text.Trim()+"℃" + "','" + txtHum.Text.Trim()+"%" + "','" + txtSmog.Text.Trim()+"ppm" + "','" + txtRelay.Text.Trim() + "','" + txtBeep.Text.Trim() + "','" + System.DateTime.Now + "')";
                myconn.Open();
                SqlCommand xg;
                xg = new SqlCommand(str, myconn);

                if (xg.ExecuteNonQuery() > 0)//判断插入数据是否成功        
                {                   //执行要操作的语句           
                    SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
                    myDataSet.Clear();
                    mycommand.Fill(myDataSet, "recordTable");
                    //adminMain.dataGridView1.DataSource = myDataSet.Tables["systemStudent"];
                    //   MessageBox.Show("添加成功", "提示");
                }
                myconn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("error!" + x.ToString());
            }


        }















        /// <summary>
        /// 发送字符串信息到服务端的方法
        /// </summary>
        /// <param name="sendMsg">发送的字符串信息</param>
        private void ClientSendMsg(string sendMsg)
        {
            try
            {
                //将输入的内容字符串转换为机器可以识别的字节数组
                byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                //调用客户端套接字发送字节数组
                socketClient.Send(arrClientSendMsg);
                //将发送的信息追加到聊天内容文本框中
                txtMsg.AppendText("客户端 " + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");
            }
            catch (Exception ex)
            {
                this.txtMsg.AppendText("远程服务器已中断连接,无法发送消息！" + "\r\n");
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            //调用ClientSendMsg方法 将文本框中输入的信息发送给服务端
            ClientSendMsg(this.txtClientSendMsg.Text.Trim());
            this.txtClientSendMsg.Clear();
        }

        private void txtClientSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            //当光标位于文本框时 如果用户按下了键盘上的Enter键 
            if (e.KeyCode == Keys.Enter)
            {
                //则调用客户端向服务端发送信息的方法
                ClientSendMsg(this.txtClientSendMsg.Text.Trim());
                this.txtClientSendMsg.Clear();
            }
        }

        /// <summary>
        /// 获取当前系统时间的方法
        /// </summary>
        /// <returns>当前时间</returns>
        private DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            btnListenServer.Enabled = true;
            btnGetIP.Enabled = true;
            if (socketClient == null)
                return;

            if (!socketClient.Connected)
                return;
            try
            {
                socketClient.Shutdown(SocketShutdown.Both); //关闭Socket
            }
            catch (Exception x)
            {
            }

            try
            {
                socketClient.Close();
            }
            catch(Exception x)
            {
            }

        }
        /// <summary>
        /// Close the socket safely.
        /// </summary>



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Main a = new Form_Main();
            a.ShowDialog();
            if (socketClient == null)
                return;
            if (!socketClient.Connected)
                return;
            try
            {
                socketClient.Shutdown(SocketShutdown.Both); //关闭Socket
            }
            catch (Exception x)
            {
            }

            try
            {
                socketClient.Close();
            }
            catch (Exception x)
            {
            }

        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            //接收IPv4的地址
            //string ip = "192.168.1.103";
            IPAddress localIP = GetLocalIPv4Address();
            //赋值给文本框
            this.txtIP.Text = localIP.ToString();
            this.txtDSN.Text = GetGateway();
            MessageBox.Show("获取成功！","提示");
            this.btnListenServer.Enabled = true;
            this.btnGetIP.Enabled = false;
        }

        /// <summary>
        /// 获取本地IPv4地址
        /// </summary>
        /// <returns></returns>
        public IPAddress GetLocalIPv4Address()
        {
            IPAddress localIpv4 = null;

            //获取本机所有的IP地址列表
            IPAddress[] IpList = Dns.GetHostAddresses(Dns.GetHostName());
            //循环遍历所有IP地址
            foreach (IPAddress IP in IpList)
            {
                //判断是否是IPv4地址
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIpv4 = IP;
                }
                else
                {
                    continue;
                }

            }
            return localIpv4;
        }
        private string GetGateway()
        {
            string strGateway = "";
            //获取所有网卡
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            //遍历数组
            foreach (var netWork in nics)
            {
                //单个网卡的IP对象
                IPInterfaceProperties ip = netWork.GetIPProperties();
                //获取该IP对象的网关
                GatewayIPAddressInformationCollection gateways = ip.GatewayAddresses;
                foreach (var gateWay in gateways)
                {
                        //得到网关地址
                        strGateway = gateWay.Address.ToString();
                        //跳出循环
                }
                //如果已经得到网关地址
                if (strGateway.Length > 0)
                {
                    break;
                }
            }
            return strGateway;
        }
 

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Form_QueryRecord a = new Form_QueryRecord();
            a.ShowDialog();
        }

        private void btnLEDOn_Click(object sender, EventArgs e)
        {
            ClientSendMsg("a");
        }

        private void btnLEDOff_Click(object sender, EventArgs e)
        {
            ClientSendMsg("aa");
        }

        private void txtSmog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
