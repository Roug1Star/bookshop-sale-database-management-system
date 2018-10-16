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
    public partial class 图书销售情况 : Form
    {
        public 图书销售情况()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Server=DESKTOP-JPF4D37; DataBase=书店销售系统第六组; User id=sa; PWD=849755514";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select * from 图书销售表";
            SqlDataAdapter Da = new SqlDataAdapter(sql, conn);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "图书销售表");
            dataGridView1.DataSource = Ds.Tables["图书销售表"];
            conn.Close();
        }
    }
}
