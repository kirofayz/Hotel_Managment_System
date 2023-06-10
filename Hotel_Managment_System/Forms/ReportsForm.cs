using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        public string Report_txt { get; set; }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            txt_label.Text = Report_txt;
            if(txt_label.Text == "Clients Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Clients = from c in context.Clients
                                   select new { FirstName = c.firstName, LastName = c.lastName, Phone = c.phone, Address = c.Address };
                dataGridViewClients.DataSource = Show_Clients.ToList();
            }
            else if (txt_label.Text == "Rooms Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Rooms = from r in context.Rooms
                                   select new { RoomNumber = r.RoomNo , RoomType = r.RoomType , RoomPrice = r.RoomPrice+" $" , RoomFree = r.RoomFree  };

                dataGridViewClients.DataSource = Show_Rooms.ToList();
            }
            else if (txt_label.Text == "Reservation Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Reserve = from r in context.Reservations
                                   join c in context.Clients
                                   on  r.ClientID equals c.ClientID
                                   join ro in context.Rooms
                                   on r.RoomID equals ro.RoomID 
                                   join u in context.Users
                                   on r.ClientID equals u.UserID
                                  select new { GuestName = c.firstName + " " + c.lastName , Room = ro.RoomNo , RoomType = ro.RoomType  , RoomPrice = ro.RoomPrice + " $" , UserName = u.UserName , Role = u.Role  };

                dataGridViewClients.DataSource = Show_Reserve.ToList();
            }

            else if(txt_label.Text == "Employee / Users Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Emp = from u in context.Users
                               select new { UserName = u.UserName, Role = u.Role };

                dataGridViewClients.DataSource = Show_Emp.ToList();
            }
            else if(txt_label.Text == "Dialy Revenues")
            {
                Excel_btn.Visible = true;
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();

                DateTime currentDate = DateTime.Now.Date;
                var show_daily = from d in context.DataStorages
                                 join c in context.Clients
                                  on d.ClientID equals c.ClientID
                                 join ro in context.Rooms
                                 on d.RoomID equals ro.RoomID
                                 join u in context.Users
                                 on d.ClientID equals u.UserID
                                 where EntityFunctions.TruncateTime(d.CheckOutDate) == currentDate
                                 select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType ,CheckIn = d.CheckInDate , CheckOut = d.CheckOutDate , StayDuration = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate) , RoomPrice = ro.RoomPrice + " $" , TotalPay = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate) * ro.RoomPrice +" $", UserName = u.UserName, Role = u.Role };
                dataGridViewClients.DataSource = show_daily.ToList();
            }
           
                else if (txt_label.Text == "Monthly Revenues")
                {

                HotelManagementSystemEntities context = new HotelManagementSystemEntities();

                DateTime currentDate = DateTime.Now.Date;
                var show_daily = from d in context.DataStorages
                                 join c in context.Clients
                                  on d.ClientID equals c.ClientID
                                 join ro in context.Rooms
                                 on d.RoomID equals ro.RoomID
                                 join u in context.Users
                                 on d.ClientID equals u.UserID
                                 select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType, CheckIn = d.CheckInDate, CheckOut = d.CheckOutDate, StayDuration = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate), RoomPrice = ro.RoomPrice + " $", TotalPay = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate) * ro.RoomPrice + " $", UserName = u.UserName, Role = u.Role };
                dataGridViewClients.DataSource = show_daily.ToList();
                }


        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
           
            ClientReports cr = new ClientReports();
            cr.type_report = txt_label.Text;
            cr.Show();
            

        }

        private void Excel_btn_Click(object sender, EventArgs e)
        {
            //dataGridViewClients.SelectAll();
            //DataObject copydata = dataGridViewClients.GetClipboardContent();
            //if(copydata!=null)
            //{
            //    Clipboard.SetDataObject(copydata);
            //}
            //Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            //xlapp.Visible = true;
            //Microsoft.Office.Interop.Excel.Workbook xlwbook;
            //Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            //object miseddata = System.Reflection.Missing.Value;
            //xlwbook = xlapp.Workbooks.Add(miseddata);

            //xlsheet =(Microsoft.Office.Interop.Excel.Worksheet) xlwbook.Worksheets.get_Item(1);

            //Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            //xlr.Select();

            //xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
    }
}
