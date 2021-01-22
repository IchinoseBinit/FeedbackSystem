
namespace FeedbackSystem
{
    partial class UserControlCriteria
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
            this.criteriaGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCriteriaName = new System.Windows.Forms.TextBox();
            this.lblCriteriaName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.criteriaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // criteriaGridView
            // 
            this.criteriaGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.criteriaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criteriaGridView.Location = new System.Drawing.Point(896, 69);
            this.criteriaGridView.Name = "criteriaGridView";
            this.criteriaGridView.RowHeadersWidth = 51;
            this.criteriaGridView.RowTemplate.Height = 24;
            this.criteriaGridView.Size = new System.Drawing.Size(262, 246);
            this.criteriaGridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(352, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1067, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCriteriaName
            // 
            this.txtCriteriaName.Location = new System.Drawing.Point(294, 88);
            this.txtCriteriaName.Name = "txtCriteriaName";
            this.txtCriteriaName.Size = new System.Drawing.Size(211, 22);
            this.txtCriteriaName.TabIndex = 3;
            // 
            // lblCriteriaName
            // 
            this.lblCriteriaName.AutoSize = true;
            this.lblCriteriaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriaName.Location = new System.Drawing.Point(108, 88);
            this.lblCriteriaName.Name = "lblCriteriaName";
            this.lblCriteriaName.Size = new System.Drawing.Size(118, 20);
            this.lblCriteriaName.TabIndex = 4;
            this.lblCriteriaName.Text = "Criteria Name:";
            // 
            // UserControlCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblCriteriaName);
            this.Controls.Add(this.txtCriteriaName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.criteriaGridView);
            this.Name = "UserControlCriteria";
            this.Size = new System.Drawing.Size(1256, 451);
            ((System.ComponentModel.ISupportInitialize)(this.criteriaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView criteriaGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCriteriaName;
        private System.Windows.Forms.Label lblCriteriaName;
    }
}
