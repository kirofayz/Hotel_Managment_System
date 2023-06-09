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
    public partial class UserControlReservation : UserControl
    {
        public UserControlReservation()
        {
            InitializeComponent();
        }
        public String user_name { get; set; }
        public void SetData(string data)
        {
            // Do something with the data
            // For example, display it in a label or textbox
            user_name = data;
        }
        private void tabPageUpdateReservation_Click(object sender, EventArgs e)
        {

        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Query = from c in context.Clients
                        select new { FirstName = c.firstName, LastName = c.lastName };

            var Query1 = from r in context.Rooms
                         where r.RoomFree == "Y"
                         select new { RoomNo = r.RoomNo };

            var Query2 = from r in context.Rooms
                         where r.RoomFree == "N"
                         select new { RoomNo = r.RoomNo };

            List<int> R = new List<int>();
            List<string> C = new List<string>();
            List<int> R1 = new List<int>();

            foreach (var item in Query1)
            {
                R.Add(item.RoomNo);
            }
            foreach (var item in Query2)
            {
                R1.Add(item.RoomNo);
            }

            foreach (var item in Query)
            {
                C.Add(item.FirstName + " " + item.LastName);
            }
            Client_combo.DataSource = C;
            Room_combo.DataSource = R;
            RSearch_combo.DataSource = R1;
            Payment_combo.SelectedIndex = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Room_no = Room_combo.SelectedItem.ToString();
            int R_no = int.Parse(Room_no);
            var CF_name = "";
            var CL_name = "";
            var CPhone = "";
            var CAddress = "";
            var RType = "";
            var RPrice = 0;
            var Client_name = Client_combo.SelectedItem.ToString();
            string[] words = Client_name.Split(' ');
            CF_name = words[0];
            CL_name = words[1];
            var user_name = Program.Username;


            // data inserted table
            var Room_ID = 0;
            var Client_ID = 0 ;
            var User_ID = 0;
            var Payment = Payment_combo.SelectedItem.ToString();
            DateTime Checkin = dateTimePickerIn.Value.Date;
            DateTime Checkout = dateTimePickerOut.Value.Date;

            var Query = from r in context.Rooms
                          where r.RoomNo == R_no
                          select new { ID = r.RoomID , Type = r.RoomType , Price = r.RoomPrice } ;
            foreach (var item in Query)
            {
                Room_ID = item.ID;
                RType = item.Type;
                RPrice = item.Price;
            }

            var Query2 = from c in context.Clients
                         where c.firstName == CF_name
                         select new { ID = c.ClientID , Phone = c.phone , Address =c.Address  };

            foreach (var item in Query2)
            {
                Client_ID = item.ID;
                CPhone = item.Phone;
                CAddress = item.Address;
            }

            var Query3 = from u in context.Users
                         where u.UserName == user_name
                         select new { ID = u.UserID };
            foreach (var item in Query3)
            {
                User_ID = item.ID;
            }

            // Insert Reservation
            Reservation R = new Reservation() { CheckInDate = Checkin, CheckOutDate = Checkout, PaymentMethod = Payment, UserID = User_ID, ClientID = Client_ID, RoomID = Room_ID };
            var Query4 = context.Rooms.FirstOrDefault(ww => ww.RoomID == Room_ID);
            Query4.RoomFree = "N";
            context.Reservations.Add(R);
            context.SaveChanges();
            MessageBox.Show("Added Successfully !!");

            int Reserve_no = 10;
            TimeSpan timeSpan = Checkout - Checkin ;
            int numberOfDays = (int)timeSpan.TotalDays;

            int Total = numberOfDays * RPrice;


            // MessageBox.Show(CF_name + CL_name + CPhone + CAddress + Checkin + Checkout + Payment + Room_no + RType + RPrice + Reserve_no + numberOfDays + Total + user_name);
            Forms.CheckInReports CI = new CheckInReports();
            CI.CF_name = CF_name;
            CI.CL_name = CL_name;
            CI.CPhone = CPhone;
            CI.CAddress = CAddress;
            CI.Checkin = Checkin.ToString("dd-MM-yyyy");
            CI.Checkout = Checkout.ToString("dd-MM-yyyy");
            CI.Payment = Payment;
            CI.Room_no = int.Parse(Room_no);
            CI.RType = RType;
            CI.RPrice = RPrice;
            CI.Reserve_no = Reserve_no;
            CI.numberOfDays = numberOfDays;
            CI.Total = Total;
            CI.user_name = user_name;
            CI.G_id = Client_ID.ToString();
            CI.Show();




            //MessageBox.Show(Room_ID + " , " + Client_ID + " , " + User_ID , Checkin );



        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Show_Reserve = from r in context.Reservations
                               join c in context.Clients
                               on r.ClientID equals c.ClientID
                               join ro in context.Rooms
                               on r.RoomID equals ro.RoomID
                               select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType , CheckIn = r.CheckInDate , Checkout = r.CheckOutDate };
            DGV_Show.DefaultCellStyle.ForeColor = Color.Black;
            DGV_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Show.DataSource = Show_Reserve.ToList();
           


        }

        private void DGV_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Show_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void RSearch_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = RSearch_combo.SelectedItem.ToString();
            int s = int.Parse(selected);
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Show_Reserve = from r in context.Reservations
                               join c in context.Clients
                               on r.ClientID equals c.ClientID
                               join ro in context.Rooms
                               on r.RoomID equals ro.RoomID
                               where ro.RoomNo == s
                               select new { GuestName = c.firstName + " " + c.lastName, Room = ro.RoomNo, RoomType = ro.RoomType, CheckIn = r.CheckInDate, Checkout = r.CheckOutDate };
            DGV_Show.DefaultCellStyle.ForeColor = Color.Black;
            DGV_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Show.DataSource = Show_Reserve.ToList();
        }
    }
}
