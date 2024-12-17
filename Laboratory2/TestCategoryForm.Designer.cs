namespace Laboratory2
{
    partial class TestCategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.txtcolumnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdateCategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.catName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("MRT_Silicon Outline", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.btnAddNew.Location = new System.Drawing.Point(337, 87);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 49);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.btnCancel.Location = new System.Drawing.Point(337, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.btnEdit.Location = new System.Drawing.Point(337, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 49);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gridCategories
            // 
            this.gridCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(152)))), ((int)(((byte)(237)))));
            this.gridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcolumnCategoryID,
            this.clmnCategoryName,
            this.DELETE,
            this.clmnUpdateCategory});
            this.gridCategories.Location = new System.Drawing.Point(-8, 352);
            this.gridCategories.Name = "gridCategories";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.gridCategories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCategories.Size = new System.Drawing.Size(481, 158);
            this.gridCategories.TabIndex = 6;
            this.gridCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategories_CellContentClick);
            // 
            // txtcolumnCategoryID
            // 
            this.txtcolumnCategoryID.DataPropertyName = "CategoryID";
            this.txtcolumnCategoryID.HeaderText = "ID";
            this.txtcolumnCategoryID.Name = "txtcolumnCategoryID";
            this.txtcolumnCategoryID.Visible = false;
            // 
            // clmnCategoryName
            // 
            this.clmnCategoryName.DataPropertyName = "CategoryName";
            this.clmnCategoryName.HeaderText = "Name";
            this.clmnCategoryName.Name = "clmnCategoryName";
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            // 
            // clmnUpdateCategory
            // 
            this.clmnUpdateCategory.HeaderText = "UPDATE";
            this.clmnUpdateCategory.Name = "clmnUpdateCategory";
            this.clmnUpdateCategory.Text = "UPDATE";
            // 
            // catName
            // 
            this.catName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.catName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.catName.Location = new System.Drawing.Point(337, 41);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(145, 26);
            this.catName.TabIndex = 7;
            // 
            // TestCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 509);
            this.Controls.Add(this.catName);
            this.Controls.Add(this.gridCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Name = "TestCategoryForm";
            this.Text = "TestCategory";
            this.Load += new System.EventHandler(this.TestCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolumnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryName;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdateCategory;
        private System.Windows.Forms.TextBox catName;
    }
}