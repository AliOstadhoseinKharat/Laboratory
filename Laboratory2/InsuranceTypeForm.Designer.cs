namespace Laboratory2
{
    partial class InsuranceTypeForm
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
            this.txtInsuranceType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsuranceDescription = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.insuranceGrid = new System.Windows.Forms.DataGridView();
            this.InsuranceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInsuranceType
            // 
            this.txtInsuranceType.Location = new System.Drawing.Point(143, 93);
            this.txtInsuranceType.Name = "txtInsuranceType";
            this.txtInsuranceType.Size = new System.Drawing.Size(163, 20);
            this.txtInsuranceType.TabIndex = 0;
            this.txtInsuranceType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insurance Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description : ";
            // 
            // txtInsuranceDescription
            // 
            this.txtInsuranceDescription.Location = new System.Drawing.Point(143, 144);
            this.txtInsuranceDescription.Multiline = true;
            this.txtInsuranceDescription.Name = "txtInsuranceDescription";
            this.txtInsuranceDescription.Size = new System.Drawing.Size(163, 74);
            this.txtInsuranceDescription.TabIndex = 2;
            this.txtInsuranceDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(397, 195);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(397, 147);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(397, 92);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // insuranceGrid
            // 
            this.insuranceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insuranceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsuranceTypeID,
            this.InsuranceTypeName,
            this.Description,
            this.Update,
            this.Delete});
            this.insuranceGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.insuranceGrid.Location = new System.Drawing.Point(0, 317);
            this.insuranceGrid.Name = "insuranceGrid";
            this.insuranceGrid.Size = new System.Drawing.Size(820, 150);
            this.insuranceGrid.TabIndex = 19;
            this.insuranceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.insuranceGrid_CellContentClick);
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
            this.InsuranceTypeName.HeaderText = "Insurance Name";
            this.InsuranceTypeName.Name = "InsuranceTypeName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // InsuranceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.insuranceGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsuranceDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsuranceType);
            this.Name = "InsuranceTypeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InsuranceTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insuranceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsuranceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsuranceDescription;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView insuranceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

