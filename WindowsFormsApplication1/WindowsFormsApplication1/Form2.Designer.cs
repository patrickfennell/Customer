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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exetativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.enterBookingIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_updateCancel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carsToolStripMenuItem,
            this.hatchbackToolStripMenuItem,
            this.suvToolStripMenuItem,
            this.seaterToolStripMenuItem,
            this.exetativeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "Cars";
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.carsToolStripMenuItem.Text = "Saloon";
            // 
            // hatchbackToolStripMenuItem
            // 
            this.hatchbackToolStripMenuItem.Name = "hatchbackToolStripMenuItem";
            this.hatchbackToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.hatchbackToolStripMenuItem.Text = "Hatchback";
            // 
            // suvToolStripMenuItem
            // 
            this.suvToolStripMenuItem.Name = "suvToolStripMenuItem";
            this.suvToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.suvToolStripMenuItem.Text = "Suv";
            // 
            // seaterToolStripMenuItem
            // 
            this.seaterToolStripMenuItem.Name = "seaterToolStripMenuItem";
            this.seaterToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.seaterToolStripMenuItem.Text = "7 Seater";
            // 
            // exetativeToolStripMenuItem
            // 
            this.exetativeToolStripMenuItem.Name = "exetativeToolStripMenuItem";
            this.exetativeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exetativeToolStripMenuItem.Text = "Exetative";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterBookingIdToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "Home";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // enterBookingIdToolStripMenuItem
            // 
            this.enterBookingIdToolStripMenuItem.Name = "enterBookingIdToolStripMenuItem";
            this.enterBookingIdToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.enterBookingIdToolStripMenuItem.Text = "Enter Booking Id";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem3.Text = "Login";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Car1;
            this.pictureBox1.Location = new System.Drawing.Point(159, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 316);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_updateCancel
            // 
            this.lbl_updateCancel.AutoSize = true;
            this.lbl_updateCancel.LinkColor = System.Drawing.Color.Black;
            this.lbl_updateCancel.Location = new System.Drawing.Point(50, 81);
            this.lbl_updateCancel.Name = "lbl_updateCancel";
            this.lbl_updateCancel.Size = new System.Drawing.Size(122, 13);
            this.lbl_updateCancel.TabIndex = 3;
            this.lbl_updateCancel.TabStop = true;
            this.lbl_updateCancel.Text = "Cancel/Update Booking";
            // 
            // booking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 496);
            this.Controls.Add(this.lbl_updateCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exetativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem enterBookingIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_updateCancel;
    }
}