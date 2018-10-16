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
    public partial class 用户操作界面 : Form
    {
        public 用户操作界面()
        {
            InitializeComponent();
        }

        private void 用户操作界面_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“书店销售系统第六组DataSet.图书分类表”中。您可以根据需要移动或删除它。
            this.图书分类表TableAdapter.Fill(this.书店销售系统第六组DataSet.图书分类表);
            // TODO: 这行代码将数据加载到表“书店销售系统第六组DataSet.书籍信息表”中。您可以根据需要移动或删除它。
            this.书籍信息表TableAdapter.Fill(this.书店销售系统第六组DataSet.书籍信息表);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 购买图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            购买图书 load = new 购买图书();
            load.Show();
        }

        private void 书库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             SqlConnection sqlCon = new SqlConnection();
             sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
             sqlCon.Open();
             SqlDataAdapter sda = new SqlDataAdapter("select * from 书籍信息表", sqlCon);
             DataSet ds = new DataSet();
             sda.Fill(ds);
             dataGridView1.DataSource = ds;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 书籍信息表 where 书号='" + Convert.ToInt32(this.SearchTJ.Text) + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "书籍信息表");
            dataGridView1.DataSource = Ds.Tables["书籍信息表"];
            conn.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 书籍信息表 where 类别='" + Convert.ToInt32(this.SearchTJ.Text) + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "书籍信息表");
            dataGridView1.DataSource = Ds.Tables["书籍信息表"];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 书籍信息表";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "书籍信息表");
            dataGridView1.DataSource = Ds.Tables["书籍信息表"];
            conn.Close();
        }

        private void 查询订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客户查询订单 load = new 客户查询订单();
            load.Show();
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客户修改个人信息 load = new 客户修改个人信息();
            load.Show();
        }
    }
}

