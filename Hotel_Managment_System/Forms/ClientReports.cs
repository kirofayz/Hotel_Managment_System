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
    public partial class ClientReports : Form
    {
        public ClientReports()
        {
            InitializeComponent();
        }
        public string type_report { get; set; }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            if(type_report == "Clients Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Clients = from c in context.Clients
                                   select new { FirstName = c.firstName, LastName = c.lastName, Phone = c.phone, Address = c.Address };

                clients_rpt1.SetDataSource(Show_Clients.ToList());
                crystalReportViewer1.ReportSource = clients_rpt1;
                crystalReportViewer1.Refresh();
            }
            else if (type_report == "Rooms Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Rooms = from r in context.Rooms
                                 select new { RoomNumber = r.RoomNo, RoomType = r.RoomType, RoomPrice = r.RoomPrice + " $", RoomFree = r.RoomFree };

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add("RoomNumber", typeof(string));
                dt.Columns.Add("RoomType", typeof(string));
                dt.Columns.Add("RoomPrice", typeof(string));

                foreach (var item in Show_Rooms)
                {
                    dt.Rows.Add(item.RoomNumber, item.RoomType, item.RoomPrice);
                }
                ds.Tables.Add(dt);
                ds.WriteXmlSchema("Room.xml");

                rooms_rpt1.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rooms_rpt1;
                crystalReportViewer1.Refresh();


            }
            else if (type_report == "Reservation Reports")
            {

                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Reserve = from r in context.Reservations
                                   join c in context.Clients
                                   on r.ClientID equals c.ClientID
                                   join ro in context.Rooms
                                   on r.RoomID equals ro.RoomID
                                   join u in context.Users
                                   on r.ClientID equals u.UserID
                                   select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType, RoomPrice = ro.RoomPrice + " $", UserName = u.UserName, Role = u.Role };

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add("Guest Name", typeof(string));
                dt.Columns.Add("Room No", typeof(string));
                dt.Columns.Add("Room Type", typeof(string));
                dt.Columns.Add("Room Price", typeof(string));
                dt.Columns.Add("User Name", typeof(string));
                dt.Columns.Add("Role", typeof(string));

                foreach (var item in Show_Reserve)
                {
                    dt.Rows.Add(item.GuestName, item.Room, item.RoomType , item.RoomPrice , item.UserName , item.Role);
                }
                ds.Tables.Add(dt);
                ds.WriteXmlSchema("Data.xml");
                reserve_rpt1.SetDataSource(ds);
                crystalReportViewer1.ReportSource = reserve_rpt1;
                crystalReportViewer1.Refresh();
            }
            else if (type_report == "Employee / Users Reports")
            {
                HotelManagementSystemEntities context = new HotelManagementSystemEntities();
                var Show_Emp = from u in context.Users
                               select new { UserName = u.UserName, Role = u.Role };
               
                emp_rpt1.SetDataSource(Show_Emp.ToList());
                crystalReportViewer1.ReportSource = emp_rpt1;
                crystalReportViewer1.Refresh();

            }
            else if (type_report == "Dialy Revenues")
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
                                 where EntityFunctions.TruncateTime(d.CheckOutDate) == currentDate
                                 select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType, CheckIn = d.CheckInDate, CheckOut = d.CheckOutDate, StayDuration = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate), RoomPrice = ro.RoomPrice + " $", TotalPay = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate) * ro.RoomPrice , UserName = u.UserName, Role = u.Role };

                int Total_sum = 0;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add("Guest Name", typeof(string));
                dt.Columns.Add("Room No", typeof(string));
                dt.Columns.Add("Room Type", typeof(string));
                dt.Columns.Add("CheckIn Date", typeof(string));
                dt.Columns.Add("CheckOut Date", typeof(string));
                dt.Columns.Add("StayDuration", typeof(string));
                dt.Columns.Add("Room Price", typeof(string));
                dt.Columns.Add("Total Pay", typeof(string));
                dt.Columns.Add("User Name", typeof(string));
                dt.Columns.Add("Role", typeof(string));

                foreach (var item in show_daily)
                {
                    dt.Rows.Add(item.GuestName, item.Room, item.RoomType, item.CheckIn , item.CheckOut , item.StayDuration , item.RoomPrice, item.TotalPay );
                    Total_sum += item.TotalPay ?? 0;

                }
                ds.Tables.Add(dt);
                ds.WriteXmlSchema("Daily.xml");
                daily_rpt1.SetDataSource(ds);
                daily_rpt1.SetParameterValue("Total", Total_sum);
                crystalReportViewer1.ReportSource = daily_rpt1;
                crystalReportViewer1.Refresh();
                
            }

            else if (type_report == "Monthly Revenues")
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
                                 select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType, CheckIn = d.CheckInDate, CheckOut = d.CheckOutDate, StayDuration = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate), RoomPrice = ro.RoomPrice + " $", TotalPay = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate) * ro.RoomPrice, UserName = u.UserName, Role = u.Role };

                int Total_sum = 0;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add("Guest Name", typeof(string));
                dt.Columns.Add("Room No", typeof(string));
                dt.Columns.Add("Room Type", typeof(string));
                dt.Columns.Add("CheckIn Date", typeof(string));
                dt.Columns.Add("CheckOut Date", typeof(string));
                dt.Columns.Add("StayDuration", typeof(string));
                dt.Columns.Add("Room Price", typeof(string));
                dt.Columns.Add("Total Pay", typeof(string));
                dt.Columns.Add("User Name", typeof(string));
                dt.Columns.Add("Role", typeof(string));

                foreach (var item in show_daily)
                {
                    dt.Rows.Add(item.GuestName, item.Room, item.RoomType, item.CheckIn, item.CheckOut, item.StayDuration, item.RoomPrice, item.TotalPay);
                    Total_sum += item.TotalPay ?? 0;

                }
                ds.Tables.Add(dt);
                ds.WriteXmlSchema("Daily.xml");
                daily_rpt1.SetDataSource(ds);
                daily_rpt1.SetParameterValue("Total", Total_sum);
                crystalReportViewer1.ReportSource = daily_rpt1;
                crystalReportViewer1.Refresh();
                
            }
        }
    }
}
