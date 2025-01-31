using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class InsuranceTypeForm : Form
    {

        private InsuranceTypeRepository _insuranceRepo = new InsuranceTypeRepository();
        private int globalInsuranceID;

        public InsuranceTypeForm()
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
            insuranceGrid.AutoGenerateColumns = false;
            insuranceGrid.DataSource = null;
            insuranceGrid.DataSource = _insuranceRepo.GetAll();
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            InsuranceType insuranceType = new InsuranceType
            {
                InsuranceTypeID = globalInsuranceID,
                InsuranceTypeName = txtInsuranceType.Text,
                Description = txtInsuranceDescription.Text,
            };

            _insuranceRepo.Update(insuranceType);
            BindGrid();
            clearForm();
            GoToAddMode();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            GoToAddMode();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InsuranceType insuranceType = new InsuranceType
            {
                InsuranceTypeName = txtInsuranceType.Text,
                Description = txtInsuranceDescription.Text,
            };

            _insuranceRepo.Add(insuranceType);
            clearForm();
            BindGrid();
        }

        private void insuranceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.globalInsuranceID = Convert.ToInt32(insuranceGrid.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 3)
            {

                GoToEditMode();
                if (globalInsuranceID != 0)
                {
                    InsuranceType insuranceType = _insuranceRepo.Get(globalInsuranceID);
                    if (insuranceType != null)
                    {
                        txtInsuranceType.Text = insuranceType.InsuranceTypeName;
                        txtInsuranceDescription.Text = insuranceType.Description;
                    }
                }

            }


            if (e.ColumnIndex == 4)
            {

                if (MessageBox.Show("Are you Sure ? ", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = _insuranceRepo.Remove(globalInsuranceID);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }

                }

            }
        }

        private void InsuranceTypeForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
    }
}
