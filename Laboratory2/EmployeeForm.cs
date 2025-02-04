using DataAccess;
using DomainModel.Models;
using System;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class EmployeeForm : Form
    {

        private EmployeeRepository _repo = new EmployeeRepository();
        private int _empID;
        public EmployeeForm()
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
            }
            this.Refresh();
        }




        private void BindGrid()
        {
            dataGridEmployee.AutoGenerateColumns = false;
            dataGridEmployee.DataSource = null;
            dataGridEmployee.DataSource = _repo.GetAll();
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

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Employee emp = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Mobile = txtMobile.Text,
            };
            _repo.Add(emp);
            clearForm();
            BindGrid();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            Employee emp = new Employee
            {
                EmployeeID = this._empID,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Mobile = txtMobile.Text,
            };

            _repo.Update(emp);
            BindGrid();
            clearForm();
            goToAddMode();
        }

        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._empID = Convert.ToInt32(dataGridEmployee.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 6)
            {
                var employee = _repo.Get(_empID);
                goToEditMode();

                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtUserName.Text = employee.UserName;
                txtPassword.Text = employee.Password;
                txtMobile.Text = employee.Mobile;
            }


            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you Sure ?", "alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool result = _repo.Remove(_empID);
                    if (result == true) { BindGrid(); }
                    else { MessageBox.Show("Delete Failed"); }
                }
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            goToAddMode();
        }
    }
}
