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
    public partial class 图书分类 : Form
    {
        public 图书分类()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 图书分类表";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "图书分类表");
            dataGridView1.DataSource = Ds.Tables["图书分类表"];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("INSERT INTO dbo.图书分类表( 类别名 )VALUES('" + textBox2.Text + "')", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("添加书籍类别成功!");
            }
            else
            {
                MessageBox.Show("请输入完整的书籍类别信息！!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("DELETE FROM dbo.图书分类表 WHERE 类别编号='" + Convert.ToInt32(this.textBox1.Text) + "'", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("删除书籍类别成功!");
            }
            else
            {
                MessageBox.Show("请输入需要删除书籍的类别编号信息！!");
            }
        }
    }
}
