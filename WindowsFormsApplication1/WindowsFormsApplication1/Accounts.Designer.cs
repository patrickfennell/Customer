namespace WindowsFormsApplication1
{
    partial class Accounts
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.acc_lbl_From = new System.Windows.Forms.Label();
            this.acc_lbl_To = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // acc_lbl_From
            // 
            this.acc_lbl_From.AutoSize = true;
            this.acc_lbl_From.Location = new System.Drawing.Point(57, 64);
            this.acc_lbl_From.Name = "acc_lbl_From";
            this.acc_lbl_From.Size = new System.Drawing.Size(30, 13);
            this.acc_lbl_From.TabIndex = 8;
            this.acc_lbl_From.Text = "From";
            // 
            // acc_lbl_To
            // 
            this.acc_lbl_To.AutoSize = true;
            this.acc_lbl_To.Location = new System.Drawing.Point(57, 118);
            this.acc_lbl_To.Name = "acc_lbl_To";
            this.acc_lbl_To.Size = new System.Drawing.Size(20, 13);
            this.acc_lbl_To.TabIndex = 9;
            this.acc_lbl_To.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(655, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acc_lbl_To);
            this.Controls.Add(this.acc_lbl_From);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label acc_lbl_From;
        private System.Windows.Forms.Label acc_lbl_To;
        private System.Windows.Forms.Button button1;
    }
}