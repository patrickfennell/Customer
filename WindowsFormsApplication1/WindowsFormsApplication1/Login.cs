using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = user_txt.Text;
            string password = pass_txt.Text;
           
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btn_login, "Press to Login.");

            if (user.Equals("user1") & password.Equals("pass1"))
            {
                 lbl_message.Text = "Welcome to the system ";
                 Home_form Home = new Home_form();
                 Home.Show();
                 this.Dispose();
            }
            else
            {
                lbl_message.Text = "invalid username and password combination ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            user_txt.Text = "";
            pass_txt.Text = "";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Home_form home = new Home_form();
            home.Show();
            this.Hide();
        }
    }
}
