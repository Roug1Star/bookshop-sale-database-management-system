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
    public partial class 客户查询订单 : Form
    {
        public 客户查询订单()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 图书销售表 where 销售订单用户号='" + textBox1.Text + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "图书销售表");
            dataGridView1.DataSource = Ds.Tables["图书销售表"];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定修改数量吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0) && (textBox3.TextLength > 0))
                {
                    string instex = "update 图书订单表 SET 订单数量='" + textBox3.Text + "' WHERE 订单编号='" +this.textBox2.Text+ "'";
                    SqlCommand cmd = new SqlCommand(instex, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("修改订单成功");
                }
                else
                    MessageBox.Show("修改订单失败，请重新输入！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定停止订单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand dele = new SqlCommand("DELETE FROM dbo.图书销售表 WHERE 销售订单编号='" + this.textBox2.Text + "'", sqlCon);
                dele.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("停止订单成功!");
            }
            else
            {
                MessageBox.Show("请输入需要停止的订单单号！!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定取消订单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand dele = new SqlCommand("DELETE FROM dbo.图书订单表 WHERE 订单编号='" + this.textBox2.Text + "'", sqlCon);
                dele.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("取消订单成功!");
            }
            else
            {
                MessageBox.Show("请输入需要取消的订单单号！!");
            }
        }
    }
}
