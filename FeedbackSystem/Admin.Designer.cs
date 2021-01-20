﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlCriteria2 = new FeedbackSystem.UserControlCriteria();
            this.userControlCriteria1 = new FeedbackSystem.UserControlCriteria();
            this.panelNavigation.SuspendLayout();
            this.panelExcelData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
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
            this.btnCriteria.Location = new System.Drawing.Point(33, 114);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(131, 38);
            this.btnCriteria.TabIndex = 2;
            this.btnCriteria.Text = "Criteria";
            this.btnCriteria.UseVisualStyleBackColor = true;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(33, 196);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(131, 38);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(33, 281);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(131, 38);
            this.btnChart.TabIndex = 0;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // panelExcelData
            // 
            this.panelExcelData.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelExcelData.Controls.Add(this.lblGoToGuestForm);
            this.panelExcelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExcelData.Location = new System.Drawing.Point(213, 0);
            this.panelExcelData.Name = "panelExcelData";
            this.panelExcelData.Size = new System.Drawing.Size(824, 68);
            this.panelExcelData.TabIndex = 1;
            // 
            // lblGoToGuestForm
            // 
            this.lblGoToGuestForm.AutoSize = true;
            this.lblGoToGuestForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToGuestForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGoToGuestForm.Location = new System.Drawing.Point(597, 25);
            this.lblGoToGuestForm.Name = "lblGoToGuestForm";
            this.lblGoToGuestForm.Size = new System.Drawing.Size(190, 25);
            this.lblGoToGuestForm.TabIndex = 0;
            this.lblGoToGuestForm.Text = "Go To Guest Form";
            this.lblGoToGuestForm.Click += new System.EventHandler(this.lblGoToGuestForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.userControlCriteria2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(213, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 380);
            this.panel1.TabIndex = 2;
            // 
            // userControlCriteria2
            // 
            this.userControlCriteria2.Location = new System.Drawing.Point(0, -43);
            this.userControlCriteria2.Name = "userControlCriteria2";
            this.userControlCriteria2.Size = new System.Drawing.Size(824, 497);
            this.userControlCriteria2.TabIndex = 0;
            // 
            // userControlCriteria1
            // 
            this.userControlCriteria1.Location = new System.Drawing.Point(0, -56);
            this.userControlCriteria1.Name = "userControlCriteria1";
            this.userControlCriteria1.Size = new System.Drawing.Size(824, 510);
            this.userControlCriteria1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelExcelData);
            this.Controls.Add(this.panelNavigation);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panelNavigation.ResumeLayout(false);
            this.panelExcelData.ResumeLayout(false);
            this.panelExcelData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelExcelData;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.Label lblGoToGuestForm;
        private UserControlCriteria userControlCriteria1;
        private UserControlCriteria userControlCriteria2;
    }
}