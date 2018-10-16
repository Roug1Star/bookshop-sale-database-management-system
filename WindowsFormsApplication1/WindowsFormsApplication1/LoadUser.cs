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
    public partial class LoadUser : Form
    {
        public string Ref;
        private bool Islogo = false;
        public LoadUser()
        {
            InitializeComponent();
        }

        private void ExitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //用户登录
        private void UserLogin_Click(object sender, EventArgs e)
        {
            if (useridname.Text != "" && userpassword.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT * FROM dbo.用户信息表 WHERE 用户ID = '" + useridname.Text + "' AND 用户密码 ='" + userpassword.Text + "'";
                    SqlCommand com = new SqlCommand(sql, sqlCon);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dat = new DataTable();
                    da.Fill(dat);
                    if (dat.Rows.Count > 0)
                    {
                        Islogo = true;
                        this.Close();
                        sqlCon.Close();
                        用户操作界面 load = new 用户操作界面();
                        load.Show();
                        this.Hide();
                    }
                    else
                    {
                        label4.Text = "提示:登陆失败,用户名或密码错误";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("提示：请输入正确的信息！");
            }
        }
        //管理员登录
        private void AdminLogin_Click(object sender, EventArgs e)
        {
            if (useridname.Text != "" && userpassword.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT * FROM dbo.管理员信息表 WHERE 管理员帐号 = '" + useridname.Text + "' AND 管理员密码 ='" + userpassword.Text + "'";
                    SqlCommand com = new SqlCommand(sql, sqlCon);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dat = new DataTable();
                    da.Fill(dat);
                    if (dat.Rows.Count > 0)
                    {
                        Islogo = true;
                        this.Close();
                        sqlCon.Close();
                        管理员操作界面 load = new 管理员操作界面();
                        load.ShowDialog();
                    }
                    else
                    {
                        label4.Text = "提示:登陆失败,管理员账号或密码错误";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("提示：请输入正确的信息！");
            }
        }

        private void LoadUser_Load(object sender, EventArgs e)
        {

        }
    }
}
