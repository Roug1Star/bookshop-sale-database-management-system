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
    public partial class NewUser : Form
    {
        private bool Test = false;
        public NewUser()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //点击注册按钮后进行注册
        private void UserRegi_Click(object sender, EventArgs e)
        {
            if (UserID.Text != "" && UserName.Text != "" && UserPassword.Text != "" && UserPhoneNumber.Text != "" && Useriden.Text != "" && UserAddress.Text != "")
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = "Data Source=DESKTOP-JPF4D37;Initial Catalog=书店销售系统第六组;User ID=sa;Password=849755514";
                try
                {
                    sqlCon.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO dbo.用户信息表( 用户ID,用户名,用户密码,电话,收货地址,身份证号 )VALUES( '" + UserID.Text + "','" + UserName.Text + "','" + UserPassword.Text + "','" + UserPhoneNumber.Text + "','" + Useriden.Text + "','" + UserAddress.Text + "')", sqlCon);
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("恭喜您！注册成功!");
                    this.Close();
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("请输入完整的信息！!");
            }

        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
