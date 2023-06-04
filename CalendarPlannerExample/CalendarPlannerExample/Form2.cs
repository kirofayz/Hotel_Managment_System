using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeekPlanner;

namespace CalendarPlannerExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                weekPlanner1.CurrentDate = DateTime.Now;

           
                weekPlanner1.Columns.Add("Example1", "Room", 250);
                weekPlanner1.Columns.Add("Example2", "Type", 150);

                var itemCollection = new WeekPlannerItemCollection();
                var item = new WeekPlannerItem();
                item.StartDate = new DateTime(2023, 6, 3);
                item.EndDate = new DateTime(2023, 6, 6);
                item.Subject = "Kerolos Fayez";
                item.BackColor = Color.Red;
                itemCollection.Add(item);

                var ColumnRows = new DataColumns(weekPlanner1.Calendar);
                ColumnRows["Example1"].Data.Add("401");
                ColumnRows["Example2"].Data.Add("Single");

                weekPlanner1.Rows.Add(ColumnRows, itemCollection);
            

            
        }
    }
}
