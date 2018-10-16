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
    public partial class 管理员信息 : Form
    {
        public 管理员信息()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 管理员信息表";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "管理员信息表");
            dataGridView1.DataSource = Ds.Tables["管理员信息表"];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定添加该管理员吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("INSERT INTO dbo.管理员信息表( 管理员帐号,管理员密码 )VALUES( '" + textBox2.Text + "','" + textBox3.Text + "')", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("添加管理员成功!");
            }
            else
            {
                MessageBox.Show("请输入完整的管理员信息！!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定修改该管理员昵称或密吗？（账号不可更改）", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0) && (textBox3.TextLength > 0))
                {
                    string instex = "update 管理员信息表 SET 管理员帐号='" + textBox2.Text + "',管理员密码='" + textBox3.Text + "' WHERE 管理员ID='" + Convert.ToInt32(this.textBox1.Text) + "'";
                    SqlCommand cmd = new SqlCommand(instex, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("修改成功");
                }
                else
                    MessageBox.Show("修改失败，请重新输入！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该管理员吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("DELETE FROM dbo.管理员信息表 WHERE 管理员ID='" + Convert.ToInt32(this.textBox1.Text) + "'", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("删除管理员成功!");
            }
            else
            {
                MessageBox.Show("请输入需要删除的管理员ID！!");
            }
        }
    }
}
