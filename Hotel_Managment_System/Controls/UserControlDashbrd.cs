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
    public partial class UserControlDashbrd : UserControl
    {
        private int colorIndex = 0;
        private Color[] colors = { Color.Red, Color.Teal, Color.Black };
        private Color[] colors1 = { Color.Red, Color.LightBlue, Color.Black };
        private Color[] colors2 = { Color.Red, Color.DarkTurquoise, Color.Black };
        public UserControlDashbrd()
        {
            InitializeComponent();
            #region Initilize btn S1
            button101.MouseDown += button101_MouseDown;
            button102.MouseDown += button102_MouseDown;
            button103.MouseDown += button103_MouseDown;
            button104.MouseDown += button104_MouseDown;
            button106.MouseDown += button106_MouseDown;
            button107.MouseDown += button107_MouseDown;
            button108.MouseDown += button108_MouseDown;
            button109.MouseDown += button109_MouseDown;
            button110.MouseDown += button110_MouseDown;
            button111.MouseDown += button111_MouseDown;
            button112.MouseDown += button112_MouseDown;
            button113.MouseDown += button113_MouseDown;
            #endregion


            #region Initilize btn D2
            button214.MouseDown += button214_MouseDown;
            button215.MouseDown += button215_MouseDown;
            button216.MouseDown += button216_MouseDown;
            button217.MouseDown += button217_MouseDown;
            button218.MouseDown += button218_MouseDown;
            button219.MouseDown += button219_MouseDown;
            button220.MouseDown += button220_MouseDown;
            button221.MouseDown += button221_MouseDown;
            button222.MouseDown += button222_MouseDown;
            button223.MouseDown += button223_MouseDown;
            button224.MouseDown += button224_MouseDown;
            button225.MouseDown += button225_MouseDown;
            #endregion

            #region Initilize T3
            button326.MouseDown += button326_MouseDown;
            button327.MouseDown += button327_MouseDown;
            button328.MouseDown += button328_MouseDown;
            button329.MouseDown += button329_MouseDown;
            button330.MouseDown += button330_MouseDown;
            button331.MouseDown += button331_MouseDown;
            button332.MouseDown += button332_MouseDown;
            button333.MouseDown += button333_MouseDown;
            button334.MouseDown += button334_MouseDown;
            button335.MouseDown += button335_MouseDown;

            #endregion
        }

        #region btn S1
        private void button101_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button101.BackColor = colors[colorIndex];
            }
        }
        private void button102_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button102.BackColor = colors[colorIndex];
            }
        }
        private void button103_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button103.BackColor = colors[colorIndex];
            }
        }
        private void button104_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button104.BackColor = colors[colorIndex];
            }
        }
        private void button109_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button109.BackColor = colors[colorIndex];
            }
        }
        private void button106_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button106.BackColor = colors[colorIndex];
            }
        }
        private void button107_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button107.BackColor = colors[colorIndex];
            }
        }
        private void button108_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button108.BackColor = colors[colorIndex];
            }
        }
        private void button110_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button110.BackColor = colors[colorIndex];
            }
        }
        private void button111_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button111.BackColor = colors[colorIndex];
            }
        }
        private void button112_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button112.BackColor = colors[colorIndex];
            }
        }
        private void button113_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors.Length;
                button113.BackColor = colors[colorIndex];
            }
        }

        #endregion

        #region btn D2
        private void button214_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button214.BackColor = colors1[colorIndex];
            }
        }
        private void button215_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button215.BackColor = colors1[colorIndex];
            }
        }
        private void button216_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button216.BackColor = colors1[colorIndex];
            }
        }
        private void button217_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button217.BackColor = colors1[colorIndex];
            }
        }
        private void button218_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button218.BackColor = colors1[colorIndex];
            }
        }
        private void button219_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button219.BackColor = colors1[colorIndex];
            }
        }
        private void button220_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button220.BackColor = colors1[colorIndex];
            }
        }
        private void button221_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button221.BackColor = colors1[colorIndex];
            }
        }
        private void button223_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button223.BackColor = colors1[colorIndex];
            }
        }
        private void button222_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button222.BackColor = colors1[colorIndex];
            }
        }
        private void button225_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button225.BackColor = colors1[colorIndex];
            }
        }

        private void button224_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors1.Length;
                button224.BackColor = colors1[colorIndex];
            }
        }
        #endregion

        #region btn T3
        private void button326_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button326.BackColor = colors2[colorIndex];
            }
        }
        private void button327_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button327.BackColor = colors2[colorIndex];
            }
        }
        private void button328_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button328.BackColor = colors2[colorIndex];
            }
        }
        private void button329_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button329.BackColor = colors2[colorIndex];
            }
        }
        private void button330_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button330.BackColor = colors2[colorIndex];
            }
        }
        private void button331_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button331.BackColor = colors2[colorIndex];
            }
        }
        private void button332_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button332.BackColor = colors2[colorIndex];
            }
        }
        private void button333_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button333.BackColor = colors2[colorIndex];
            }
        }
        private void button334_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button334.BackColor = colors2[colorIndex];
            }
        }
        private void button335_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                colorIndex = (colorIndex + 1) % colors2.Length;
                button335.BackColor = colors2[colorIndex];
            }
        }
        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
