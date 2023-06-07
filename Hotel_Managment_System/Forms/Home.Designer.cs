
namespace Hotel_Managment_System.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Checkout_btn = new System.Windows.Forms.Button();
            this.Pnl_Slide = new System.Windows.Forms.Panel();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.Reports_btn = new System.Windows.Forms.Button();
            this.Reservation_btn = new System.Windows.Forms.Button();
            this.Room_btn = new System.Windows.Forms.Button();
            this.Client_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkOut1 = new Hotel_Managment_System.Controls.CheckOut();
            this.userControlReservation1 = new Hotel_Managment_System.Forms.UserControlReservation();
            this.userControlRooms1 = new Hotel_Managment_System.Forms.UserControlRooms();
            this.reports1 = new Hotel_Managment_System.Controls.Reports();
            this.settings1 = new Hotel_Managment_System.Controls.Settings();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.Checkout_btn);
            this.panel1.Controls.Add(this.Pnl_Slide);
            this.panel1.Controls.Add(this.Settings_btn);
            this.panel1.Controls.Add(this.Reports_btn);
            this.panel1.Controls.Add(this.Reservation_btn);
            this.panel1.Controls.Add(this.Room_btn);
            this.panel1.Controls.Add(this.Client_btn);
            this.panel1.Controls.Add(this.Dashboard_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 757);
            this.panel1.TabIndex = 0;
            // 
            // Checkout_btn
            // 
            this.Checkout_btn.FlatAppearance.BorderSize = 0;
            this.Checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout_btn.ForeColor = System.Drawing.Color.White;
            this.Checkout_btn.Image = ((System.Drawing.Image)(resources.GetObject("Checkout_btn.Image")));
            this.Checkout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Checkout_btn.Location = new System.Drawing.Point(27, 451);
            this.Checkout_btn.Name = "Checkout_btn";
            this.Checkout_btn.Size = new System.Drawing.Size(237, 71);
            this.Checkout_btn.TabIndex = 7;
            this.Checkout_btn.Text = "         CheckOut";
            this.Checkout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Checkout_btn.UseVisualStyleBackColor = true;
            this.Checkout_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_Slide
            // 
            this.Pnl_Slide.BackColor = System.Drawing.Color.White;
            this.Pnl_Slide.Location = new System.Drawing.Point(11, 211);
            this.Pnl_Slide.Name = "Pnl_Slide";
            this.Pnl_Slide.Size = new System.Drawing.Size(10, 71);
            this.Pnl_Slide.TabIndex = 0;
            this.Pnl_Slide.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Slide_Paint);
            // 
            // Settings_btn
            // 
            this.Settings_btn.FlatAppearance.BorderSize = 0;
            this.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_btn.ForeColor = System.Drawing.Color.White;
            this.Settings_btn.Image = ((System.Drawing.Image)(resources.GetObject("Settings_btn.Image")));
            this.Settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_btn.Location = new System.Drawing.Point(27, 687);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(237, 71);
            this.Settings_btn.TabIndex = 6;
            this.Settings_btn.Text = "      Settings";
            this.Settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // Reports_btn
            // 
            this.Reports_btn.FlatAppearance.BorderSize = 0;
            this.Reports_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_btn.ForeColor = System.Drawing.Color.White;
            this.Reports_btn.Image = ((System.Drawing.Image)(resources.GetObject("Reports_btn.Image")));
            this.Reports_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports_btn.Location = new System.Drawing.Point(27, 610);
            this.Reports_btn.Name = "Reports_btn";
            this.Reports_btn.Size = new System.Drawing.Size(237, 71);
            this.Reports_btn.TabIndex = 5;
            this.Reports_btn.Text = "        Reports";
            this.Reports_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reports_btn.UseVisualStyleBackColor = true;
            this.Reports_btn.Click += new System.EventHandler(this.Reports_btn_Click);
            // 
            // Reservation_btn
            // 
            this.Reservation_btn.FlatAppearance.BorderSize = 0;
            this.Reservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation_btn.ForeColor = System.Drawing.Color.White;
            this.Reservation_btn.Image = ((System.Drawing.Image)(resources.GetObject("Reservation_btn.Image")));
            this.Reservation_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reservation_btn.Location = new System.Drawing.Point(27, 375);
            this.Reservation_btn.Name = "Reservation_btn";
            this.Reservation_btn.Size = new System.Drawing.Size(237, 71);
            this.Reservation_btn.TabIndex = 4;
            this.Reservation_btn.Text = "        Reservation";
            this.Reservation_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reservation_btn.UseVisualStyleBackColor = true;
            this.Reservation_btn.Click += new System.EventHandler(this.Reservation_btn_Click);
            // 
            // Room_btn
            // 
            this.Room_btn.FlatAppearance.BorderSize = 0;
            this.Room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_btn.ForeColor = System.Drawing.Color.White;
            this.Room_btn.Image = ((System.Drawing.Image)(resources.GetObject("Room_btn.Image")));
            this.Room_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Room_btn.Location = new System.Drawing.Point(27, 530);
            this.Room_btn.Name = "Room_btn";
            this.Room_btn.Size = new System.Drawing.Size(237, 71);
            this.Room_btn.TabIndex = 3;
            this.Room_btn.Text = "         Room";
            this.Room_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Room_btn.UseVisualStyleBackColor = true;
            this.Room_btn.Click += new System.EventHandler(this.Room_btn_Click);
            // 
            // Client_btn
            // 
            this.Client_btn.FlatAppearance.BorderSize = 0;
            this.Client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_btn.ForeColor = System.Drawing.Color.White;
            this.Client_btn.Image = ((System.Drawing.Image)(resources.GetObject("Client_btn.Image")));
            this.Client_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Client_btn.Location = new System.Drawing.Point(27, 293);
            this.Client_btn.Name = "Client_btn";
            this.Client_btn.Size = new System.Drawing.Size(237, 71);
            this.Client_btn.TabIndex = 2;
            this.Client_btn.Text = "         Client";
            this.Client_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Client_btn.UseVisualStyleBackColor = true;
            this.Client_btn.Click += new System.EventHandler(this.Client_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard_btn.Image")));
            this.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_btn.Location = new System.Drawing.Point(27, 211);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(237, 71);
            this.Dashboard_btn.TabIndex = 1;
            this.Dashboard_btn.Text = "     Dashboard";
            this.Dashboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 193);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fleet Club Hotel";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 115);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.Name_lbl);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(279, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1415, 193);
            this.panel3.TabIndex = 1;
            // 
            // Name_lbl
            // 
            this.Name_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.ForeColor = System.Drawing.Color.White;
            this.Name_lbl.Location = new System.Drawing.Point(154, 142);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(26, 29);
            this.Name_lbl.TabIndex = 5;
            this.Name_lbl.Text = "?";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.labelDateTime);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1415, 100);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelDateTime
            // 
            this.labelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(10, 62);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(32, 32);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(1332, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1263, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.checkOut1);
            this.panel6.Controls.Add(this.userControlReservation1);
            this.panel6.Controls.Add(this.userControlRooms1);
            this.panel6.Controls.Add(this.reports1);
            this.panel6.Controls.Add(this.settings1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(279, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1415, 564);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // checkOut1
            // 
            this.checkOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkOut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOut1.Location = new System.Drawing.Point(0, 0);
            this.checkOut1.Name = "checkOut1";
            this.checkOut1.Size = new System.Drawing.Size(1415, 564);
            this.checkOut1.TabIndex = 4;
            this.checkOut1.Visible = false;
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControlReservation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControlReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReservation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.userControlReservation1.ForeColor = System.Drawing.Color.Transparent;
            this.userControlReservation1.Location = new System.Drawing.Point(0, 0);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1415, 564);
            this.userControlReservation1.TabIndex = 3;
            this.userControlReservation1.Visible = false;
            // 
            // userControlRooms1
            // 
            this.userControlRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControlRooms1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRooms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.userControlRooms1.Location = new System.Drawing.Point(0, 0);
            this.userControlRooms1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlRooms1.Name = "userControlRooms1";
            this.userControlRooms1.Size = new System.Drawing.Size(1415, 564);
            this.userControlRooms1.TabIndex = 2;
            this.userControlRooms1.Visible = false;
            // 
            // reports1
            // 
            this.reports1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.reports1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.reports1.Location = new System.Drawing.Point(29, 40);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(1167, 492);
            this.reports1.TabIndex = 1;
            this.reports1.Visible = false;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.settings1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.settings1.Location = new System.Drawing.Point(16, -2);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(1371, 563);
            this.settings1.TabIndex = 0;
            this.settings1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1694, 757);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Button Reports_btn;
        private System.Windows.Forms.Button Reservation_btn;
        private System.Windows.Forms.Button Room_btn;
        private System.Windows.Forms.Button Client_btn;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Panel Pnl_Slide;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Controls.Settings settings1;
        private Controls.Reports reports1;
        private UserControlRooms userControlRooms1;
        private UserControlReservation userControlReservation1;
        private System.Windows.Forms.Button Checkout_btn;
        private Controls.CheckOut checkOut1;
    }
}