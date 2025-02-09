using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class TestResultForm : Form
    {
        private PatientTestDetailRepository _repo = new PatientTestDetailRepository();
        private int _patientTestDetailID;
        private int _currentRowIndex;

        public TestResultForm()
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

            lblPatient.Text = "";
            lblReceptionDate.Text = "";
            lblTest.Text = "";
        }


        private void BindGrid()
        {
            testResultDataGrid.AutoGenerateColumns = false;
            testResultDataGrid.DataSource = null;
            testResultDataGrid.DataSource = _repo.GetAllPatientTestDetails();
        }

        #endregion

        private void TestResultForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void testResultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._patientTestDetailID = Convert.ToInt32(testResultDataGrid.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 10)
            {
                var patientTestDetail = _repo.Get(_patientTestDetailID);

                PatientTestHeaderRepository patientHeaderRepo = new PatientTestHeaderRepository();
                var patientHeader = patientHeaderRepo.Get(patientTestDetail.PatientTestHeaderID);

                PatientRepository patientRepo = new PatientRepository();
                var patient = patientRepo.Get(patientHeader.PatientID);


                TestRepository testRepo = new TestRepository();
                var test = testRepo.Get(patientTestDetail.TestID);


                lblReceptionDate.Text = patientHeader.HeaderDate.ToString();
                lblPatient.Text = (patient.FirstName ?? "") + " " + (patient.LastName ?? "");
                lblTest.Text = test.TestName;
                txtResult.Text = patientTestDetail.Result.ToString();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            lblReceptionDate.Text = "";
            lblPatient.Text = "";
            lblTest.Text = "";
            txtResult.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var testDetail = _repo.Get(_patientTestDetailID);
            TestRangeRepository testRangeRepo = new TestRangeRepository();

            if (testDetail != null)
            {
                TestRanx testRange = testRangeRepo.GetRangeByTest(testDetail.TestID);
                double resultValue = double.Parse(txtResult.Text);
                testDetail.Result = resultValue;
                if (testRange != null)
                {
                    if (resultValue < testRange.FromValue || resultValue > testRange.ToValue)
                    {
                        testDetail.HasStar = true;
                    }
                    else
                    {
                        testDetail.HasStar = false;
                    }
                }
                _repo.Update(testDetail);
                BindGrid();
                clearForm();
            }
        }
    }
}
