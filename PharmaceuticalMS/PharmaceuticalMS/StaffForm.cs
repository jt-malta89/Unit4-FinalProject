using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace PharmaceuticalMS
{
    public partial class StaffForm : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        public StaffForm()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            info.IDCard = txtSearch.Text;
            DataTable dt = new DataTable();
            dt = opr.SearchStaff(info);
            dgvStaff.DataSource = dt;
            //dgvStaff.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            info.IDCard = txtIDCard.Text;
            info.Name = txtName.Text;
            info.Surname = txtSurname.Text;
            info.ContactNo = txtContactNo.Text;
            info.Salary = txtSalary.Text;
            info.Address = txtAddress.Text;
            info.JobTitleID = txtJobTitleID.Text;
            info.VehicleID = txtVehicleID.Text;
            info.LoginID = txtLoginAccountID.Text;
            int rows = opr.insertStaff(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewStaff(info);
                dgvStaff.DataSource = dt;
                //dgvStaff.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Staff Data Saved";
                ClearTextBoxes();
            }
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            info.IDCard = txtIDCard.Text;
            info.Name = txtName.Text;
            info.Surname = txtSurname.Text;
            info.ContactNo = txtContactNo.Text;
            info.Salary = txtSalary.Text;
            info.Address = txtAddress.Text;
            info.JobTitleID = txtJobTitleID.Text;
            info.VehicleID = txtVehicleID.Text;
            info.LoginID = txtLoginAccountID.Text;
            int rows = opr.editStaff(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewStaff(info);
                dgvStaff.DataSource = dt;
                //dgvStaff.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Staff Data Changed";
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.IDCard = txtIDCard.Text;
            info.Name = txtName.Text;
            info.Surname = txtSurname.Text;
            info.ContactNo = txtContactNo.Text;
            info.Salary = txtSalary.Text;
            info.Address = txtAddress.Text;
            info.JobTitleID = txtJobTitleID.Text;
            info.VehicleID = txtVehicleID.Text;
            info.LoginID = txtLoginAccountID.Text;
            int rows = opr.deleteStaff(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewStaff(info);
                dgvStaff.DataSource = dt;
                //dgvStaff.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Staff Data Deleted";
                ClearTextBoxes();
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewStaff(info);
            dgvStaff.DataSource = dt;
            //dgvStaff.Columns[0].Visible = false;
            DataTable dt1 = new DataTable();
            dt1 = opr.viewJobTitle(info);
            dgvJobTitle.DataSource = dt1;
            DataTable dt2 = new DataTable();
            dt2 = opr.viewvehicles(info);
            dgvVehicle.DataSource = dt2;
            dgvVehicle.Columns[2].Visible = false;
            dgvVehicle.Columns[3].Visible = false;
            dgvVehicle.Columns[4].Visible = false;
            DataTable dt3 = new DataTable();
            dt3 = opr.viewCreateLogin(info);
            dgvLoginAccount.DataSource = dt3;
            dgvLoginAccount.Columns[2].Visible = false;
            dgvLoginAccount.Columns[3].Visible = false;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvStaff.Rows[e.RowIndex];
                txtIDCard.Text = dgvRow.Cells[0].Value.ToString();
                txtName.Text = dgvRow.Cells[1].Value.ToString();
                txtSurname.Text = dgvRow.Cells[2].Value.ToString();
                txtContactNo.Text = dgvRow.Cells[3].Value.ToString();
                txtSalary.Text = dgvRow.Cells[4].Value.ToString();
                txtAddress.Text = dgvRow.Cells[5].Value.ToString();
                txtJobTitleID.Text = dgvRow.Cells[6].Value.ToString();
                txtVehicleID.Text = dgvRow.Cells[7].Value.ToString();
                txtLoginAccountID.Text = dgvRow.Cells[8].Value.ToString();
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
             {
                e.Handled = false;
             }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space); 
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtJobTitleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtVehicleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtLoginAccountID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter only Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }
    }
}