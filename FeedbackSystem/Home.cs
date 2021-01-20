using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            (new AdminLogin()).Show();
            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            (new GuestForm()).Show();
            this.Hide();
        }
    }
}
