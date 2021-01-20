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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            /*userControlExcel.Visible = false;
            userControlChart.Visible = false;
            userControlCriteria.Visible = true;*/
        }


        private void btnChart_Click(object sender, EventArgs e)
        {
            /*userControlExcel.Visible = false;
            userControlCriteria.Visible = false;
            userControlChart.Visible = true;*/
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            /*userControlExcel.Visible = true;
            userControlChart.Visible = false;
            userControlCriteria.Visible = false;*/
        }

        private void btnCriteria_Click(object sender, EventArgs e)
        {
            /*userControlCriteria.Visible = true;
            userControlExcel.Visible = false;
            userControlChart.Visible = false;*/
        }

        private void lblGoToGuestForm_Click(object sender, EventArgs e)
        {
            if (UserControlCriteria.ShouldRewrite())
            {
                Console.WriteLine("Writing to a file");
                Utility.CreateFile(Application.StartupPath, UserControlCriteria.newCriteriaNames.ToArray());
            }
            this.Hide();
            (new GuestForm()).Show();
        }
    }
}
