using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DomainModel.Models;
namespace Laboratory2
{
    public partial class TestRangeForm : Form
    {
        TestRangeRepository repo = new TestRangeRepository();
        int rangeId;
        private void clearForm()
        {
            fromValurText.Text = " ";
            toValueText.Text = " ";
            FromAgeText.Text = " ";
            toAgeText.Text = " ";
            cmbTest.Text = " ";
            
        }
        private void BindTest()
        {
            TestCategoryRepository repo2 = new TestCategoryRepository();
            List<TestCategory> testCategories = repo2.GetAll();
            testCategories.Insert(0, new TestCategory
            {
                CategoryID = -1,
                CategoryName = "...choose a test..."
            });
            cmbTest.DisplayMember = "CategoryName";
            cmbTest.ValueMember = "CategoryID";
            cmbTest.DataSource = testCategories;
        }
        private void BindGrid()
        {
            dataGridRange.AutoGenerateColumns = false;
            dataGridRange.DataSource = null;
            TestRangeRepository repo = new TestRangeRepository();
            dataGridRange.DataSource = repo.GetAll();
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
        public TestRangeForm()
        {
            InitializeComponent();
        }

        private void TestRange_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindTest();
            goToAddMode();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool genderValue = radioButton3.Checked;
            int gender ;
            if (genderValue)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }

            int testID = Convert.ToInt32(cmbTest.SelectedValue);
            TestRanx range = new TestRanx
            {
                FromAge = Convert.ToInt32(FromAgeText.Text),
                ToAge = Convert.ToInt32(toAgeText.Text),
                FromValue = Convert.ToInt32(fromValurText.Text),
                ToValue = Convert.ToInt32(toValueText.Text),
                TestID = testID,
                Gender = gender,

                Hazard=radioButton1.Checked,
                Description=DescriptionText.Text

            };
            repo.Add(range);
            clearForm();
            BindGrid();
        }
    }
}
