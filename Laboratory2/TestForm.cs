using DataAccess;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class TestForm : Form
    {

        private TestRepository testRepo = new TestRepository();
        private int globalTestID;

        public TestForm()
        {
            InitializeComponent();
        }

        #region Helper Functions

        private void clearForm()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    var txt = (TextBox)control;
                    txt.Text = "";
                }

                if (control is ComboBox)
                {
                    var comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }



                if (control.HasChildren)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        if (childControl is RadioButton)
                        {
                            RadioButton radio = (RadioButton)childControl;
                            radio.Checked = false;
                        }
                    }
                }
            }
            this.Refresh();
        }

        private void BindGrid()
        {
            testGrid.AutoGenerateColumns = false;
            testGrid.DataSource = null;
            testGrid.DataSource = testRepo.GetAllCustomTests();
        }

        private void BindUnits()
        {

            UnitRepository unitRepo = new UnitRepository();
            List<Unit> testUnits = unitRepo.GetAll();

            testUnits.Insert(0, new Unit
            {
                UnitID = -1,
                UnitName = "...choose a Unit..."

            });

            unitComboo.DisplayMember = "UnitName";
            unitComboo.ValueMember = "UnitID";
            unitComboo.DataSource = testUnits;

        }

        private void BindTestCategories()
        {
            TestCategoryRepository testCategoryRepo = new TestCategoryRepository();
            List<TestCategory> testCategories = testCategoryRepo.GetAll();
            testCategories.Insert(0, new TestCategory
            {
                CategoryID = -1,
                CategoryName = "...choose a test..."
            });
            categoryComboo.DisplayMember = "CategoryName";
            categoryComboo.ValueMember = "CategoryID";
            categoryComboo.DataSource = testCategories;
        }



        private void GoToAddMode()
        {
            addBtn.Enabled = true;
            cancelBtn.Enabled = false;
            updateBtn.Enabled = false;
        }

        private void GoToEditMode()
        {
            addBtn.Enabled = false;
            cancelBtn.Enabled = true;
            updateBtn.Enabled = true;
        }


        #endregion
        private void Test_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindTestCategories();
            BindUnits();
            GoToAddMode();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.globalTestID = Convert.ToInt32(testGrid.Rows[e.RowIndex].Cells[0].Value);

            //Condition for update operator
            if (e.ColumnIndex == 8)
            {

                Test test = testRepo.Get(globalTestID);
                GoToEditMode();
                txtTestName.Text = test.TestName;
                txtPrice.Text = test.Price.ToString();


                UnitRepository unitRepo = new UnitRepository();
                Unit selectedUnit = unitRepo.Get(test.UnitID);

                if (selectedUnit != null)
                {
                    unitComboo.SelectedText = selectedUnit.UnitName;
                    unitComboo.SelectedValue = selectedUnit.UnitID;
                }

                TestCategoryRepository categoryRepo = new TestCategoryRepository();
                TestCategory selectedTestCategory = categoryRepo.Get(test.TestCategoryID ?? 0);

                if (selectedTestCategory != null)
                {
                    categoryComboo.SelectedText = selectedTestCategory.CategoryName;
                    categoryComboo.SelectedValue = selectedTestCategory.CategoryID;
                }

                ageHas.Checked = test.AgeHasEffect == true ? true : false;
                ageHasNot.Checked = test.AgeHasEffect == false ? true : false;
                genderHas.Checked = test.GenderHasEffect == true ? true : false;
                genderHasNot.Checked = test.GenderHasEffect == false ? true : false;


            }

            //Condition for delete operator
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure ? ", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = testRepo.Remove(globalTestID);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            GoToAddMode();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            bool ageHasEffect = ageHas.Checked ? true : false;
            bool genderHasEffect = genderHas.Checked ? true : false;

            int unitID = Convert.ToInt32(unitComboo.SelectedValue);
            int categoryID = Convert.ToInt32(categoryComboo.SelectedValue);
            Test test = new Test
            {
                TestName = txtTestName.Text,
                UnitID = unitID,
                TestCategoryID = categoryID,
                Price = Convert.ToInt32(txtPrice.Text),
                AgeHasEffect = ageHasEffect,
                GenderHasEffect = genderHasEffect,
            };

            testRepo.Add(test);
            clearForm();
            BindGrid();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            bool ageHasEffect = ageHas.Checked ? true : false;
            bool genderHasEffect = genderHas.Checked ? true : false;

            int unitID = Convert.ToInt32(unitComboo.SelectedValue);
            int categoryID = Convert.ToInt32(categoryComboo.SelectedValue);


            Test test = new Test
            {
                TestID = globalTestID,
                TestName = txtTestName.Text,
                UnitID = unitID,
                TestCategoryID = categoryID,
                GenderHasEffect = genderHasEffect,
                AgeHasEffect = ageHasEffect,
                Price = Convert.ToInt32(txtPrice.Text)
            };

            testRepo.Update(test);
            BindGrid();
            clearForm();
            GoToAddMode();

        }
    }
}
