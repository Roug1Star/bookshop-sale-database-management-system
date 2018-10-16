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
    public partial class 客户修改个人信息 : Form
    {
        public 客户修改个人信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定修改个人信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0) && (textBox3.TextLength > 0) && (textBox4.TextLength > 0) && (textBox5.TextLength > 0) && (textBox6.TextLength > 0) && (textBox7.TextLength > 0))
                {
                    string instex = "update 用户信息表 SET 用户名='" + textBox2.Text + "',用户密码='" + textBox3.Text + "',性别='" + textBox4.Text + "',电话='" + textBox5.Text + "',身份证号='" + textBox6.Text + "',收货地址='" + textBox7.Text + "' WHERE 用户ID='" + this.textBox1.Text + "' AND 用户名='" + this.textBox8.Text + "'";
                    SqlCommand cmd = new SqlCommand(instex, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("修改个人信息成功");
                }
                else
                    MessageBox.Show("修改个人信息失败，请重新输入！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 用户信息表 where 用户ID='" +this.textBox1.Text+ "'";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "书籍信息表");
            dataGridView1.DataSource = Ds.Tables["书籍信息表"];
            conn.Close();
        }
    }
}
