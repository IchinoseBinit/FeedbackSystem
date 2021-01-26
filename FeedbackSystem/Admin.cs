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
        /*
         * The constructor of the Admin class.
         * Initializes the UI components and sets the UserControlCriteria Visibility to true
         */
        public Admin()
        {
            InitializeComponent();
            userControlExcel.Visible = false;
            userControlChart.Visible = false;
            userControlCriteria.Visible = true;
            btnCriteria.Focus();
        }

        /*
         * This method shows the Chart User Control.
         * The method hides all other User Control instances.
         */
        private void btnChart_Click(object sender, EventArgs e)
        {

            if (UserControlExcel.feedbackGridView.Rows.Count != 0)
            {
                userControlExcel.Visible = false;
                userControlCriteria.Visible = false;
                userControlChart.LoadChart();
                userControlChart.Visible = true;
            }
            else
            {
                MessageBox.Show("Please import a file before Sorting", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /*
         * This method shows the Excel User Control.
         * The method hides all other User Control instances.
         */
        private void btnExcel_Click(object sender, EventArgs e)
        {
            userControlExcel.Visible = true;
            userControlChart.Visible = false;
            userControlCriteria.Visible = false;
        }

        /*
         * This method shows the Criteria User Control.
         * The method hides all other User Control instances.
         */
        private void btnCriteria_Click(object sender, EventArgs e)
        {
            userControlCriteria.LoadCriteriaNames();
            userControlCriteria.Visible = true;
            userControlExcel.Visible = false;
            userControlChart.Visible = false;
        }

        /*
         * This method shows the compares whether the criteria of the file is same or changed.
         * If changed, the file is written with new headers.
         * The guest form is loaded with the new criterias.
         */
        private void lblGoToGuestForm_Click(object sender, EventArgs e)
        {
            if (UserControlCriteria.ShouldRewrite())
            {
                Console.WriteLine("Writing to a file");
                Utility.CopyFiles(Application.StartupPath);
                Utility.CreateFile(Application.StartupPath, UserControlCriteria.newCriteriaNames.ToArray());
                userControlCriteria.LoadCriteriaNames();
            }
            this.Hide();
            /*Creating a new instance of the GuestForm and calling its show method*/
            (new GuestForm()).Show();
        }
    }
}
