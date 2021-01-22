
namespace FeedbackSystem
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnCriteria = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.panelExcelData = new System.Windows.Forms.Panel();
            this.lblGoToGuestForm = new System.Windows.Forms.Label();
            this.userControlExcel = new FeedbackSystem.UserControlExcel();
            this.userControlCriteria = new FeedbackSystem.UserControlCriteria();
            this.userControlChart = new FeedbackSystem.UserControlChart();
            this.panelNavigation.SuspendLayout();
            this.panelExcelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Teal;
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.btnCriteria);
            this.panelNavigation.Controls.Add(this.btnExcel);
            this.panelNavigation.Controls.Add(this.btnChart);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(213, 448);
            this.panelNavigation.TabIndex = 0;
            // 
            // btnCriteria
            // 
            this.btnCriteria.BackColor = System.Drawing.Color.White;
            this.btnCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteria.Location = new System.Drawing.Point(33, 135);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(131, 38);
            this.btnCriteria.TabIndex = 2;
            this.btnCriteria.Text = "Criteria";
            this.btnCriteria.UseVisualStyleBackColor = false;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(33, 227);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(131, 38);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.White;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(33, 322);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(131, 38);
            this.btnChart.TabIndex = 0;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // panelExcelData
            // 
            this.panelExcelData.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelExcelData.Controls.Add(this.lblGoToGuestForm);
            this.panelExcelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExcelData.Location = new System.Drawing.Point(213, 0);
            this.panelExcelData.Name = "panelExcelData";
            this.panelExcelData.Size = new System.Drawing.Size(1250, 68);
            this.panelExcelData.TabIndex = 1;
            // 
            // lblGoToGuestForm
            // 
            this.lblGoToGuestForm.AutoSize = true;
            this.lblGoToGuestForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToGuestForm.ForeColor = System.Drawing.Color.White;
            this.lblGoToGuestForm.Location = new System.Drawing.Point(987, 24);
            this.lblGoToGuestForm.Name = "lblGoToGuestForm";
            this.lblGoToGuestForm.Size = new System.Drawing.Size(190, 25);
            this.lblGoToGuestForm.TabIndex = 0;
            this.lblGoToGuestForm.Text = "Go To Guest Form";
            this.lblGoToGuestForm.Click += new System.EventHandler(this.lblGoToGuestForm_Click);
            // 
            // userControlExcel
            // 
            this.userControlExcel.Location = new System.Drawing.Point(213, 0);
            this.userControlExcel.Name = "userControlExcel";
            this.userControlExcel.Size = new System.Drawing.Size(1250, 448);
            this.userControlExcel.TabIndex = 3;
            // 
            // userControlCriteria
            // 
            this.userControlCriteria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlCriteria.Location = new System.Drawing.Point(217, 12);
            this.userControlCriteria.Name = "userControlCriteria";
            this.userControlCriteria.Size = new System.Drawing.Size(1246, 436);
            this.userControlCriteria.TabIndex = 2;
            // 
            // userControlChart
            // 
            this.userControlChart.Location = new System.Drawing.Point(213, 40);
            this.userControlChart.Name = "userControlChart";
            this.userControlChart.Size = new System.Drawing.Size(1250, 408);
            this.userControlChart.TabIndex = 4;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 448);
            this.Controls.Add(this.panelExcelData);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.userControlExcel);
            this.Controls.Add(this.userControlCriteria);
            this.Controls.Add(this.userControlChart);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panelNavigation.ResumeLayout(false);
            this.panelExcelData.ResumeLayout(false);
            this.panelExcelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelExcelData;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.Label lblGoToGuestForm;
        private UserControlCriteria userControlCriteria;
        private UserControlExcel userControlExcel;
        private UserControlChart userControlChart;
    }
}