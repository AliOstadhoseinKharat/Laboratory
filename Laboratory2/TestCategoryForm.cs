using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using DataAccess;
namespace Laboratory2
{
    public partial class TestCategoryForm : Form
    {
        TestCategoryRepository repo = new TestCategoryRepository();
        int catId;
        private void clearForm()
        {
            catName.Text = " ";
        }
        private void BindGrid()
        {
            gridCategories.AutoGenerateColumns = false;
            gridCategories.DataSource = null;
            gridCategories.DataSource = repo.GetAll();

        }
        private void goToAddMode()
        {
            btnAddNew.Enabled = true;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void goToEditMode()
        {
            btnAddNew.Enabled = false;
            btnEdit.Enabled = true;
            btnCancel.Enabled = true;
        }
        public TestCategoryForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TestCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            TestCategory testCategory = new TestCategory { CategoryName = catName.Text };
            repo.Add(testCategory);
            clearForm();
            BindGrid();
        }

        private void gridCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catId = Convert.ToInt32(gridCategories.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("are you sure?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool hast = repo.HasTest(catId);
                    if (!hast)
                    {
                        repo.Remove(catId);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("this classification has some test in it");
                    }
                }
            }
            if (e.ColumnIndex == 3)
            {
                goToEditMode();
                var cat = repo.Get(catId);
                catName.Text = cat.CategoryName;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TestCategory emp = new TestCategory
            {
                CategoryID = catId,
                CategoryName = catName.Text

            };
            repo.Update(emp);
            BindGrid();
            clearForm();
            goToAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            goToAddMode();
        }
    }
}
