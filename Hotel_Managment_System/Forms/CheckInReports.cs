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
    public partial class CheckInReports : Form
    {
        public string CF_name { get; set; }
        public string CL_name { get; set; }
        public string CPhone { get; set; }
        public string CAddress { get; set; }
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public string Payment { get; set; }
        public int Room_no { get; set; }
        public string RType { get; set; }
        public int RPrice { get; set; }
        public int Reserve_no { get; set; }
        public int numberOfDays { get; set; }
        public int Total { get; set; }
        public string user_name { get; set; }

        public string G_id { get; set; }
        public CheckInReports()
        {
            InitializeComponent();
        }

        private void CheckInReports_Load(object sender, EventArgs e)
        {
            crystalReport11.SetParameterValue("FirstName",CF_name+" "+CL_name);
            crystalReport11.SetParameterValue("Phone", CPhone);
            crystalReport11.SetParameterValue("Address", CAddress);
            crystalReport11.SetParameterValue("ChKin_date", Checkin);
            crystalReport11.SetParameterValue("Chk_out", Checkout);
            crystalReport11.SetParameterValue("Payment_Method", Payment);
            crystalReport11.SetParameterValue("Room_No", Room_no);
            crystalReport11.SetParameterValue("Room_Type", RType);
            crystalReport11.SetParameterValue("Price", RPrice.ToString());
            crystalReport11.SetParameterValue("Reservation_No",Reserve_no.ToString());
            crystalReport11.SetParameterValue("No_Of_Nights",numberOfDays.ToString());
            crystalReport11.SetParameterValue("Total", Total.ToString());
            crystalReport11.SetParameterValue("UserName", user_name);
            crystalReport11.SetParameterValue("SecondName", G_id);

            crystalReportViewer1.ReportSource = crystalReport11;
            crystalReportViewer1.Refresh();
        }
    }
}
