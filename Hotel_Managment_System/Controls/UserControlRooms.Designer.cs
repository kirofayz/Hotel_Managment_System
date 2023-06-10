
namespace Hotel_Managment_System.Forms
{
    partial class UserControlRooms
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateAndDeleteRoomTab = new System.Windows.Forms.TabPage();
            this.textBoxRoomPrice1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxRoomType1 = new System.Windows.Forms.ComboBox();
            this.textBoxRoomNo1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpdate1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxRoomNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.SearchNameTab = new System.Windows.Forms.TabPage();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.RoomNo_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddRoomTab1 = new System.Windows.Forms.TabPage();
            this.RoomPrice_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UpdateAndDeleteRoomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SearchNameTab.SuspendLayout();
            this.AddRoomTab1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDelete.Location = new System.Drawing.Point(574, 332);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(225, 52);
            this.BtnDelete.TabIndex = 30;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Update and Delete Room :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UpdateAndDeleteRoomTab
            // 
            this.UpdateAndDeleteRoomTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UpdateAndDeleteRoomTab.Controls.Add(this.textBoxRoomPrice1);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.label12);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.comboBoxRoomType1);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.textBoxRoomNo1);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.label7);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.radioButtonNo1);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.radioButtonYes1);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.label8);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.buttonUpdate1);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.label9);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.BtnDelete);
            this.UpdateAndDeleteRoomTab.Controls.Add(this.label4);
            this.UpdateAndDeleteRoomTab.Location = new System.Drawing.Point(4, 4);
            this.UpdateAndDeleteRoomTab.Name = "UpdateAndDeleteRoomTab";
            this.UpdateAndDeleteRoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateAndDeleteRoomTab.Size = new System.Drawing.Size(1159, 463);
            this.UpdateAndDeleteRoomTab.TabIndex = 2;
            this.UpdateAndDeleteRoomTab.Text = "Update and Delete Room ";
            this.UpdateAndDeleteRoomTab.Click += new System.EventHandler(this.UpdateAndDeleteRoomTab_Click);
            // 
            // textBoxRoomPrice1
            // 
            this.textBoxRoomPrice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxRoomPrice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoomPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomPrice1.ForeColor = System.Drawing.Color.White;
            this.textBoxRoomPrice1.Location = new System.Drawing.Point(763, 168);
            this.textBoxRoomPrice1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRoomPrice1.Name = "textBoxRoomPrice1";
            this.textBoxRoomPrice1.Size = new System.Drawing.Size(280, 30);
            this.textBoxRoomPrice1.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(758, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 25);
            this.label12.TabIndex = 50;
            this.label12.Text = "Room Price :            ";
            // 
            // comboBoxRoomType1
            // 
            this.comboBoxRoomType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboBoxRoomType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType1.ForeColor = System.Drawing.Color.White;
            this.comboBoxRoomType1.FormattingEnabled = true;
            this.comboBoxRoomType1.Items.AddRange(new object[] {
            "Single ",
            "Double"});
            this.comboBoxRoomType1.Location = new System.Drawing.Point(115, 168);
            this.comboBoxRoomType1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxRoomType1.Name = "comboBoxRoomType1";
            this.comboBoxRoomType1.Size = new System.Drawing.Size(268, 33);
            this.comboBoxRoomType1.TabIndex = 49;
            // 
            // textBoxRoomNo1
            // 
            this.textBoxRoomNo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxRoomNo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRoomNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNo1.ForeColor = System.Drawing.Color.White;
            this.textBoxRoomNo1.Location = new System.Drawing.Point(420, 168);
            this.textBoxRoomNo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRoomNo1.Name = "textBoxRoomNo1";
            this.textBoxRoomNo1.Size = new System.Drawing.Size(280, 30);
            this.textBoxRoomNo1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(110, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Type :";
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonNo1.Location = new System.Drawing.Point(420, 236);
            this.radioButtonNo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(60, 29);
            this.radioButtonNo1.TabIndex = 46;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "No";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonYes1.Location = new System.Drawing.Point(274, 240);
            this.radioButtonYes1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(70, 29);
            this.radioButtonYes1.TabIndex = 45;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Yes";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(115, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Free :";
            // 
            // buttonUpdate1
            // 
            this.buttonUpdate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.buttonUpdate1.FlatAppearance.BorderSize = 0;
            this.buttonUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate1.Location = new System.Drawing.Point(274, 332);
            this.buttonUpdate1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdate1.Name = "buttonUpdate1";
            this.buttonUpdate1.Size = new System.Drawing.Size(225, 52);
            this.buttonUpdate1.TabIndex = 43;
            this.buttonUpdate1.Text = "Update";
            this.buttonUpdate1.UseVisualStyleBackColor = false;
            this.buttonUpdate1.Click += new System.EventHandler(this.buttonUpdate1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(415, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Room No :            ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Search Room :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBoxRoomNo
            // 
            this.txtBoxRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBoxRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRoomNo.Location = new System.Drawing.Point(225, 84);
            this.txtBoxRoomNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxRoomNo.Name = "txtBoxRoomNo";
            this.txtBoxRoomNo.Size = new System.Drawing.Size(284, 30);
            this.txtBoxRoomNo.TabIndex = 5;
            this.txtBoxRoomNo.TextChanged += new System.EventHandler(this.txtBoxRoomNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(220, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Room No :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewRoom.Location = new System.Drawing.Point(28, 135);
            this.dataGridViewRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 26;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1098, 309);
            this.dataGridViewRoom.TabIndex = 34;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // SearchNameTab
            // 
            this.SearchNameTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SearchNameTab.Controls.Add(this.dataGridViewRoom);
            this.SearchNameTab.Controls.Add(this.label6);
            this.SearchNameTab.Controls.Add(this.txtBoxRoomNo);
            this.SearchNameTab.Controls.Add(this.label10);
            this.SearchNameTab.Location = new System.Drawing.Point(4, 4);
            this.SearchNameTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchNameTab.Name = "SearchNameTab";
            this.SearchNameTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchNameTab.Size = new System.Drawing.Size(1159, 463);
            this.SearchNameTab.TabIndex = 1;
            this.SearchNameTab.Text = "Search Name";
            this.SearchNameTab.Click += new System.EventHandler(this.SearchNameTab_Click);
            this.SearchNameTab.Enter += new System.EventHandler(this.SearchNameTab_Enter);
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.ForeColor = System.Drawing.Color.White;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Single ",
            "Double"});
            this.comboBoxType.Location = new System.Drawing.Point(110, 150);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(268, 33);
            this.comboBoxType.TabIndex = 41;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // RoomNo_txt
            // 
            this.RoomNo_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.RoomNo_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomNo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo_txt.ForeColor = System.Drawing.Color.White;
            this.RoomNo_txt.Location = new System.Drawing.Point(449, 151);
            this.RoomNo_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RoomNo_txt.Name = "RoomNo_txt";
            this.RoomNo_txt.Size = new System.Drawing.Size(280, 30);
            this.RoomNo_txt.TabIndex = 39;
            this.RoomNo_txt.TextChanged += new System.EventHandler(this.txtBoxPhoneNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Type :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnNo.Location = new System.Drawing.Point(396, 235);
            this.radioBtnNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(60, 29);
            this.radioBtnNo.TabIndex = 37;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            this.radioBtnNo.CheckedChanged += new System.EventHandler(this.radioBtnNo_CheckedChanged);
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnYes.Location = new System.Drawing.Point(239, 235);
            this.radioBtnYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(70, 29);
            this.radioBtnYes.TabIndex = 36;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Yes";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            this.radioBtnYes.CheckedChanged += new System.EventHandler(this.radioBtnYes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Free :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(476, 329);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 52);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(444, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Room No :            ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(131)))), ((int)(((byte)(136)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Add Room :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddRoomTab1
            // 
            this.AddRoomTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddRoomTab1.Controls.Add(this.RoomPrice_txt);
            this.AddRoomTab1.Controls.Add(this.label11);
            this.AddRoomTab1.Controls.Add(this.comboBoxType);
            this.AddRoomTab1.Controls.Add(this.RoomNo_txt);
            this.AddRoomTab1.Controls.Add(this.label1);
            this.AddRoomTab1.Controls.Add(this.radioBtnNo);
            this.AddRoomTab1.Controls.Add(this.radioBtnYes);
            this.AddRoomTab1.Controls.Add(this.label2);
            this.AddRoomTab1.Controls.Add(this.btnAdd);
            this.AddRoomTab1.Controls.Add(this.label3);
            this.AddRoomTab1.Controls.Add(this.label5);
            this.AddRoomTab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoomTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AddRoomTab1.Location = new System.Drawing.Point(4, 4);
            this.AddRoomTab1.Name = "AddRoomTab1";
            this.AddRoomTab1.Padding = new System.Windows.Forms.Padding(3);
            this.AddRoomTab1.Size = new System.Drawing.Size(1159, 463);
            this.AddRoomTab1.TabIndex = 0;
            this.AddRoomTab1.Text = "Add Room";
            this.AddRoomTab1.Click += new System.EventHandler(this.AddRoomTab1_Click);
            // 
            // RoomPrice_txt
            // 
            this.RoomPrice_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.RoomPrice_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPrice_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomPrice_txt.ForeColor = System.Drawing.Color.White;
            this.RoomPrice_txt.Location = new System.Drawing.Point(803, 151);
            this.RoomPrice_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RoomPrice_txt.Name = "RoomPrice_txt";
            this.RoomPrice_txt.Size = new System.Drawing.Size(280, 30);
            this.RoomPrice_txt.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(798, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Room Price :            ";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.AddRoomTab1);
            this.tabControl1.Controls.Add(this.SearchNameTab);
            this.tabControl1.Controls.Add(this.UpdateAndDeleteRoomTab);
            this.tabControl1.Location = new System.Drawing.Point(26, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 492);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // UserControlRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name = "UserControlRooms";
            this.Size = new System.Drawing.Size(1285, 564);
            this.Load += new System.EventHandler(this.UserControlRooms_Load);
            this.UpdateAndDeleteRoomTab.ResumeLayout(false);
            this.UpdateAndDeleteRoomTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.SearchNameTab.ResumeLayout(false);
            this.SearchNameTab.PerformLayout();
            this.AddRoomTab1.ResumeLayout(false);
            this.AddRoomTab1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage UpdateAndDeleteRoomTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxRoomNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.TabPage SearchNameTab;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox RoomNo_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage AddRoomTab1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBoxRoomType1;
        private System.Windows.Forms.TextBox textBoxRoomNo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUpdate1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RoomPrice_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRoomPrice1;
        private System.Windows.Forms.Label label12;
    }
}
