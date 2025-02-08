namespace Laboratory2
{
    partial class ReceptionTestsForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.receptionTestsDataGrid = new System.Windows.Forms.DataGridView();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReception = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientTestHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receptionTestsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(464, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // receptionTestsDataGrid
            // 
            this.receptionTestsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionTestsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientTestDetailsID,
            this.PatientTestHeaderID,
            this.PatientID,
            this.PatientName,
            this.HeaderDate,
            this.TestID,
            this.TestName,
            this.Price,
            this.Edit,
            this.Delete});
            this.receptionTestsDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receptionTestsDataGrid.Location = new System.Drawing.Point(0, 282);
            this.receptionTestsDataGrid.Name = "receptionTestsDataGrid";
            this.receptionTestsDataGrid.Size = new System.Drawing.Size(1051, 168);
            this.receptionTestsDataGrid.TabIndex = 25;
            this.receptionTestsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receptionDataGrid_CellContentClick);
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(146, 79);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(221, 21);
            this.cmbTest.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Test:";
            // 
            // cmbReception
            // 
            this.cmbReception.FormattingEnabled = true;
            this.cmbReception.Location = new System.Drawing.Point(146, 38);
            this.cmbReception.Name = "cmbReception";
            this.cmbReception.Size = new System.Drawing.Size(221, 21);
            this.cmbReception.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Reception :";
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
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ReceptionTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.cmbReception);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receptionTestsDataGrid);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "ReceptionTestsForm";
            this.Text = "ReceptionTestsForm";
            this.Load += new System.EventHandler(this.ReceptionTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receptionTestsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView receptionTestsDataGrid;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReception;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientTestHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}