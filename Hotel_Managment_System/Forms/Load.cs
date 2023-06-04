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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 837)
            {
                timer1.Stop();
                SignIn S = new SignIn();
                S.Show();
                this.Hide();
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {

        }
    }
}
