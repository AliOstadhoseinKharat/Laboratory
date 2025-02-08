using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class ReceptionTestsForm : Form
    {
        private PatientTestDetailRepository _repo = new PatientTestDetailRepository();
        private int _patientTestDetailID;
        public ReceptionTestsForm()
        {
            InitializeComponent();
        }

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
                            radio.Checked = false;
                        }
                    }
                }
            }
            this.Refresh();
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

        private void BindReceptions()
        {
            PatientTestHeaderRepository patientRepo = new PatientTestHeaderRepository();
            var receptions = patientRepo.GetAllReceptions();
            receptions.Insert(0, new DomainModel.ViewModels.ReceptionViewModel
            {
                PatientTestHeaderID = -1,
                PatientTestHeaderName = "...choose a test..."
            });
            cmbReception.DisplayMember = "PatientTestHeaderName";
            cmbReception.ValueMember = "PatientTestHeaderID";
            cmbReception.DataSource = receptions;
        }

        private void BindGrid()
        {
            receptionTestsDataGrid.AutoGenerateColumns = false;
            receptionTestsDataGrid.DataSource = null;
            receptionTestsDataGrid.DataSource = _repo.GetAllPatientTestDetails();
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

        private void receptionDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._patientTestDetailID = Convert.ToInt32(receptionTestsDataGrid.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 8)
            {
                var patientTestDetail = _repo.Get(_patientTestDetailID);
                goToEditMode();


                var testRepo = new TestRepository();
                var currentTest = testRepo.Get(patientTestDetail.TestID);

                var headerRepo = new PatientTestHeaderRepository();
                var currentHeader = headerRepo.Get(patientTestDetail.PatientTestHeaderID);


                cmbTest.SelectedValue = currentTest.TestID;
                cmbReception.SelectedValue = currentHeader.PatientTestHeaderID;
            }


            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Are you Sure ?", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = _repo.Remove(_patientTestDetailID);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }
                }
            }
        }

        private void ReceptionTestsForm_Load(object sender, System.EventArgs e)
        {
            BindReceptions();
            BindTests();
            BindGrid();
            goToAddMode();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clearForm();
            goToAddMode();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {

            TestRepository testRepo = new TestRepository();
            var selectedTest = testRepo.Get(Convert.ToInt32(cmbTest.SelectedValue));

            PatientTestDetail patientTest = new PatientTestDetail
            {
                TestID = selectedTest.TestID,
                Price = selectedTest.Price,
                PatientTestHeaderID = Convert.ToInt32(cmbReception.SelectedValue),
                Result = 0,
                HasStar = false
            };


            _repo.Add(patientTest);
            clearForm();
            BindGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int testID = Convert.ToInt32(cmbTest.SelectedValue);
            TestRepository testRepo = new TestRepository();
            var selectedTest = testRepo.Get(testID);
            int patientHeaderID = Convert.ToInt32(cmbReception.SelectedValue);

            PatientTestDetail patientTestDetail = new PatientTestDetail
            {
                PatientTestDetailsID = _patientTestDetailID,
                TestID = selectedTest.TestID,
                Price = selectedTest.Price,
                PatientTestHeaderID = patientHeaderID,
            };

            _repo.Update(patientTestDetail);
            BindGrid();
            clearForm();
            goToAddMode();
        }
    }
}
