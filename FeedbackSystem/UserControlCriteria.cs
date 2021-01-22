using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FeedbackSystem
{
    public partial class UserControlCriteria : UserControl
    {
        private int index = 0;
        public static List<string[]> rows = Utility.GetFiles();
        public static List<string> newCriteriaNames;

        /*
         * This constructor calls the LoadCriteriaNames method after the components is initialized.
         */
        public UserControlCriteria()
        {
            InitializeComponent();
            LoadCriteriaNames();
        }

        /*
         * This method returns true or false based on condition.
         * If the criterias values are changed, the method returns true.
         * If the criterias values are unchanged, the method returns false.
         */
        public static Boolean ShouldRewrite()
        {
            string[] newCriteriaArray = newCriteriaNames.ToArray();
            if (newCriteriaArray.SequenceEqual(rows[0]))
            {
                return false;
            }
            return true;
        }

        /*
         * The method adds the criteria value to the list.
         * If the criterias are less than 8, it allows the addition of criteria.
         * Validations are performed using Regex and if the validations are matched, the criteria is added to the list.
         * If the criteria value already matches with the value in list, the criteria is not added.
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (newCriteriaNames.Count-4 > 7)
            {
                MessageBox.Show("Cannot Add more than 7 criterias", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDelete.Focus();
                return;
            }
            string criteriaPattern = @"\b([A-Za-y]{4,5})+";
            string newCriteria = txtCriteriaName.Text.Trim();
            if (newCriteria != "")
            {
                if (!Regex.IsMatch(newCriteria, criteriaPattern))
                {
                    MessageBox.Show("Please Enter a Proper Criteria Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCriteriaName.Focus();
                    return;
                }
                foreach (string name in newCriteriaNames)
                {
                    if (newCriteria == name)
                    {
                        MessageBox.Show("Criteria Already Exists!\nPlease add another Criteria Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCriteriaName.Focus();
                        return;
                    }
                }
                index = criteriaGridView.Rows.Add();
                criteriaGridView.Rows[index].Cells[0].Value = newCriteria;
                newCriteriaNames.Add(newCriteria);
            }
            else
            {
                MessageBox.Show("Please Enter The Criteria Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCriteriaName.Focus();
            }
        }

        /*
         * The method loads the criteria value to the DataGridView.
         * The first row of the file is read and initialized in the list.
         * Then, the rows are added in the DataGridView with the names of criteria from list.
         * The first 4 values are not shown as they are same always.
         */
        public void LoadCriteriaNames()
        {
            newCriteriaNames = rows[0].ToList();
            string[] criteriaNames = rows[0];
            int length = criteriaNames.Length;

            criteriaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            criteriaGridView.Columns.Add(new DataGridViewTextBoxColumn());

            criteriaGridView.Columns[0].Name = "Crtierias";
            criteriaGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            int i = 0;
            for (int j = 4; j < length-1; j++)
            {
                index = criteriaGridView.Rows.Add();
                criteriaGridView.Rows[i].Cells[0].Value = criteriaNames[j];
                i++;
            }
        }

        /*
         * The method deletes the selected row.
         * If there are no criterias displayed, the program prompts the user.
         * Else, the selected row is deleted.
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (criteriaGridView.Rows.Count == 1)
                {
                    MessageBox.Show("Please Add a Criteria Name First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (criteriaGridView.SelectedRows.Count > 0)
                {
                    int rowId = criteriaGridView.SelectedRows[0].Index;
                    criteriaGridView.Rows.RemoveAt(rowId);
                    newCriteriaNames.RemoveAt(rowId + 3);
                }
                else
                {
                    MessageBox.Show("Please Select a Criteria Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    criteriaGridView.Focus();
                    return;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Please Select a Criteria Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                criteriaGridView.Focus();
                return;
            }
        }
    }
}
