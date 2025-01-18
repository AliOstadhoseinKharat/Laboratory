using DataAccess;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Laboratory2
{
    public partial class TestRangeForm : Form
    {
        private TestRangeRepository testRangeRepo = new TestRangeRepository();
        private int rangeId;

        #region Helper Methods
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
                            Console.WriteLine("Unchecking: " + radio.Name);
                            radio.Checked = false; 
                        }
                    }
                }
            }
            this.Refresh();
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
            cmbTest.DisplayMember = "CategoryName";
            cmbTest.ValueMember = "CategoryID";
            cmbTest.DataSource = testCategories;
        }

        private void BindTests()
        {
            TestRepository testRepository = new TestRepository();
            var tests = testRepository.GetAll();
            tests.Insert(0, new DomainModel.Models.Test
            {
                TestID = -1,
                TestName = "...choose a test..."
            });
            cmbTest.DisplayMember = "TestName";
            cmbTest.ValueMember = "TestID";
            cmbTest.DataSource = tests;
        }

        private void BindGrid()
        {
            dataGridRange.AutoGenerateColumns = false;
            dataGridRange.DataSource = null;
            dataGridRange.DataSource = testRangeRepo.GetAll();
        }


        private void goToAddMode()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void goToEditMode()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnCancel.Enabled = true;
        }
        #endregion


        public TestRangeForm()
        {
            InitializeComponent();
        }

        private void TestRange_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindTests();
            goToAddMode();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool genderValue = radioButton3.Checked;
            int gender = genderValue ? 0 : 1;


            int testID = Convert.ToInt32(cmbTest.SelectedValue);
            TestRanx range = new TestRanx
            {
                FromAge = Convert.ToInt32(FromAgeText.Text),
                ToAge = Convert.ToInt32(toAgeText.Text),
                FromValue = Convert.ToInt32(fromValurText.Text),
                ToValue = Convert.ToInt32(toValueText.Text),
                TestID = testID,
                Gender = gender,

                Hazard = radioButton1.Checked,
                Description = DescriptionText.Text

            };
            testRangeRepo.Add(range);
            clearForm();
            BindGrid();
        }

        private void dataGridRange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rangeId = Convert.ToInt32(dataGridRange.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 10)
            {
                var testRange = testRangeRepo.Get(rangeId);
                goToEditMode();
                if (testRange.Gender == 0) radioButton3.Checked = true; else radioButton4.Checked = true;
                if (testRange.Hazard != null && testRange.Hazard == true) radioButton1.Checked = true; else radioButton2.Checked = true;
                var testRepo = new TestRepository();
                var currentTest = testRepo.Get(testRange.TestID);
                cmbTest.SelectedText = currentTest.TestName;
                cmbTest.SelectedValue = currentTest.TestID;
                fromValurText.Text = testRange.FromValue.ToString();
                toValueText.Text = testRange.ToValue.ToString();
                DescriptionText.Text = testRange.Description;
                FromAgeText.Text = testRange.FromAge.ToString();
                toAgeText.Text = testRange.ToAge.ToString();
            }


            if (e.ColumnIndex == 11)
            {
                int testRangeId = Convert.ToInt32(dataGridRange.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you Sure ?", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = testRangeRepo.Remove(testRangeId);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
            goToAddMode();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool genderValue = radioButton3.Checked;
            int gender = genderValue ? 0 : 1;

            bool hazardValue = radioButton1.Checked;
            bool hazard = hazardValue ? true : false;

            int testID = Convert.ToInt32(cmbTest.SelectedValue);
            TestRanx testRange  = new TestRanx {
                RangeID = rangeId,
                FromAge = Convert.ToInt32(FromAgeText.Text),
                ToAge = Convert.ToInt32(toAgeText.Text),
                FromValue = Convert.ToInt32(fromValurText.Text),
                ToValue = Convert.ToInt32(toValueText.Text),
                TestID = testID,
                Gender = gender,

                Hazard = hazard,
                Description = DescriptionText.Text
            };

            testRangeRepo.Update(testRange);
            BindGrid();
            clearForm();
            goToAddMode();

        }
    }
}
