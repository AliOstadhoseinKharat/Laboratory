using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Laboratory2
{

    //  TODO ViewModel for Gender
    //  Checked Null in add new patient
    public partial class PatientForm : Form
    {
        private PatientRepository _patientRepository = new PatientRepository();
        private int _patientID;

        public PatientForm()
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



        private void BindGrid()
        {
            dataGridPatient.AutoGenerateColumns = false;
            dataGridPatient.DataSource = null;
            dataGridPatient.DataSource = _patientRepository.GetAllPatients();
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

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clearForm();
            goToAddMode();
        }

        private void PatientForm_Load(object sender, System.EventArgs e)
        {
            BindGrid();
            goToAddMode();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            bool gender = radioFemaleGender.Checked ? false : true;


            Patient patient = new Patient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Mobile = txtMobile.Text,
                NationalCode = txtNationalCode.Text,
                Gender = gender,

            };
            _patientRepository.Add(patient);
            clearForm();
            BindGrid();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            bool gender = radioFemaleGender.Checked ? false : true;


            Patient patient = new Patient
            {
                PatientID = _patientID,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Mobile = txtMobile.Text,
                NationalCode = txtNationalCode.Text,
                Gender = gender,

            };
            _patientRepository.Update(patient);
            clearForm();
            BindGrid();
            goToAddMode();
        }

        private void dataGridPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._patientID = Convert.ToInt32(dataGridPatient.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 7)
            {
                var patient = _patientRepository.Get(_patientID);

                if (patient != null)
                {
                    goToEditMode();
                    txtFirstName.Text = patient.FirstName;
                    txtLastName.Text = patient.LastName;
                    txtAddress.Text = patient.Address;
                    txtMobile.Text = patient.Mobile;
                    txtNationalCode.Text = patient.NationalCode;
                    if (patient.Gender == true)
                    {
                        radioMaleGender.Checked = true;
                        radioFemaleGender.Checked = false;
                    }
                    else
                    {
                        radioFemaleGender.Checked = true;
                        radioMaleGender.Checked = false;
                    }

                }

            }

            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Are you Sure ?", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = _patientRepository.Remove(_patientID);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }
                }

            }
        }
    }
}
