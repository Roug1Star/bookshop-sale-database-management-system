﻿using System;
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
    public partial class 图书入库 : Form
    {
        public 图书入库()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("INSERT INTO dbo.图书入库表( 入库图书编号,入库数量,入库价格 )VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' )", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("书本入库成功!");
            }
            else
            {
                MessageBox.Show("请输入入库数量！");
            }
        }

        private void 图书入库_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“书店销售系统第六组DataSet2.图书入库表”中。您可以根据需要移动或删除它。
            this.图书入库表TableAdapter.Fill(this.书店销售系统第六组DataSet2.图书入库表);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 图书入库表";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "图书入库表");
            dataGridView2.DataSource = Ds.Tables["图书入库表"];
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 书籍信息表 where 书号='" + Convert.ToInt32(this.textBox1.Text) + "'";
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
            string sql = "Select * from 书籍信息表 where 类别='" + Convert.ToInt32(this.textBox1.Text) + "'";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "书籍信息表");
            dataGridView1.DataSource = Ds.Tables["书籍信息表"];
            conn.Close();
        }
    }
}
