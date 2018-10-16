using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class 购买图书 : Form
    {
        public 购买图书()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定购买吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("INSERT INTO dbo.图书订单表( 订单用户号,订单书号,订单数量 )VALUES( '" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("添加订单成功!");
            }
            else
            {
                MessageBox.Show("请输入需要购买的书号以及数量！!");
            }
        }
    }
}
