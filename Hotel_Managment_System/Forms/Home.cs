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
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();

        }


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
            if (DialogResult.Yes == result)
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
           
            userControlClient1.Hide();
            userControlRooms1.Hide();
            settings1.Hide();
            reports1.Hide();
            userControlReservation1.Hide();
            checkOut1.Hide();
            dashboard1.Show();
        }

        private void Client_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Client_btn);
            userControlClient1.Show();
            userControlRooms1.Hide();
            settings1.Hide();
            reports1.Hide();
            userControlReservation1.Hide();
            checkOut1.Hide();
            dashboard1.Hide();


        }

        private void Room_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Room_btn);
            userControlRooms1.Show();
            settings1.Hide();
            reports1.Hide();
            userControlReservation1.Hide();
            checkOut1.Hide();
            userControlClient1.Hide();
            dashboard1.Hide();

        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reservation_btn);
            userControlReservation1.Show();
            reports1.Hide();
            settings1.Hide();
            userControlRooms1.Hide();
            checkOut1.Hide();
            userControlClient1.Hide();
            dashboard1.Hide();


        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Reports_btn);
            settings1.Hide();
            reports1.Show();
            userControlReservation1.Hide();
            userControlRooms1.Hide();
            checkOut1.Hide();
            userControlClient1.Hide();
            dashboard1.Hide();

        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            MovePanel(Settings_btn);
            reports1.Hide();
            settings1.Show();
            userControlReservation1.Hide();
            userControlRooms1.Hide();
            checkOut1.Hide();
            userControlClient1.Hide();
            dashboard1.Hide();

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

        private void button1_Click(object sender, EventArgs e)
        {
            MovePanel(Checkout_btn);
            checkOut1.Show();
            reports1.Hide();
            settings1.Hide();
            userControlReservation1.Hide();
            userControlRooms1.Hide();
            userControlClient1.Hide();
            dashboard1.Hide();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlDashbrd1_Load(object sender, EventArgs e)
        {

        }
    }
}
