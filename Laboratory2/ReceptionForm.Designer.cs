namespace Laboratory2
{
    partial class ReceptionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.insuranceTypeCombo = new System.Windows.Forms.ComboBox();
            this.headerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.patientCombo = new System.Windows.Forms.ComboBox();
            this.employeeCombo = new System.Windows.Forms.ComboBox();
            this.receptionDataGrid = new System.Windows.Forms.DataGridView();
            this.PatientTestHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Insurance Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Patient:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Employee:";
            // 
            // insuranceTypeCombo
            // 
            this.insuranceTypeCombo.FormattingEnabled = true;
            this.insuranceTypeCombo.Location = new System.Drawing.Point(223, 150);
            this.insuranceTypeCombo.Name = "insuranceTypeCombo";
            this.insuranceTypeCombo.Size = new System.Drawing.Size(200, 21);
            this.insuranceTypeCombo.TabIndex = 10;
            // 
            // headerDatePicker
            // 
            this.headerDatePicker.Location = new System.Drawing.Point(223, 22);
            this.headerDatePicker.Name = "headerDatePicker";
            this.headerDatePicker.Size = new System.Drawing.Size(200, 20);
            this.headerDatePicker.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(223, 241);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 14;
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(223, 198);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(200, 20);
            this.txtDrName.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(471, 69);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(471, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button8_Click);
            // 
            // patientCombo
            // 
            this.patientCombo.FormattingEnabled = true;
            this.patientCombo.Location = new System.Drawing.Point(223, 66);
            this.patientCombo.Name = "patientCombo";
            this.patientCombo.Size = new System.Drawing.Size(200, 21);
            this.patientCombo.TabIndex = 22;
            // 
            // employeeCombo
            // 
            this.employeeCombo.FormattingEnabled = true;
            this.employeeCombo.Location = new System.Drawing.Point(223, 105);
            this.employeeCombo.Name = "employeeCombo";
            this.employeeCombo.Size = new System.Drawing.Size(200, 21);
            this.employeeCombo.TabIndex = 23;
            // 
            // receptionDataGrid
            // 
            this.receptionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientTestHeaderID,
            this.HeaderDate,
            this.PatientID,
            this.PatientName,
            this.EmployeeID,
            this.EmployeeName,
            this.InsuranceTypeID,
            this.InsuranceTypeName,
            this.DrName,
            this.TotalPrice,
            this.Age,
            this.Edit,
            this.Delete});
            this.receptionDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receptionDataGrid.Location = new System.Drawing.Point(0, 477);
            this.receptionDataGrid.Name = "receptionDataGrid";
            this.receptionDataGrid.Size = new System.Drawing.Size(1002, 226);
            this.receptionDataGrid.TabIndex = 24;
            this.receptionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receptionDataGrid_CellContentClick);
            // 
            // PatientTestHeaderID
            // 
            this.PatientTestHeaderID.DataPropertyName = "PatientTestHeaderID";
            this.PatientTestHeaderID.HeaderText = "PatientTestHeaderID";
            this.PatientTestHeaderID.Name = "PatientTestHeaderID";
            this.PatientTestHeaderID.Visible = false;
            // 
            // HeaderDate
            // 
            this.HeaderDate.DataPropertyName = "HeaderDate";
            this.HeaderDate.HeaderText = "HeaderDate";
            this.HeaderDate.Name = "HeaderDate";
            this.HeaderDate.ToolTipText = "HeaderDate";
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
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ToolTipText = "EmployeeName";
            // 
            // InsuranceTypeID
            // 
            this.InsuranceTypeID.DataPropertyName = "InsuranceTypeID";
            this.InsuranceTypeID.HeaderText = "InsuranceTypeID";
            this.InsuranceTypeID.Name = "InsuranceTypeID";
            this.InsuranceTypeID.Visible = false;
            // 
            // InsuranceTypeName
            // 
            this.InsuranceTypeName.DataPropertyName = "InsuranceTypeName";
            this.InsuranceTypeName.HeaderText = "InsuranceTypeName";
            this.InsuranceTypeName.Name = "InsuranceTypeName";
            this.InsuranceTypeName.ToolTipText = "InsuranceTypeName";
            // 
            // DrName
            // 
            this.DrName.DataPropertyName = "DrName";
            this.DrName.HeaderText = "DrName";
            this.DrName.Name = "DrName";
            this.DrName.ToolTipText = "DrName";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ToolTipText = "TotalPrice";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ToolTipText = "Age";
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
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.receptionDataGrid);
            this.Controls.Add(this.employeeCombo);
            this.Controls.Add(this.patientCombo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDrName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.headerDatePicker);
            this.Controls.Add(this.insuranceTypeCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ReceptionForm";
            this.Text = "Reception";
            this.Load += new System.EventHandler(this.ReceptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receptionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox insuranceTypeCombo;
        private System.Windows.Forms.DateTimePicker headerDatePicker;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDrName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox patientCombo;
        private System.Windows.Forms.ComboBox employeeCombo;
        private System.Windows.Forms.DataGridView receptionDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientTestHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}