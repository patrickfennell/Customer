namespace WindowsFormsApplication1
{
    partial class booking_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_Pickup = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Collection = new System.Windows.Forms.Label();
            this.lbl_Return = new System.Windows.Forms.Label();
            this.manual_adioButton = new System.Windows.Forms.RadioButton();
            this.auto_RadioButton = new System.Windows.Forms.RadioButton();
            this.coll_Time = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Rental = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choose_All = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "Home";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(171, 157);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 2;
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Location = new System.Drawing.Point(171, 198);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDatePicker.TabIndex = 3;
            // 
            // lbl_Pickup
            // 
            this.lbl_Pickup.AutoSize = true;
            this.lbl_Pickup.Location = new System.Drawing.Point(69, 109);
            this.lbl_Pickup.Name = "lbl_Pickup";
            this.lbl_Pickup.Size = new System.Drawing.Size(84, 13);
            this.lbl_Pickup.TabIndex = 4;
            this.lbl_Pickup.Text = "Pickup Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lbl_Collection
            // 
            this.lbl_Collection.AutoSize = true;
            this.lbl_Collection.Location = new System.Drawing.Point(69, 160);
            this.lbl_Collection.Name = "lbl_Collection";
            this.lbl_Collection.Size = new System.Drawing.Size(77, 13);
            this.lbl_Collection.TabIndex = 6;
            this.lbl_Collection.Text = "Colection Date";
            this.lbl_Collection.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_Return
            // 
            this.lbl_Return.AutoSize = true;
            this.lbl_Return.Location = new System.Drawing.Point(69, 199);
            this.lbl_Return.Name = "lbl_Return";
            this.lbl_Return.Size = new System.Drawing.Size(65, 13);
            this.lbl_Return.TabIndex = 7;
            this.lbl_Return.Text = "Return Date";
            this.lbl_Return.Click += new System.EventHandler(this.lbl_Return_Click);
            // 
            // manual_adioButton
            // 
            this.manual_adioButton.AutoSize = true;
            this.manual_adioButton.Location = new System.Drawing.Point(72, 254);
            this.manual_adioButton.Name = "manual_adioButton";
            this.manual_adioButton.Size = new System.Drawing.Size(114, 17);
            this.manual_adioButton.TabIndex = 10;
            this.manual_adioButton.TabStop = true;
            this.manual_adioButton.Text = "Show Manual Only";
            this.manual_adioButton.UseVisualStyleBackColor = true;
            // 
            // auto_RadioButton
            // 
            this.auto_RadioButton.AutoSize = true;
            this.auto_RadioButton.Location = new System.Drawing.Point(222, 251);
            this.auto_RadioButton.Name = "auto_RadioButton";
            this.auto_RadioButton.Size = new System.Drawing.Size(126, 17);
            this.auto_RadioButton.TabIndex = 11;
            this.auto_RadioButton.TabStop = true;
            this.auto_RadioButton.Text = "Show Automatic Only";
            this.auto_RadioButton.UseVisualStyleBackColor = true;
            // 
            // coll_Time
            // 
            this.coll_Time.FormattingEnabled = true;
            this.coll_Time.Items.AddRange(new object[] {
            "12.00",
            "12.30",
            "1.00",
            "1.30",
            "2.00",
            "2.30",
            "3.00",
            "3.30",
            "4.00",
            "4.30",
            "5.00",
            "5.30",
            "6.00",
            "6.30",
            "7.00",
            "7.30",
            "8.00",
            "8.30",
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "00.00"});
            this.coll_Time.Location = new System.Drawing.Point(412, 157);
            this.coll_Time.Name = "coll_Time";
            this.coll_Time.Size = new System.Drawing.Size(121, 21);
            this.coll_Time.TabIndex = 12;
            this.coll_Time.Text = "12.00";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "12.00",
            "12.30",
            "1.00",
            "1.30",
            "2.00",
            "2.30",
            "3.00",
            "3.30",
            "4.00",
            "4.30",
            "5.00",
            "5.30",
            "6.00",
            "6.30",
            "7.00",
            "7.30",
            "8.00",
            "8.30",
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "00.00"});
            this.comboBox2.Location = new System.Drawing.Point(412, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "12.00";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ireland  ",
            "Uk"});
            this.comboBox1.Location = new System.Drawing.Point(412, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Car hire from";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(458, 295);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_Rental
            // 
            this.lbl_Rental.AutoSize = true;
            this.lbl_Rental.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rental.Location = new System.Drawing.Point(67, 40);
            this.lbl_Rental.Name = "lbl_Rental";
            this.lbl_Rental.Size = new System.Drawing.Size(209, 25);
            this.lbl_Rental.TabIndex = 16;
            this.lbl_Rental.Text = "Car Rental System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Merc_Background;
            this.pictureBox1.Location = new System.Drawing.Point(387, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 73);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // choose_All
            // 
            this.choose_All.FormattingEnabled = true;
            this.choose_All.Items.AddRange(new object[] {
            "Class A",
            "Class B",
            "Class C",
            "Execetive",
            "Mpv",
            "Suv"});
            this.choose_All.Location = new System.Drawing.Point(412, 250);
            this.choose_All.Name = "choose_All";
            this.choose_All.Size = new System.Drawing.Size(121, 21);
            this.choose_All.TabIndex = 18;
            this.choose_All.Text = "Choose All";
            // 
            // booking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(589, 350);
            this.Controls.Add(this.choose_All);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Rental);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.coll_Time);
            this.Controls.Add(this.auto_RadioButton);
            this.Controls.Add(this.manual_adioButton);
            this.Controls.Add(this.lbl_Return);
            this.Controls.Add(this.lbl_Collection);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Pickup);
            this.Controls.Add(this.returnDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "booking_form";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker returnDatePicker;
        private System.Windows.Forms.Label lbl_Pickup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Collection;
        private System.Windows.Forms.Label lbl_Return;
        private System.Windows.Forms.RadioButton manual_adioButton;
        private System.Windows.Forms.RadioButton auto_RadioButton;
        private System.Windows.Forms.ComboBox coll_Time;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Rental;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox choose_All;
    }
}