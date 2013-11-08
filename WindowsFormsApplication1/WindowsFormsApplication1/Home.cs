using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home_form : Form
    {
        public Home_form()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            booking_form booking = new booking_form();
            booking.Show();
            this.Hide();
           //this.Dispose();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void createBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
