
namespace FeedbackSystem
{
    partial class UserControlChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartFeedback = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.chartFeedback);
            this.panelChart.Location = new System.Drawing.Point(0, 3);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1256, 451);
            this.panelChart.TabIndex = 0;
            // 
            // chartFeedback
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFeedback.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFeedback.Legends.Add(legend1);
            this.chartFeedback.Location = new System.Drawing.Point(36, 42);
            this.chartFeedback.Name = "chartFeedback";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Points";
            this.chartFeedback.Series.Add(series1);
            this.chartFeedback.Size = new System.Drawing.Size(1187, 356);
            this.chartFeedback.TabIndex = 0;
            this.chartFeedback.Text = "chartFeedback";
            // 
            // UserControlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChart);
            this.Name = "UserControlChart";
            this.Size = new System.Drawing.Size(1256, 451);
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFeedback;
    }
}
