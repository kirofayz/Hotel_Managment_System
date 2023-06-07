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
    public partial class CheckOutReports : Form
    {
        public CheckOutReports()
        {
            InitializeComponent();
          
        }
        public string RoomNo { get; set; }
        public string Stay { get; set; }
        public string RoomPrice { get; set; }
        public string G_Id { get; set; }
        public string G_name { get; set; }
        public string U_name { get; set; }
        private void CheckOutReports_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int Total = int.Parse(RoomPrice) * int.Parse(Stay);

            checkout_rpt1.SetParameterValue("Guest_Name",G_name);
            checkout_rpt1.SetParameterValue("Guest_Id", G_Id);
            checkout_rpt1.SetParameterValue("Roon_No", RoomNo);
            checkout_rpt1.SetParameterValue("Stay", Stay);
            checkout_rpt1.SetParameterValue("Price", RoomPrice);
            checkout_rpt1.SetParameterValue("User", U_name);
            checkout_rpt1.SetParameterValue("Invoice_no", randomNumber.ToString());
            checkout_rpt1.SetParameterValue("Total", Total.ToString());



            //clients_rpt1.SetDataSource(Show_Clients.ToList());
            crystalReportViewer1.ReportSource = checkout_rpt1;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
