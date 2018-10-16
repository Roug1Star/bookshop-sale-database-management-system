using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)//点击登录弹出登录界面
        {
            LoadUser load = new LoadUser();
            load.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)//点击注册弹出登录界面
        {
            NewUser load = new NewUser();
            load.ShowDialog();
        }

        private void 菜单_Click(object sender, EventArgs e)
        {

        }
    }
}
