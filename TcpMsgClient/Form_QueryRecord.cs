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
    public partial class Form_QueryRecord : Form
    {
        public Form_QueryRecord()
        {
            InitializeComponent();
        }
        DataSet myDataSet = new DataSet();
        public void query()
        {
            string strCon = "server=127.0.0.1;uid=sa;pwd=123456;database=WiFiFireMoistureProofMonitoringAlarmSystem";
            SqlConnection myconn = new SqlConnection(strCon);

            string strcom = "Select *from recordTable";
            myconn.Open();
            SqlDataAdapter mycommand = new SqlDataAdapter(strcom, myconn);
            mycommand.Fill(myDataSet, "recordTable");
            myconn.Close();
            this.dataGridView1.DataSource = myDataSet.Tables["recordTable"];

        }
        private void Form_QueryRecord_Load(object sender, EventArgs e)
        {
            query();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form_Platform a = new Form_Platform();
            //a.Show();
        }

        private void toolStripButton_Fresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            query();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
