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

namespace Hotel_Managment_System.Controls
{
    public partial class CheckOut : UserControl
    {

        public CheckOut()
        {
            InitializeComponent();
            
        }
       
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string selectedRoom = Rooms_combo.SelectedItem.ToString();
            string RoomNo = "";
            string Stay = "";
            string RoomPrice = "";
            string G_Id = "";
            string G_name = "";
            string U_name = "";
            int R_id = 0;

            DateTime currentDate = DateTime.Now.Date;
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Query = (from d in context.Reservations
                         join r in context.Rooms
                         on d.RoomID equals r.RoomID
                         join c in context.Clients
                         on d.ClientID equals c.ClientID
                         join s in context.Users
                         on d.UserID equals s.UserID
                         orderby r.RoomNo ascending
                         where EntityFunctions.TruncateTime(d.CheckOutDate) == currentDate
                         select new {Reservation_id = d.ReservationID , Room = r.RoomNo, StayDuration = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate), Price = r.RoomPrice, GuestId = c.ClientID, GuestName = c.firstName + " " + c.lastName , Username = s.UserName }).Distinct();

           // MessageBox.Show(selectedRoom);
            foreach (var item in Query)
            {
                if(item.Room == int.Parse(selectedRoom))
                {
                    RoomNo = selectedRoom;
                    Stay = item.StayDuration.ToString();
                    RoomPrice = item.Price.ToString();
                    G_Id = item.GuestId.ToString();
                    G_name = item.GuestName;
                    U_name = item.Username;
                    R_id = item.Reservation_id;
                }
            }
            var reserve = context.Reservations.FirstOrDefault(ww => ww.ReservationID == R_id);
            DataStorage Ds = new DataStorage();
            Ds.ReservationID = reserve.ReservationID;
            Ds.RoomID = reserve.RoomID;
            Ds.UserID = reserve.UserID;
            Ds.ClientID = reserve.ClientID;
            Ds.CheckInDate = reserve.CheckInDate;
            Ds.CheckOutDate = reserve.CheckOutDate;
            Ds.PaymentMethod = reserve.PaymentMethod;
            context.DataStorages.Add(Ds);
            context.Reservations.Remove(reserve);
            context.SaveChanges();

            Forms.CheckOutReports cr = new Forms.CheckOutReports();
            cr.RoomNo = RoomNo;
            cr.Stay = Stay;
            cr.RoomPrice = RoomPrice;
            cr.G_Id = G_Id;
            cr.G_name = G_name;
            cr.U_name = U_name;
            cr.Show();
            
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Query = (from d in context.Reservations
                         join r in context.Rooms
                         on d.RoomID equals r.RoomID
                         join c in context.Clients
                         on d.ClientID equals c.ClientID
                         orderby r.RoomNo ascending
                         where EntityFunctions.TruncateTime(d.CheckOutDate) == currentDate
                         select new { Room = r.RoomNo, StayDuration = DbFunctions.DiffDays(d.CheckInDate, d.CheckOutDate), Price = r.RoomPrice, GuestId = c.ClientID, GuestNme = c.firstName + " " + c.lastName }).Distinct();

            List<int> R = new List<int>();
            foreach (var item in Query)
            {
                R.Add(item.Room);
            }
            Rooms_combo.DataSource = R;
        }
    }
}
