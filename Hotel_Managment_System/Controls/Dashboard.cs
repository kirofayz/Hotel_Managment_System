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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            HotelManagementSystemEntities db = new HotelManagementSystemEntities();
            List<int> RN = new List<int>();
            List<string> RF = new List<string>();
            var Query = from r in db.Rooms
                        select new { RoomNumber = r.RoomNo , RoomFree = r.RoomFree };
            var Query1 = (from r in db.Rooms
                          select r.RoomID).Count();

            foreach (var item in Query)
            {
                RN.Add(item.RoomNumber);
                RF.Add(item.RoomFree);
            }
            
            int buttonsPerRow = 5;
            int x = 247;
            int y = 128;

            for (int i = 0; i < Query1; i++)
            {
                Button roomButton = new Button();
                roomButton.Text = RN[i].ToString();
                roomButton.ForeColor = Color.White;
                roomButton.FlatStyle = FlatStyle.Flat;
                if(RF[i].ToString() == "Y")
                {
                    roomButton.BackColor = Color.Green ;
                }
                else if(RF[i].ToString() == "N")
                {
                    roomButton.BackColor = Color.Tomato;
                }
                roomButton.Size = new Size(120, 70);
                roomButton.Location = new Point(x, y);
                this.Controls.Add(roomButton);
                x += roomButton.Width + 10;
                if ((i + 1) % buttonsPerRow == 0)
                {
                    x = 247;
                    y += roomButton.Height + 10;
                }
            }
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
