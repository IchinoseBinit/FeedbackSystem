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

namespace FeedbackSystem
{
    public partial class UserControlCriteria : UserControl
    {
        private int index = 0;
        private static List<string[]> rows = Utility.GetFiles();
        public static List<string> newCriteriaNames;

        public UserControlCriteria()
        {
            InitializeComponent();
            loadCriteriaNames();
            newCriteriaNames = rows[0].ToList(); 
        }

        public static Boolean ShouldRewrite()
        {
            string[] newCriteriaArray = newCriteriaNames.ToArray();
            if (newCriteriaArray.SequenceEqual(rows[0]))
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string newCriteria = txtCriteriaName.Text;
            if (newCriteria != "")
            {
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

        private void loadCriteriaNames()
        {           
            string[] criteriaNames = rows[0];
            int length = criteriaNames.Length;

            criteriaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            criteriaGridView.Columns.Add(new DataGridViewTextBoxColumn());

            criteriaGridView.Columns[0].Name = "Crtierias";
            int i = 0;
            for (int j = 3; j < length; j++)
            {
                index = criteriaGridView.Rows.Add();
                criteriaGridView.Rows[i].Cells[0].Value = criteriaNames[j];
                i++;
            }
        }

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
