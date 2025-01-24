namespace Laboratory2
{
    partial class TestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.unitComboo = new System.Windows.Forms.ComboBox();
            this.categoryComboo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageHasNot = new System.Windows.Forms.RadioButton();
            this.ageHas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genderHasNot = new System.Windows.Forms.RadioButton();
            this.genderHas = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.testGrid = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeHasEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderHasEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age Has Effect:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender Has Effect:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price:";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(167, 22);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(121, 20);
            this.txtTestName.TabIndex = 6;
            // 
            // unitComboo
            // 
            this.unitComboo.FormattingEnabled = true;
            this.unitComboo.Location = new System.Drawing.Point(167, 75);
            this.unitComboo.Name = "unitComboo";
            this.unitComboo.Size = new System.Drawing.Size(121, 21);
            this.unitComboo.TabIndex = 7;
            // 
            // categoryComboo
            // 
            this.categoryComboo.FormattingEnabled = true;
            this.categoryComboo.Location = new System.Drawing.Point(624, 27);
            this.categoryComboo.Name = "categoryComboo";
            this.categoryComboo.Size = new System.Drawing.Size(121, 21);
            this.categoryComboo.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ageHasNot);
            this.groupBox1.Controls.Add(this.ageHas);
            this.groupBox1.Location = new System.Drawing.Point(180, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ageHasNot
            // 
            this.ageHasNot.AutoSize = true;
            this.ageHasNot.Location = new System.Drawing.Point(136, 20);
            this.ageHasNot.Name = "ageHasNot";
            this.ageHasNot.Size = new System.Drawing.Size(62, 17);
            this.ageHasNot.TabIndex = 1;
            this.ageHasNot.Text = "Has not";
            this.ageHasNot.UseVisualStyleBackColor = true;
            // 
            // ageHas
            // 
            this.ageHas.AutoSize = true;
            this.ageHas.Location = new System.Drawing.Point(7, 20);
            this.ageHas.Name = "ageHas";
            this.ageHas.Size = new System.Drawing.Size(44, 17);
            this.ageHas.TabIndex = 0;
            this.ageHas.Text = "Has";
            this.ageHas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.genderHasNot);
            this.groupBox2.Controls.Add(this.genderHas);
            this.groupBox2.Location = new System.Drawing.Point(180, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 42);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // genderHasNot
            // 
            this.genderHasNot.AutoSize = true;
            this.genderHasNot.Location = new System.Drawing.Point(136, 20);
            this.genderHasNot.Name = "genderHasNot";
            this.genderHasNot.Size = new System.Drawing.Size(64, 17);
            this.genderHasNot.TabIndex = 1;
            this.genderHasNot.TabStop = true;
            this.genderHasNot.Text = "Has Not";
            this.genderHasNot.UseVisualStyleBackColor = true;
            // 
            // genderHas
            // 
            this.genderHas.AutoSize = true;
            this.genderHas.Location = new System.Drawing.Point(7, 20);
            this.genderHas.Name = "genderHas";
            this.genderHas.Size = new System.Drawing.Size(44, 17);
            this.genderHas.TabIndex = 0;
            this.genderHas.TabStop = true;
            this.genderHas.Text = "Has";
            this.genderHas.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(624, 78);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // testGrid
            // 
            this.testGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestID,
            this.TestName,
            this.UnitName,
            this.CategoryName,
            this.Price,
            this.AgeHasEffect,
            this.GenderHasEffect,
            this.clmnDelete,
            this.Update});
            this.testGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testGrid.Location = new System.Drawing.Point(0, 284);
            this.testGrid.Name = "testGrid";
            this.testGrid.Size = new System.Drawing.Size(965, 166);
            this.testGrid.TabIndex = 12;
            this.testGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(499, 176);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(580, 176);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(661, 176);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit";
            this.UnitName.Name = "UnitName";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "categoryName";
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // AgeHasEffect
            // 
            this.AgeHasEffect.DataPropertyName = "AgeHasEffect";
            this.AgeHasEffect.HeaderText = "Age Has Effect";
            this.AgeHasEffect.Name = "AgeHasEffect";
            // 
            // GenderHasEffect
            // 
            this.GenderHasEffect.DataPropertyName = "GenderHasEffect";
            this.GenderHasEffect.HeaderText = "Gender Has Effect";
            this.GenderHasEffect.Name = "GenderHasEffect";
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "Delete";
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "Delete";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.testGrid);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoryComboo);
            this.Controls.Add(this.unitComboo);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.ComboBox unitComboo;
        private System.Windows.Forms.ComboBox categoryComboo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ageHasNot;
        private System.Windows.Forms.RadioButton ageHas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton genderHasNot;
        private System.Windows.Forms.RadioButton genderHas;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView testGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeHasEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderHasEffect;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}