namespace Laboratory2
{
    partial class TestResultForm
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
            this.testResultDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceptionDate = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.PatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientTestHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testResultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // testResultDataGrid
            // 
            this.testResultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testResultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientTestDetailsID,
            this.PatientTestHeaderID,
            this.PatientID,
            this.PatientName,
            this.HeaderDate,
            this.TestID,
            this.TestName,
            this.Price,
            this.Result,
            this.HasStar,
            this.Edit});
            this.testResultDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testResultDataGrid.Location = new System.Drawing.Point(0, 282);
            this.testResultDataGrid.Name = "testResultDataGrid";
            this.testResultDataGrid.Size = new System.Drawing.Size(940, 168);
            this.testResultDataGrid.TabIndex = 26;
            this.testResultDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testResultDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reception Date : ";
            // 
            // lblReceptionDate
            // 
            this.lblReceptionDate.AutoSize = true;
            this.lblReceptionDate.Location = new System.Drawing.Point(232, 48);
            this.lblReceptionDate.Name = "lblReceptionDate";
            this.lblReceptionDate.Size = new System.Drawing.Size(35, 13);
            this.lblReceptionDate.TabIndex = 28;
            this.lblReceptionDate.Text = "label2";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(232, 133);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 30;
            this.lblTest.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Test : ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(474, 41);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(267, 20);
            this.txtResult.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Result : ";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(232, 92);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(35, 13);
            this.lblPatient.TabIndex = 34;
            this.lblPatient.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Patient :";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(411, 126);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 27);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(534, 126);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(77, 27);
            this.submitBtn.TabIndex = 36;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // PatientTestDetailsID
            // 
            this.PatientTestDetailsID.DataPropertyName = "PatientTestDetailsID";
            this.PatientTestDetailsID.HeaderText = "PatientTestDetailsID";
            this.PatientTestDetailsID.Name = "PatientTestDetailsID";
            this.PatientTestDetailsID.Visible = false;
            // 
            // PatientTestHeaderID
            // 
            this.PatientTestHeaderID.DataPropertyName = "PatientTestHeaderID";
            this.PatientTestHeaderID.HeaderText = "PatientTestHeaderID";
            this.PatientTestHeaderID.Name = "PatientTestHeaderID";
            this.PatientTestHeaderID.Visible = false;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.ToolTipText = "PatientName";
            // 
            // HeaderDate
            // 
            this.HeaderDate.DataPropertyName = "HeaderDate";
            this.HeaderDate.HeaderText = "HeaderDate";
            this.HeaderDate.Name = "HeaderDate";
            this.HeaderDate.ToolTipText = "HeaderDate";
            // 
            // TestID
            // 
            this.TestID.DataPropertyName = "TestID";
            this.TestID.HeaderText = "TestID";
            this.TestID.Name = "TestID";
            this.TestID.Visible = false;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "TestName";
            this.TestName.Name = "TestName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ToolTipText = "Price";
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ToolTipText = "Result";
            // 
            // HasStar
            // 
            this.HasStar.DataPropertyName = "HasStar";
            this.HasStar.HeaderText = "HasStar";
            this.HasStar.Name = "HasStar";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // TestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReceptionDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testResultDataGrid);
            this.Name = "TestResultForm";
            this.Text = "TestResultForm";
            this.Load += new System.EventHandler(this.TestResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testResultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView testResultDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceptionDate;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientTestHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasStar;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}