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
            fromValurText.Text = " ";
            toValueText.Text = " ";
            FromAgeText.Text = " ";
            toAgeText.Text = " ";
            cmbTest.Text = " ";
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
    }
}
