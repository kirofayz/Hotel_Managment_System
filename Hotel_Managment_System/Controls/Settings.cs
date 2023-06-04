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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }
        HotelManagementSystemEntities context = new HotelManagementSystemEntities();
        string ID;

        private void Addbtn_Click(object sender, EventArgs e)
        {
            

            var user_name = username_txt.Text;
            var password = Password_txt.Text;
            var role = Role_combo.SelectedItem.ToString();

            if(user_name.Trim() ==string.Empty || password.Trim() == string.Empty || role.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill Out All Fields", "Require All Fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User user = new User() { UserName = user_name, Password = password, Role = role };
                context.Users.Add(user);
                context.SaveChanges();

                username_txt.Text = "";
                Password_txt.Text = "";
                Role_combo.SelectedItem = "";
                MessageBox.Show("Added Sucessfully !!");

            }



        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Role_combo.SelectedItem = "Admin";
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
                var Show_user = from u in context.Users
                                select new {ID = u.UserID,UserName = u.UserName ,Password = u.Password , Role = u.Role };
                dataGridViewUser.DataSource = Show_user.ToList();
                dataGridViewUser.Columns["ID"].Visible = false;
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                UserName_txt1.Text = row.Cells[1].Value.ToString();
                Password_txt1.Text = row.Cells[2].Value.ToString();
                Role_combo2.SelectedItem = row.Cells[3].Value.ToString();

            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ID);
            User user = context.Users.Where(u => u.UserID == id ).FirstOrDefault();
            user.UserName = UserName_txt1.Text;
            user.Password = Password_txt1.Text;
            user.Role = Role_combo2.SelectedItem.ToString();
            context.SaveChanges();

            UserName_txt1.Text = "";
            Password_txt1.Text = "";
            Role_combo2.SelectedItem = "";
            MessageBox.Show("Updated Sucessfully !!");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ID);
            User user = context.Users.Where(u => u.UserID == id).FirstOrDefault();
            context.Users.Remove(user);
            context.SaveChanges();
            UserName_txt1.Text = "";
            Password_txt1.Text = "";
            Role_combo2.SelectedItem = "";
            MessageBox.Show("Deleted Sucessfully !!");
        }

        private void Username_search_TextChanged(object sender, EventArgs e)
        {
            string Search = Username_search.Text;
            var query = from u in context.Users
                        where u.UserName.Contains(Search)
                        select new { ID = u.UserID, UserName = u.UserName, Password = u.Password, Role = u.Role };
           
            dataGridViewUser.DataSource = query.ToList();
            dataGridViewUser.Columns["ID"].Visible = false;
        }
    }
}
