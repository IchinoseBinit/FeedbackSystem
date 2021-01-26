using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace FeedbackSystem
{
    public partial class UserControlExcel : UserControl
    {
        public static List<string[]> rows;
        public UserControlExcel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// 

        /*
        * This method clears all the values in DataGridView.
        */
        public void ClearDataGridView()
        {
            feedbackGridView.Rows.Clear();
            feedbackGridView.Columns.Clear();
        }

        /*
         * This method loads the value of the CSV file to the DataGridView.
         * The file is selected using the OpenFileDialog.
         * Then, the file is loaded into a generic list of string array.
         * The DataGridView loads the value from the list using the for loop.
         * Then the count of the review is calculated and displayed in the label.
         */
        private void LoadExcel()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "CSVFiles|*.csv";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    /**//*String name = "file1";*/
                    ClearDataGridView();
                    string file = openFileDialog1.FileName;
                    string csvFile = Path.Combine(Application.StartupPath + "//file1.csv");
                    rows = File.ReadAllLines(file).Select(x => x.Split(',')).ToList();

                    int length = rows[0].Length;

                    DataGridViewTextBoxColumn[] newGridViewList = new DataGridViewTextBoxColumn[length];
                    for (int i = 0; i < rows[0].Length; i++)
                    {
                        newGridViewList[i] = new DataGridViewTextBoxColumn();
                    }

                    foreach (DataGridViewTextBoxColumn x in newGridViewList)
                    {
                        feedbackGridView.Columns.Add(x);
                    }

                    for (int i = 0; i < rows.Count; i++)
                    {
                        int index = 0;
                        if (i > 0)
                        {
                            index = feedbackGridView.Rows.Add();
                        }
                        string customerName = "";
                        string phoneNumber = "";
                        string emailAddress = "";
                        List<string> ratings = new List<string>();
                        string savedDate = "";

                        for (int j = 0; j < feedbackGridView.Columns.Count; j++)
                        {
                            if (i == 0)
                            {
                                if (j > 3 && j < feedbackGridView.Columns.Count)
                                {
                                    comboBoxSort.Items.Add(rows[i][j]);
                                }
                                feedbackGridView.Columns[j].Name = rows[i][j];
                                if (feedbackGridView.Columns.Count < 9)
                                {
                                    feedbackGridView.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }
                                else
                                {
                                    feedbackGridView.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                }
                            }
                            else
                            {
                                if (j == 0)
                                {
                                    customerName = rows[i][j];
                                    feedbackGridView.Rows[index].Cells[j].Value = customerName;
                                }
                                else if (j == 1)
                                {
                                    phoneNumber = rows[i][j];
                                    feedbackGridView.Rows[index].Cells[j].Value = phoneNumber;
                                }
                                else if (j == 2)
                                {
                                    emailAddress = rows[i][j];
                                    feedbackGridView.Rows[index].Cells[j].Value = emailAddress;
                                }
                                else if (j == 3)
                                {
                                    savedDate = rows[i][j];
                                    feedbackGridView.Rows[index].Cells[j].Value = savedDate;
                                }
                                else if (j > 3 && j < feedbackGridView.Columns.Count)
                                {
                                    string rate = rows[i][j];
                                    try
                                    {
                                        int a = Int32.Parse(rate);
                                        feedbackGridView.Rows[index].Cells[j].Value = a;
                                        ratings.Add(rate);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Cant Read the file, Ratings should be in between 1 to 5", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        ClearDataGridView();
                                        lblNoOfCount.Visible = false;
                                        lblReviewsCount.Visible = false;
                                        return;
                                    }
                                }
                            }
                        }
                        lblReviewsCount.Text = feedbackGridView.Rows.Count.ToString();
                        lblNoOfCount.Visible = true;
                        lblReviewsCount.Visible = true;
                        comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /*
         * This method calls the LoadExcel.
         */
        private void btnImport_Click(object sender, EventArgs e)
        {
            LoadExcel();
        }

        /*
         * This method sorts the DataGridView according to the column value.
         * The sorted values are displayed in the DataGridView.
         * The method takes a generic list of string array and a index of the column.
         * The ClearDataGridView method is called to clear the DataGridView.
         * After the list is sorted, for loop is used to enter the value in the DataGridView.
         */
        private void Sort(List<string[]> compareList, int index)
        {
            {
                ClearDataGridView();
                string[] temp;
                int count = compareList.Count;

                for (int i=1; i< compareList.Count-1 ; i++)
                {
                    for (int j = i + 1; j < compareList.Count; j++)
                    {
                        if (Int32.Parse(compareList[i][index]) > Int32.Parse(compareList[j][index]))
                        {
                            temp = compareList[i];
                            compareList[i] = compareList[j];
                            compareList[j] = temp;
                        }
                    }
                }
                int length = rows[0].Length;

                DataGridViewTextBoxColumn[] newGridViewList = new DataGridViewTextBoxColumn[length];
                for (int i = 0; i < rows[0].Length; i++)
                {
                    newGridViewList[i] = new DataGridViewTextBoxColumn();
                }

                foreach (DataGridViewTextBoxColumn x in newGridViewList)
                {
                    feedbackGridView.Columns.Add(x);
                }
                int rowCount = 0;
                for (int i = 0; i < rows.Count; i++)
                {                    
                    if (i > 0)
                    {
                        rowCount = feedbackGridView.Rows.Add();
                    }

                    for (int j = 0; j < feedbackGridView.Columns.Count; j++)
                    {
                        if (i == 0)
                        {
                            feedbackGridView.Columns[j].Name = rows[i][j];
                        }
                        else
                        {                            
                            feedbackGridView.Rows[rowCount].Cells[j].Value = compareList[i][j];
                        }
                        if (feedbackGridView.Columns.Count < 9)
                        {
                            feedbackGridView.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        else
                        {
                            feedbackGridView.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }
            }
        
        }

        /*
         * This method calls the Sort method with list and index of the column.
         * It checks whether there is value in the DataGridView.
         * If the value is present, it calls the Sort method.
         * If the value is not present, it prompts the user to Import a CSV file.
         */
        private void btnSort_Click(object sender, EventArgs e)
        {
            if(comboBoxSort.Items.Count != 0)
            {
                if (comboBoxSort.SelectedItem != null)
                {
                    string criteria = comboBoxSort.SelectedItem.ToString();
                    int colId = 0;
                    for (int j = 0; j < feedbackGridView.Columns.Count; j++)
                    {
                        if (feedbackGridView.Columns[j].Name == criteria)
                        {
                            colId = j;
                            break;
                        }
                    }
                    Sort(rows, colId);
                }
                else
                {
                    MessageBox.Show("Please select a criteria to sort", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBoxSort.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please import a csv file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnImport.Focus();
                return;
            }
            
        }
    }

    }

