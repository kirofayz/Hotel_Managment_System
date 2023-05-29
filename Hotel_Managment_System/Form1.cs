using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HotelManagementSystemEntities context = new HotelManagementSystemEntities();
            var user = context.Users.Select(u => u.UserName);

            foreach (var item in user)
            {
                comboBox1.Items.Add(item);
            }

            
        }
    }
}
