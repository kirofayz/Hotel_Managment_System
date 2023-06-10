
namespace Hotel_Managment_System.Forms
{
    partial class UserControlReservation
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
            this.tabPageUpdateReservation = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.Client_combo = new System.Windows.Forms.ComboBox();
            this.Room_combo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Payment_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.DTP_out = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.DTP_in = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.DGV_Search = new System.Windows.Forms.DataGridView();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Room_txt = new System.Windows.Forms.MaskedTextBox();
            this.Payment_txt = new System.Windows.Forms.TextBox();
            this.tabPageUpdateReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageUpdateReservation
            // 
            this.tabPageUpdateReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPageUpdateReservation.Controls.Add(this.Payment_txt);
            this.tabPageUpdateReservation.Controls.Add(this.Room_txt);
            this.tabPageUpdateReservation.Controls.Add(this.Name_txt);
            this.tabPageUpdateReservation.Controls.Add(this.label10);
            this.tabPageUpdateReservation.Controls.Add(this.label11);
            this.tabPageUpdateReservation.Controls.Add(this.label12);
            this.tabPageUpdateReservation.Controls.Add(this.label7);
            this.tabPageUpdateReservation.Controls.Add(this.DTP_out);
            this.tabPageUpdateReservation.Controls.Add(this.label9);
            this.tabPageUpdateReservation.Controls.Add(this.DTP_in);
            this.tabPageUpdateReservation.Controls.Add(this.button2);
            this.tabPageUpdateReservation.Controls.Add(this.buttonCancel);
            this.tabPageUpdateReservation.Controls.Add(this.label8);
            this.tabPageUpdateReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPageUpdateReservation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageUpdateReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUpdateReservation.Name = "tabPageUpdateReservation";
            this.tabPageUpdateReservation.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageUpdateReservation.Size = new System.Drawing.Size(1159, 462);
            this.tabPageUpdateReservation.TabIndex = 2;
            this.tabPageUpdateReservation.Text = "Update and Cancel";
            this.tabPageUpdateReservation.Click += new System.EventHandler(this.tabPageUpdateReservation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Update Or Cancel Reservation       ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(582, 369);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(213, 44);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPageAddReservation.Controls.Add(this.button1);
            this.tabPageAddReservation.Controls.Add(this.Payment_combo);
            this.tabPageAddReservation.Controls.Add(this.label6);
            this.tabPageAddReservation.Controls.Add(this.label5);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.Room_combo);
            this.tabPageAddReservation.Controls.Add(this.Client_combo);
            this.tabPageAddReservation.Controls.Add(this.add_btn);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPageAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1159, 462);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(104, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(614, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Room No :";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.Location = new System.Drawing.Point(109, 390);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(213, 44);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Client_combo
            // 
            this.Client_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Client_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Client_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Client_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_combo.ForeColor = System.Drawing.Color.White;
            this.Client_combo.FormattingEnabled = true;
            this.Client_combo.Location = new System.Drawing.Point(109, 128);
            this.Client_combo.Margin = new System.Windows.Forms.Padding(4);
            this.Client_combo.Name = "Client_combo";
            this.Client_combo.Size = new System.Drawing.Size(379, 33);
            this.Client_combo.TabIndex = 12;
            // 
            // Room_combo
            // 
            this.Room_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Room_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Room_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Room_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_combo.ForeColor = System.Drawing.Color.White;
            this.Room_combo.FormattingEnabled = true;
            this.Room_combo.Location = new System.Drawing.Point(619, 128);
            this.Room_combo.Margin = new System.Windows.Forms.Padding(4);
            this.Room_combo.Name = "Room_combo";
            this.Room_combo.Size = new System.Drawing.Size(401, 33);
            this.Room_combo.TabIndex = 13;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIn.Location = new System.Drawing.Point(109, 309);
            this.dateTimePickerIn.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(379, 30);
            this.dateTimePickerIn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(104, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Payment Method :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(104, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "In";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOut.Location = new System.Drawing.Point(619, 309);
            this.dateTimePickerOut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(401, 30);
            this.dateTimePickerOut.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(614, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Add Reservation       ";
            // 
            // Payment_combo
            // 
            this.Payment_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payment_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Payment_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Payment_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_combo.ForeColor = System.Drawing.Color.White;
            this.Payment_combo.FormattingEnabled = true;
            this.Payment_combo.Items.AddRange(new object[] {
            "Visa",
            "Cash"});
            this.Payment_combo.Location = new System.Drawing.Point(109, 225);
            this.Payment_combo.Margin = new System.Windows.Forms.Padding(4);
            this.Payment_combo.Name = "Payment_combo";
            this.Payment_combo.Size = new System.Drawing.Size(379, 33);
            this.Payment_combo.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1024, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPageAddReservation);
            this.tabControl1.Controls.Add(this.tabPageUpdateReservation);
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabControl1.Location = new System.Drawing.Point(19, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 492);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(599, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Out";
            // 
            // DTP_out
            // 
            this.DTP_out.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_out.Location = new System.Drawing.Point(604, 286);
            this.DTP_out.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_out.Name = "DTP_out";
            this.DTP_out.Size = new System.Drawing.Size(401, 30);
            this.DTP_out.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(89, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "In";
            // 
            // DTP_in
            // 
            this.DTP_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_in.Location = new System.Drawing.Point(94, 286);
            this.DTP_in.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_in.Name = "DTP_in";
            this.DTP_in.Size = new System.Drawing.Size(379, 30);
            this.DTP_in.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(304, 369);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 44);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(89, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Payment Method :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(599, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Room No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(89, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Client Name :";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Search.Controls.Add(this.DGV_Search);
            this.Search.Controls.Add(this.label13);
            this.Search.Location = new System.Drawing.Point(4, 4);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1159, 462);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label13.Location = new System.Drawing.Point(7, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Search Reservation :";
            // 
            // DGV_Search
            // 
            this.DGV_Search.AllowUserToAddRows = false;
            this.DGV_Search.AllowUserToDeleteRows = false;
            this.DGV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Search.Location = new System.Drawing.Point(12, 59);
            this.DGV_Search.Name = "DGV_Search";
            this.DGV_Search.ReadOnly = true;
            this.DGV_Search.RowHeadersWidth = 51;
            this.DGV_Search.RowTemplate.Height = 24;
            this.DGV_Search.Size = new System.Drawing.Size(1131, 382);
            this.DGV_Search.TabIndex = 33;
            this.DGV_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Search_CellClick);
            // 
            // Name_txt
            // 
            this.Name_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_txt.ForeColor = System.Drawing.Color.White;
            this.Name_txt.Location = new System.Drawing.Point(94, 111);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(379, 23);
            this.Name_txt.TabIndex = 44;
            // 
            // Room_txt
            // 
            this.Room_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Room_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Room_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Room_txt.ForeColor = System.Drawing.Color.White;
            this.Room_txt.Location = new System.Drawing.Point(604, 111);
            this.Room_txt.Name = "Room_txt";
            this.Room_txt.Size = new System.Drawing.Size(401, 23);
            this.Room_txt.TabIndex = 45;
            // 
            // Payment_txt
            // 
            this.Payment_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payment_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Payment_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Payment_txt.ForeColor = System.Drawing.Color.White;
            this.Payment_txt.Location = new System.Drawing.Point(94, 209);
            this.Payment_txt.Name = "Payment_txt";
            this.Payment_txt.Size = new System.Drawing.Size(379, 23);
            this.Payment_txt.TabIndex = 46;
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1233, 564);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tabPageUpdateReservation.ResumeLayout(false);
            this.tabPageUpdateReservation.PerformLayout();
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUpdateReservation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_out;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTP_in;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Payment_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox Room_combo;
        private System.Windows.Forms.ComboBox Client_combo;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.DataGridView DGV_Search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Payment_txt;
        private System.Windows.Forms.MaskedTextBox Room_txt;
        private System.Windows.Forms.TextBox Name_txt;
    }
}
