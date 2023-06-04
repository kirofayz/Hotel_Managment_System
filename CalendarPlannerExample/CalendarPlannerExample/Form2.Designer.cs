namespace CalendarPlannerExample
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WeekPlanner.DataColumns dataColumns2 = new WeekPlanner.DataColumns();
            this.weekPlanner1 = new WeekPlanner.CalendarPlanner();
            this.SuspendLayout();
            // 
            // weekPlanner1
            // 
            this.weekPlanner1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.weekPlanner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekPlanner1.Columns = dataColumns2;
            this.weekPlanner1.CurrentDate = new System.DateTime(2011, 9, 9, 14, 3, 35, 690);
            this.weekPlanner1.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.weekPlanner1.DayCount = 7;
            this.weekPlanner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekPlanner1.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.weekPlanner1.GridCellHeight = 50;
            this.weekPlanner1.GridTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.weekPlanner1.HeaderColumnsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.HeaderDatesFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.weekPlanner1.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.weekPlanner1.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.weekPlanner1.IsAllowedDraggingBetweenRows = true;
            this.weekPlanner1.IsAllowedTreeViewDrawing = true;
            this.weekPlanner1.ItemHeight = 20;
            this.weekPlanner1.ItemTextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.LeftMargin = 350;
            this.weekPlanner1.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.weekPlanner1.Location = new System.Drawing.Point(0, 0);
            this.weekPlanner1.Margin = new System.Windows.Forms.Padding(5);
            this.weekPlanner1.Name = "weekPlanner1";
            this.weekPlanner1.Size = new System.Drawing.Size(1253, 493);
            this.weekPlanner1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 493);
            this.Controls.Add(this.weekPlanner1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WeekPlanner.CalendarPlanner weekPlanner1;
    }
}