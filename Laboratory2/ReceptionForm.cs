using DataAccess;
using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class ReceptionForm : Form
    {
        private PatientTestHeaderRepository _repo = new PatientTestHeaderRepository();
        private int _patientHeaderId;

        #region helper methods

        private void BindEmployees()
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            var insurances = employeeRepo.GetAllEmployee();
            insurances.Insert(0, new EmployeeViewModel
            {
                EmployeeID = -1,
                FullName = "...choose a Employee..."
            });
            employeeCombo.DisplayMember = "FullName";
            employeeCombo.ValueMember = "EmployeeID";
            employeeCombo.DataSource = insurances;
        }

        private void BindPatients()
        {
            PatientRepository patientRepo = new PatientRepository();
            var insurances = patientRepo.GetAllPatients();
            insurances.Insert(0, new PatientViewModel
            {
                PatientID = -1,
                FullName = "...choose a Patient..."
            });
            patientCombo.DisplayMember = "FullName";
            patientCombo.ValueMember = "PatientID";
            patientCombo.DataSource = insurances;
        }

        private void BindInsuranceTypes()
        {
            InsuranceTypeRepository insuranceTyeRepo = new InsuranceTypeRepository();
            var insurances = insuranceTyeRepo.GetAll();
            insurances.Insert(0, new InsuranceType
            {
                InsuranceTypeID = -1,
                InsuranceTypeName = "...choose a Insurance Type..."
            });
            insuranceTypeCombo.DisplayMember = "InsuranceTypeName";
            insuranceTypeCombo.ValueMember = "InsuranceTypeID";
            insuranceTypeCombo.DataSource = insurances;
        }

        private void BindGrid()
        {
            receptionDataGrid.AutoGenerateColumns = false;
            receptionDataGrid.DataSource = null;
            receptionDataGrid.DataSource = _repo.GetAllReceptions();
        }

        private void GoToAddMode()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void GoToEditMode()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnCancel.Enabled = true;
        }


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
            }
            this.Refresh();
        }

        #endregion


        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PatientHeader reception = new PatientHeader
            {
                HeaderDate = headerDatePicker.Value,
                PatientID = Convert.ToInt32(patientCombo.SelectedValue),
                EmployeeID = Convert.ToInt32(employeeCombo.SelectedValue),
                InsuranceTypeID = Convert.ToInt32(insuranceTypeCombo.SelectedValue),
                DrName = txtDrName.Text,
                Age = Convert.ToInt32(txtAge.Text),
            };


            _repo.Add(reception);
            clearForm();
            BindGrid();
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            BindEmployees();
            BindPatients();
            BindInsuranceTypes();
            BindGrid();
            GoToAddMode();
        }

        private void receptionDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._patientHeaderId = Convert.ToInt32(receptionDataGrid.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 11)
            {
                var patientHeader = _repo.Get(_patientHeaderId);
                GoToEditMode();


                var patientRepo = new PatientRepository();
                var currentPatient = patientRepo.Get(patientHeader.PatientID);

                var employeeRepo = new EmployeeRepository();
                var currentEmployee = employeeRepo.Get(patientHeader.EmployeeID);

                var insuranceRepo = new InsuranceTypeRepository();
                var currentInsurance = insuranceRepo.Get((int)patientHeader.InsuranceTypeID);



                headerDatePicker.Value = patientHeader.HeaderDate;
                patientCombo.SelectedValue = currentPatient.PatientID;

                employeeCombo.SelectedValue = currentEmployee.EmployeeID;


                insuranceTypeCombo.SelectedValue = currentInsurance.InsuranceTypeID;

                txtDrName.Text = patientHeader.DrName;
                txtAge.Text = patientHeader.Age.ToString();

            }


            if (e.ColumnIndex == 12)
            {
                if (MessageBox.Show("Are you Sure ?", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = _repo.Remove(_patientHeaderId);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
            GoToAddMode();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int patientID = Convert.ToInt32(patientCombo.SelectedValue);
            int employeeID = Convert.ToInt32(employeeCombo.SelectedValue);
            int insuranceTypeID = Convert.ToInt32(insuranceTypeCombo.SelectedValue);

            PatientHeader patientHeader = new PatientHeader
            {
                PatientTestHeaderID = _patientHeaderId,
                HeaderDate = headerDatePicker.Value,
                PatientID = patientID,
                EmployeeID = employeeID,
                InsuranceTypeID = insuranceTypeID,
                DrName = txtDrName.Text,
                Age = Convert.ToInt32(txtAge.Text),
            };

            _repo.Update(patientHeader);
            BindGrid();
            clearForm();
            GoToAddMode();
        }
    }
}
