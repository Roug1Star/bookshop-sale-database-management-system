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
    public partial class 管理员操作界面 : Form
    {
        DataTable DT;
        SqlDataAdapter SDA;
        public 管理员操作界面()
        {
            InitializeComponent();
        }

        private void 管理员操作界面_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“书店销售系统第六组DataSet.图书分类表”中。您可以根据需要移动或删除它。
            this.图书分类表TableAdapter.Fill(this.书店销售系统第六组DataSet.图书分类表);
            // TODO: 这行代码将数据加载到表“书店销售系统第六组DataSet1.图书入库信息登记表”中。您可以根据需要移动或删除它。
            this.图书入库信息登记表TableAdapter.Fill(this.书店销售系统第六组DataSet1.图书入库信息登记表);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定修改本条数据记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if ((textBox1.TextLength > 0) && (textBox2.TextLength > 0) && (textBox3.TextLength > 0) && (textBox4.TextLength > 0)&&(textBox5.TextLength > 0) && (textBox6.TextLength > 0) && (textBox7.TextLength > 0))
                {
                    string instex = "update 图书入库信息登记表 SET 入库书名='" + textBox3.Text + "',入库书作者='" + textBox4.Text + "',入库书类='" + textBox5.Text + "',入库书出版社='" + textBox6.Text + "',销售价格='" + textBox7.Text + "' WHERE 入库编号='" + Convert.ToInt32(this.textBox1.Text) + "'";
                    SqlCommand cmd = new SqlCommand(instex, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("修改成功");
                }
                else
                    MessageBox.Show("修改失败，请重新输入！");
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" )
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("INSERT INTO dbo.图书入库信息登记表( 入库书号,入库书名,入库书作者,入库书类,入库书出版社,销售价格 )VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("添加书籍信息成功!");
            }
            else
            {
                MessageBox.Show("请输入完整的书籍信息！!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                sqlCon.Open();
                SqlCommand com = new SqlCommand("DELETE FROM dbo.图书入库信息登记表 WHERE 入库编号='" + Convert.ToInt32(this.textBox2.Text) + "'", sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("删除书籍信息成功!");
            }
            else
            {
                MessageBox.Show("请输入需要删除书籍的入库编号信息！!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 图书入库信息登记表";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "图书入库信息登记表");
            dataGridView1.DataSource = Ds.Tables["图书入库信息登记表"];
            conn.Close();
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理员信息 load = new 管理员信息();
            load.ShowDialog();
        }

        private void 图书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书入库 load = new 图书入库();
            load.ShowDialog();
        }

        private void 图书分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书分类 load = new 图书分类();
            load.ShowDialog();
        }

        private void 图书订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 图书销售情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书销售情况 load = new 图书销售情况();
            load.ShowDialog();
        }
    }
}


