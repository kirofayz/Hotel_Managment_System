
namespace Hotel_Managment_System.Controls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.load_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 81;
            this.label1.Text = "Rooms :";
            // 
            // load_btn
            // 
            this.load_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.load_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_btn.FlatAppearance.BorderSize = 0;
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.load_btn.ForeColor = System.Drawing.Color.White;
            this.load_btn.Location = new System.Drawing.Point(997, 511);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(184, 58);
            this.load_btn.TabIndex = 82;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1283, 592);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load_btn;
    }
}
