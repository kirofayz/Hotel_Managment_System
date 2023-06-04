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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public string Name { get; set; }
        private void MovePanel(Control btn)
        {
            Pnl_Slide.Top = btn.Top;
            Pnl_Slide.Height = btn.Height;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
            DialogResult result = MessageBox.Show("Are You Want to Log Out ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt ");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Name_lbl.Text = Name;
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Dashboard_btn);
            
        }

        private void Client_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Client_btn);
        }

        private void Room_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Room_btn);
            userControlRooms1.Show();
            settings1.Hide();
            reports1.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reservation_btn);
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reports_btn);
            settings1.Hide();
            reports1.Show();
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Settings_btn);
            reports1.Hide();
            settings1.Show();

        }

        private void Pnl_Slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
