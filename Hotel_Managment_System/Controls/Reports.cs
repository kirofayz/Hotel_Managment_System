using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System.Controls
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm fr = new Forms.ReportsForm();
            fr.Report_txt = "Employee / Users Reports";
            fr.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm fr = new Forms.ReportsForm();
            fr.Report_txt = "Clients Reports";
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm fr = new Forms.ReportsForm();
            fr.Report_txt = "Rooms Reports";
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm fr = new Forms.ReportsForm();
            fr.Report_txt = "Reservation Reports";
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
            Forms.ReportsForm fr = new Forms.ReportsForm();
            fr.Report_txt = "Dialy Revenues";
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm fr = new Forms.ReportsForm();
            fr.Report_txt = "Monthly Revenues";
            fr.Show();
        }
    }
}
