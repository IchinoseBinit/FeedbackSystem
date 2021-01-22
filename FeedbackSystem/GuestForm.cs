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
using System.Text.RegularExpressions;

namespace FeedbackSystem
{
    public partial class GuestForm : Form
    {
        /*
         * The constructor calls the method to build primary UI elements.
         * Similarly, ShowCriterias method loads the necessary criteria dynamically.
         */
        public GuestForm()
        {
            InitializeComponent();
            ShowCriterias();
        }
        private string customerName;
        private string phoneNumber;
        private string emailAddress;
        private List<ComboBox> comboList = new List<ComboBox>();
        private List<string> ratings = new List<string>();

        /*
         * This method is used to validate the user input.
         * The method returns true or false.
         * If all the conditions are validated, the method returns true and false if not validated.
         */
        private bool CheckInformation()
        {
            customerName = txtName.Text.Trim();
            phoneNumber = txtPhone.Text.Trim();
            emailAddress = txtEmail.Text.Trim();
            long a;
            string emailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string customerPattern = @"\b([A-Za-y][-,a-z. ']+[ ]*)+\b([A-Za-y][-,a-z. ']+[ ]*)+";
            string phonePattern = @"[0-9]{8,13}";

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
            else if (!Regex.IsMatch(customerName, customerPattern))
            {
                MessageBox.Show("Please Enter Your Proper Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            else if (phoneNumber == "")
            {
                MessageBox.Show("Please Enter Your Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            else if (!long.TryParse(phoneNumber, out a))
            {
                MessageBox.Show("Please Enter Numeric Value in Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            else if (!Regex.IsMatch(phoneNumber, phonePattern))
            {
                MessageBox.Show("Please Your 10 digit Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            else if (emailAddress == "")
            {
                MessageBox.Show("Please Enter Your Email Address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (!Regex.IsMatch(emailAddress, emailPattern))
            {
                MessageBox.Show("Please Enter a Valid Email Address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            foreach (ComboBox cmboBox in comboList)
            {
                if (cmboBox.Text == "Select a rating")
                {
                    MessageBox.Show("Please Give a Rating for " + cmboBox.Name, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmboBox.Focus();
                    return false;
                }
                else
                {
                    string control = ((KeyValuePair<string, int>)cmboBox.SelectedItem).Value.ToString();
                    ratings.Add(control);
                }
            }
            return true;
        }

        /*
         * This method clears the text boxes and the combo boxes.
         * It also clears the ratings list.
         */
        private void Clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            foreach (ComboBox cmb in comboList)
            {
                cmb.SelectedIndex=0;
            }
            ratings.Clear();
        }

        /*
         * This method loads the combo box dynamically to the frame.
         * It reads from the file and then loads the dynamic combo boxes.
         */
        private void ShowCriterias()
        {
            List<string[]> rows = Utility.GetFiles();
            string[] criteriaNames = rows[0];

            int tabIndex = 6;
            int lblHeight = 207;
            int cmboHeight = 207;

            
            Dictionary<string, int> pointsDictionary = new Dictionary<string, int>();
            pointsDictionary.Add("Select a rating", 0);
            pointsDictionary.Add("Bad", 1);
            pointsDictionary.Add("Satisfactory", 2);
            pointsDictionary.Add("Good", 3);
            pointsDictionary.Add("Excellent", 4);
            pointsDictionary.Add("Outstanding", 5);
            

            for (int i=4; i<criteriaNames.Length; i++)
            {
                Label obj = new Label();
                obj.AutoSize = true;
                obj.Location = new System.Drawing.Point(116, lblHeight);
                obj.Name = "txt"+criteriaNames[i];
                obj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                obj.Size = new System.Drawing.Size(46, 17);
                obj.TabIndex = tabIndex;
                obj.Text = criteriaNames[i] + ":";
                Controls.Add(obj);
                lblHeight = lblHeight+50;
                
                tabIndex++;

                ComboBox newCombo = new ComboBox();
                newCombo.FormattingEnabled = true;
                newCombo.Location = new System.Drawing.Point(283, cmboHeight);
                newCombo.Name = criteriaNames[i];
                newCombo.Size = new System.Drawing.Size(160, 24);
                newCombo.TabIndex = tabIndex;
                newCombo.DataSource = new BindingSource(pointsDictionary, null);
                newCombo.ValueMember = "Value";
                newCombo.DisplayMember = "Key";
                newCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                Controls.Add(newCombo);
                comboList.Add(newCombo);
                cmboHeight = cmboHeight + 50;
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

        /*
         * This method shows the Admin Login Page.
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            (new AdminLogin()).Show();
            this.Hide();
        }

        /*
         * This method checks for all the validations by calling the CheckInformation method.
         * Then the object is created and file is written through serialization.
         * After the file is written, a success message is shown and the Clear method is callled.
         */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckInformation())
            {
                Rating obj = new Rating(customerName, phoneNumber, emailAddress, ratings.ToArray(), DateTime.Now.ToString());
                Utility.WriteToFile(Application.StartupPath, CreateArray(obj));
                MessageBox.Show("Thanks for giving the Feedback \nYour response has been recorded", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        /*
         * This method returns a string array and takes an instance of the Rating object
         * The method adds all the value of the object to the list
         * Then, the list is converted to array and returned.
         */
        private string[] CreateArray(Rating obj)
        {
            List<string> newArray = new List<string>();
            newArray.Add(obj.CustomerName);
            newArray.Add(obj.PhoneNumber);
            newArray.Add(obj.EmailAddress);
            newArray.Add(obj.SavedDate);
            foreach (string s in obj.Ratings)
            {
                newArray.Add(s);
            }
            return newArray.ToArray();
        }
    }
}
