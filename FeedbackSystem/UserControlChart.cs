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
    public partial class UserControlChart : UserControl
    {
        /*
         * This constructor calls the LoadChart method after the components is initialized.
         */
        public UserControlChart()
        {
            InitializeComponent();
            LoadChart();
        }

        /*
         * This method loads the Chart according to the DataGridView.
         * The ratings of the criteria are counted and shown in a chart.
         * The chart increases with the number of ratings and criteria.
         */
        private void LoadChart()
        {
            DataGridView gridView = new DataGridView();
            /*DataGridView gridView = UserControlExcel.feedbackGridView;*/
            Dictionary<string, int> points= new Dictionary<string, int>();
            
            int sumOfColumn = 0;

            for (int i = 1; i < gridView.Columns.Count; i++)
            {
                for (int j = 0; j < gridView.Rows.Count; j++)
                {
                    sumOfColumn += Convert.ToInt32(gridView.Rows[j].Cells[i].Value);
                }
                string headerKey = gridView.Columns[i].HeaderText;
                points.Add(headerKey, sumOfColumn);
                sumOfColumn = 0;
            }
            foreach (KeyValuePair<string, int> sum in points)
            {
                chartFeedback.Series["Points"].Points.AddXY(sum.Key, sum.Value);
            }
        }
    }
}
