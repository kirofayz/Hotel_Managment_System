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
    public partial class UserControlClient : UserControl
    {
        public UserControlClient()
        {
            InitializeComponent();
        }
        string ID = "";

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var FirstName = FName_txt.Text;
            var LastName = LName_txt.Text;
            var Phone = Phone_txt.Text;
            var Address = Address_txt.Text;
            AddClient(new Client {
                Address = Address,
                firstName = FirstName,
                lastName = LastName,
                phone = Phone,



            });
            MessageBox.Show("Added Successfully !!");
            FName_txt.Text = "";
            LName_txt.Text = "";
            Phone_txt.Text = "";
            Address_txt.Text = "";
        }

        public  void AddClient(Client client)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            context.Clients.Add(client);
            context.SaveChanges();
        }
        public void DeleteClient(Client client1)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            context.Clients.Add(client1);
            context.SaveChanges();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var Show_Client = from c in context.Clients
                            select new { ID = c.ClientID , FirstName = c.firstName , LastName = c.lastName , Phone = c.phone , Address = c.Address };
            DGV_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in DGV_Show.Columns)
            {
                column.FillWeight = 1;
            }
            DGV_Show.DataSource = Show_Client.ToList();
            DGV_Show.Columns["ID"].Visible = false;
        }

        private void PSearch_txt_TextChanged(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            string Search = PSearch_txt.Text;
            var query = from c in context.Clients
                        where c.phone.Contains(Search)
                        select new { ID = c.ClientID, FirstName = c.firstName, LastName = c.lastName, Phone = c.phone, Address = c.Address };
            DGV_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in DGV_Show.Columns)
            {
                column.FillWeight = 1;
            }
            DGV_Show.DataSource = query.ToList();
            DGV_Show.Columns["ID"].Visible = false;
        }

        private void DGV_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DGV_Show.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                FName_txt1.Text = row.Cells[1].Value.ToString();
                LName_txt1.Text = row.Cells[2].Value.ToString();
                Phone_txt1.Text = row.Cells[3].Value.ToString();
                Address_txt1.Text = row.Cells[4].Value.ToString();

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            int id = int.Parse(ID);
            Client client = context.Clients.Where(c => c.ClientID == id ).FirstOrDefault();
            client.firstName = FName_txt1.Text;
            client.lastName = LName_txt1.Text;
            client.phone = Phone_txt1.Text;
            client.Address = Address_txt1.Text;
            context.SaveChanges();
            MessageBox.Show("Updated Successfully !!");
            FName_txt1.Text = "";
            LName_txt1.Text ="";
            Phone_txt1.Text = "";
            Address_txt1.Text ="";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            int id = int.Parse(ID);
            Client client = context.Clients.Where(c => c.ClientID == id).FirstOrDefault();
            context.Clients.Remove(client);
            context.SaveChanges();
            MessageBox.Show("Deleted Successfully !!");
            FName_txt1.Text = "";
            LName_txt1.Text = "";
            Phone_txt1.Text = "";
            Address_txt1.Text = "";
        }
    }
}
