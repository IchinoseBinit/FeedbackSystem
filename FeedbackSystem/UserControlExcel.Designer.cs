
namespace FeedbackSystem
{
    partial class UserControlExcel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReviewsCount = new System.Windows.Forms.Label();
            this.lblNoOfCount = new System.Windows.Forms.Label();
            this.lblSelectCriteria = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            feedbackGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(feedbackGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblReviewsCount);
            this.panel1.Controls.Add(this.lblNoOfCount);
            this.panel1.Controls.Add(this.lblSelectCriteria);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.comboBoxSort);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(feedbackGridView);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 451);
            this.panel1.TabIndex = 0;
            // 
            // lblReviewsCount
            // 
            this.lblReviewsCount.AutoSize = true;
            this.lblReviewsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewsCount.Location = new System.Drawing.Point(170, 394);
            this.lblReviewsCount.Name = "lblReviewsCount";
            this.lblReviewsCount.Size = new System.Drawing.Size(27, 20);
            this.lblReviewsCount.TabIndex = 7;
            this.lblReviewsCount.Text = "10";
            this.lblReviewsCount.Visible = false;
            // 
            // lblNoOfCount
            // 
            this.lblNoOfCount.AutoSize = true;
            this.lblNoOfCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfCount.Location = new System.Drawing.Point(16, 394);
            this.lblNoOfCount.Name = "lblNoOfCount";
            this.lblNoOfCount.Size = new System.Drawing.Size(131, 20);
            this.lblNoOfCount.TabIndex = 5;
            this.lblNoOfCount.Text = "No. of Reviews: ";
            this.lblNoOfCount.Visible = false;
            // 
            // lblSelectCriteria
            // 
            this.lblSelectCriteria.AutoSize = true;
            this.lblSelectCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCriteria.Location = new System.Drawing.Point(727, 98);
            this.lblSelectCriteria.Name = "lblSelectCriteria";
            this.lblSelectCriteria.Size = new System.Drawing.Size(135, 20);
            this.lblSelectCriteria.TabIndex = 4;
            this.lblSelectCriteria.Text = "Select a Criteria:";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Location = new System.Drawing.Point(1129, 85);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(102, 41);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(907, 94);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(149, 24);
            this.comboBoxSort.TabIndex = 2;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(1129, 394);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 41);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // feedbackGridView
            // 
            feedbackGridView.AllowUserToAddRows = false;
            feedbackGridView.AllowUserToDeleteRows = false;
            feedbackGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            feedbackGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            feedbackGridView.Location = new System.Drawing.Point(20, 143);
            feedbackGridView.Name = "feedbackGridView";
            feedbackGridView.ReadOnly = true;
            feedbackGridView.RowHeadersWidth = 51;
            feedbackGridView.RowTemplate.Height = 24;
            feedbackGridView.Size = new System.Drawing.Size(1211, 226);
            feedbackGridView.TabIndex = 0;
            // 
            // UserControlExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlExcel";
            this.Size = new System.Drawing.Size(1259, 454);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(feedbackGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label lblSelectCriteria;
        private System.Windows.Forms.Label lblNoOfCount;
        private System.Windows.Forms.Label lblReviewsCount;
        public static System.Windows.Forms.DataGridView feedbackGridView;
    }
}
