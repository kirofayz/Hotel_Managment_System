using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserName_txt_Click(object sender, EventArgs e)
        {
            UserName_txt.Text = "";
        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_txt_Click(object sender, EventArgs e)
        {
            Password_txt.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Login_btn.ForeColor = Color.Black;
        }

        private void Login_btn_MouseLeave(object sender, EventArgs e)
        {
            Login_btn.ForeColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string UserName = UserName_txt.Text;
            string Password = Password_txt.Text;
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Query = from u in context.Users
                        select u;
            foreach (var user in Query)
            {
                if(user.UserName == UserName && user.Password == Password)
                {
                    Home H = new Home();
                   // this.Hide();
                    H.Name = UserName;
                    Program.Username = UserName;
                    H.Show();
                    break;
                }
                else if(user.UserName != UserName && user.Password != Password)
                {
                    Passwrong_pnl.Visible = true;
                   
                }

            }
            

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
