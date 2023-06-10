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
    public partial class UserControlRooms : UserControl
    {
        HotelManagementSystemEntities context = new HotelManagementSystemEntities();
        string Id;
        public UserControlRooms()
        {
            InitializeComponent();
        }

        private void UserControlRooms_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int xId = int.Parse(Id);
            Room room = context.Rooms.Where(u => u.RoomID == xId).FirstOrDefault();
            context.Rooms.Remove(room);
            context.SaveChanges();
        }

        private void txtBoxPhoneNo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnNo2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnYes2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAndDeleteRoomTab_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxRoomNo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxRoomNo.Text, out int roomNo))
            {
                var Show_user = from u in context.Rooms
                                where u.RoomNo == roomNo
                                select new { RoomNumber = u.RoomNo, RoomType = u.RoomType, RoomPrice = u.RoomPrice, RoomFree = u.RoomFree };

                dataGridViewRoom.DataSource = Show_user.ToList();
                // dataGridViewRoom.Columns["ID"].Visible = false;
            }
            else
            {
                // Handle the case where the entered text is not a valid integer
                // For example, you might clear the data grid view or display an error message.
                var Show_user = from u in context.Rooms
                                
                                select new { RoomNumber = u.RoomNo, RoomType = u.RoomType, RoomPrice = u.RoomPrice, RoomFree = u.RoomFree };

                dataGridViewRoom.DataSource = Show_user.ToList();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchNameTab_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var RoomNo = RoomNo_txt.Text;
            var RoomPrice = RoomPrice_txt.Text;
            var RoomType = comboBoxType.SelectedItem.ToString();
            var RoomFree = "";
            if (radioBtnYes.Checked)
            {
                RoomFree = "Y";
            }
            else if (radioBtnNo.Checked)
            {
                RoomFree = "N";
            }
            Room room = new Room() { RoomNo = int.Parse(RoomNo), RoomPrice = int.Parse(RoomPrice), RoomFree = RoomFree, RoomType = RoomType };
            AddRoom(room);
            MessageBox.Show("Added Successfully");
        }

        public void AddRoom(Room room)
        {
            context.Rooms.Add(room);
            context.SaveChanges();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomTab1_Click(object sender, EventArgs e)
        {

        }

        private void SearchNameTab_Enter(object sender, EventArgs e)
        {
            var Show_user = from u in context.Rooms
                            select new { ID = u.RoomID, RoomNnmber=u.RoomNo,RoomType= u.RoomType, RoomPrice=u.RoomPrice, RoomFree=u.RoomFree };
            dataGridViewRoom.DataSource = Show_user.ToList();
            dataGridViewRoom.Columns["ID"].Visible = false;
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                textBoxRoomNo1.Text = row.Cells[1].Value.ToString();
                comboBoxRoomType1.SelectedItem = row.Cells[2].Value.ToString();
                textBoxRoomPrice1.Text = row.Cells[3].Value.ToString();
                var check = row.Cells[4].Value.ToString();
                if (check == "Y")
                    radioButtonYes1.Checked = true;
                else if (check=="N")
                    radioButtonNo1.Checked=true;
            }
        }

        private void buttonUpdate1_Click(object sender, EventArgs e)
        {
            int xId = int.Parse(Id);
            Room room = context.Rooms.Where(u => u.RoomID == xId).FirstOrDefault();
            room.RoomNo = int.Parse(textBoxRoomNo1.Text);
            room.RoomPrice = int.Parse(textBoxRoomPrice1.Text);
            room.RoomType = comboBoxRoomType1.SelectedItem.ToString();
            var RoomFree = "";
            if (radioButtonYes1.Checked)
            {
                RoomFree = "Y";
            }
            else if (radioButtonNo1.Checked)
            {
                RoomFree = "N";
            }
            context.SaveChanges();
        }


    }
}
