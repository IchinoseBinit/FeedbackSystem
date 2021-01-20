using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackSystem
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
            showCriterias();
        }
        private List<Rating> myList = new List<Rating>();
        private string customerName;
        private string phoneNumber;
        private string emailAddress;
        private string foodQuality;
        private string staffFriendliness;
        private string ambiance;
        private string cleanliness;
        private string orderAccuracy;
        private string valueForMoney;


        private void ErrorDialog()
        {
            DialogResult res = MessageBox.Show("Please give a review", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private bool CheckInformation()
        {
            customerName = txtName.Text;
            phoneNumber = txtPhone.Text;
            emailAddress = txtEmail.Text;
            if (customerName == "" && phoneNumber == "" && emailAddress == "")
            {
                MessageBox.Show("Please Enter Name, Phone and Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (customerName == "")
            {
                MessageBox.Show("Please Enter Your Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (phoneNumber == "")
            {
                MessageBox.Show("Please Enter Your Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            else if (emailAddress == "")
            {
                MessageBox.Show("Please Enter Your Email Address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            /*comboFoodQuality.Text = "";
            comboStaffFriendliness.Text = "";
            comboAmbiance.Text = "";
            comboCleanliness.Text = "";
            comboOrderAccuracy.Text = "";
            comboValueForMoney.Text = "";*/
            customerName = "";
            phoneNumber = "";
            emailAddress = "";
            foodQuality = "";
            staffFriendliness = "";
            ambiance = "";
            cleanliness = "";
            orderAccuracy = "";
            valueForMoney = "";
        }


        private void showCriterias()
        {
            List<string[]> rows = Utility.GetFiles();
            string[] criteriaNames = rows[0];

            int tabIndex = 6;
            int lblHeight = 207;
            int cmboHeight = 202;
            for(int i=3; i<criteriaNames.Length; i++)
            {
                Label obj = new Label();
                obj.AutoSize = true;
                obj.Location = new System.Drawing.Point(136, lblHeight);
                obj.Name = "txt"+criteriaNames[i];
                obj.Size = new System.Drawing.Size(46, 17);
                obj.TabIndex = tabIndex;
                obj.Text = criteriaNames[i] + ":";
                Controls.Add(obj);
                lblHeight = lblHeight+40;
                
                tabIndex++;

                ComboBox newCombo = new ComboBox();
                newCombo.FormattingEnabled = true;
                newCombo.Location = new System.Drawing.Point(263, cmboHeight);
                newCombo.Name = "cmbo"+ criteriaNames[i];
                newCombo.Size = new System.Drawing.Size(160, 24);
                newCombo.TabIndex = tabIndex;
                Controls.Add(newCombo);
                cmboHeight = cmboHeight + 40;
                tabIndex++;
            }

            
            btnSubmit.Location = new System.Drawing.Point(420, cmboHeight + 10);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(107, 42);
            btnSubmit.TabIndex = tabIndex;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            tabIndex++;

            
            btnBack.Location = new System.Drawing.Point(35, cmboHeight + 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(107, 42);
            btnBack.TabIndex = tabIndex;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            cmboHeight = cmboHeight + 40;

            ClientSize = new System.Drawing.Size(580, cmboHeight+40);

        }


       /* private void btnNextFoodQuality_Click(object sender, EventArgs e)
        {
            if (CheckInformation()) { 
                foodQuality = comboFoodQuality.Text;
                if (foodQuality != "")
                {
                    guestTab.SelectTab("tabPageStaffFriendliness");
                }
                else
                {
                    ErrorDialog();
                    comboFoodQuality.Focus();
                }
            }
        }   

        private void btnNextStaff_Click(object sender, EventArgs e)
        {
            if (CheckInformation())
            {
                staffFriendliness = comboStaffFriendliness.Text;
                if (staffFriendliness != "")
                {
                    guestTab.SelectTab("tabPageCleanliness");
                }
                else
                {
                    ErrorDialog();
                    comboStaffFriendliness.Focus();
                }
            }
        }

        private void btnNextCleanliness_Click(object sender, EventArgs e)
        {
            if (CheckInformation())
            {
                cleanliness = comboCleanliness.Text;
                if (cleanliness != "")
                {
                    guestTab.SelectTab("tabPageOrderAccuracy");
                }
                else
                {
                    ErrorDialog();
                    comboCleanliness.Focus();
                }
            }
        }

        private void btnNextOrderAccuracy_Click(object sender, EventArgs e)
        {
            if (CheckInformation())
            {
                orderAccuracy = comboOrderAccuracy.Text;
                if (orderAccuracy != "")
                {
                    guestTab.SelectTab("tabPageAmbiance");
                }
                else
                {
                    ErrorDialog();
                    comboOrderAccuracy.Focus();
                }
            }
        }

        private void btnNextAmbiance_Click(object sender, EventArgs e)
        {
            if (CheckInformation())
            {
                ambiance = comboAmbiance.Text;
                if (ambiance != "")
                {
                    guestTab.SelectTab("tabPageValue");
                }
                else
                {
                    ErrorDialog();
                    comboAmbiance.Focus();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckInformation())
            {
                valueForMoney = comboValueForMoney.Text;
                if (valueForMoney != "")
                {
                    myList.Add(new Rating(customerName, phoneNumber, emailAddress, foodQuality, staffFriendliness, cleanliness, orderAccuracy, ambiance, valueForMoney));
                    string details = customerName + "," + phoneNumber + "," + emailAddress + "," + foodQuality + "," + staffFriendliness + "," + cleanliness + "," + orderAccuracy + "," + ambiance + "," + valueForMoney + "\n";
                    WriteToFile(details);
                    Clear();
                    DialogResult suc = MessageBox.Show("Thanks for giving the Feedback \nYour response has been recorded", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ErrorDialog();
                    comboValueForMoney.Focus();
                }
            }
            // Write code to submit and save in csv
        }

        private void btnBackStaff_Click(object sender, EventArgs e)
        {
            guestTab.SelectTab("tabPageFoodQuality");
        }


        private void btnBackOrderAccuracy_Click(object sender, EventArgs e)
        {
            guestTab.SelectTab("tabPageCleanliness");
        }

        private void btnBackAmbiance_Click(object sender, EventArgs e)
        {
            guestTab.SelectTab("tabPageOrderAccuracy");
        }

        private void btnBackValueForMoney_Click(object sender, EventArgs e)
        {
            guestTab.SelectTab("tabPageAmbiance");
        }

        private void btnBackCleanliness_Click(object sender, EventArgs e)
        {
            guestTab.SelectTab("tabPageStaffFriendliness");
        }*/
    }
}
