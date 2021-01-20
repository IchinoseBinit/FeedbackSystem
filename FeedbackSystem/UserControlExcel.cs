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
        public UserControlExcel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        private void loadExcel()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSVFiles|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /**//*String name = "file1";*/
                string file = Application.StartupPath + openFileDialog1.FileName;
                string csvFile = Path.Combine(Application.StartupPath + "//file1.csv");
                List<string[]> rows = File.ReadAllLines(csvFile).Select(x => x.Split(',')).ToList();

                //create a new function with following code
                int length = rows[0].Length;
                DataGridViewTextBoxColumn[] newGridViewList = new DataGridViewTextBoxColumn[length];
                for (int i = 0; i < rows[0].Length; i++)
                {
                    newGridViewList[i] = new DataGridViewTextBoxColumn();
                }


                //Datagridview table object name => employeeRecordTable
                //creating by adding datagridview in your UI form.
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
                    for (int j = 0; j < feedbackGridView.Columns.Count; j++)
                    {
                        if (i == 0)
                        {
                            feedbackGridView.Columns[j].Name = rows[i][j];
                        }
                        else
                        {
                            feedbackGridView.Rows[index].Cells[j].Value = rows[i][j];
                        }
                    }

                }
                rows.ForEach(x =>
                {
                    //add value to getter/setter method before adding to datagridview row;
                    //SerializationClass abc = new SerializationClass(id, name, address, contact, email);

                    //now add the value to datagridview => employeeRecordTable.
                });
            }
            /* OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSVFiles|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
             * 
             * String name = "file1";
            string file = Application.StartupPath + "\\file1.csv";
            String pathToFile = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + file + ";Extended Properties = \"text;HDR=Yes;FMT=Delimited\"";

            OleDbConnection con = new OleDbConnection(pathToFile);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data; */
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            loadExcel();
        }
    }

    
}
