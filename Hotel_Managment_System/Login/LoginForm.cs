using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var user = context.Users.Select(u => u.UserName);
            foreach (var item in user)
            {
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PicBoxShow_Click(object sender, EventArgs e)
        {
            PicBoxShow.Hide();
            txtBoxPass.UseSystemPasswordChar = true;
            PicBoxHide.Show();

        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBoxHide_Click(object sender, EventArgs e)
        {
            PicBoxHide.Hide();
            txtBoxPass.UseSystemPasswordChar = true;
            PicBoxShow.Show();
        }

        private void PicMini_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PicMini, "Minimize");
        }

        private void PicX_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PicX, "Close");
        }
    }
}
