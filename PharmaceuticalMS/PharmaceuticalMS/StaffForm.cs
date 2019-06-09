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
            Staff Staff = new Staff();

            Staff.IDCard = Convert.ToInt32(txtSearch.Text);
            DataTable dt = new DataTable();
            dt = opr.SearchStaff(Staff);
            dgvStaff.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff Staff = new Staff();

            Staff.IDCard = Convert.ToInt32(txtIDCard.Text);
            Staff.Name = txtName.Text;
            Staff.Surname = txtSurname.Text;
            Staff.ContactNo = Convert.ToInt32(txtContactNo.Text);
            Staff.Salary = Convert.ToInt32(txtSalary.Text);
            Staff.Address = txtAddress.Text;
            Staff.JobTitleID = Convert.ToInt32(txtJobTitleID.Text);
            Staff.VehicleID = Convert.ToInt32(txtVehicleID.Text);
            Staff.LoginID = Convert.ToInt32(txtLoginAccountID.Text);
            int rows = opr.insertStaff(Staff);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getStaff();
                dgvStaff.DataSource = dt;
                this.StripStatusDisplay.Text = "Staff Data Saved";
                ClearTextBoxes();
            }
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            Staff Staff = new Staff();

            Staff.IDCard = Convert.ToInt32(txtIDCard.Text);
            Staff.Name = txtName.Text;
            Staff.Surname = txtSurname.Text;
            Staff.ContactNo = Convert.ToInt32(txtContactNo.Text);
            Staff.Salary = Convert.ToInt32(txtSalary.Text);
            Staff.Address = txtAddress.Text;
            Staff.JobTitleID = Convert.ToInt32(txtJobTitleID.Text);
            Staff.VehicleID = Convert.ToInt32(txtVehicleID.Text);
            Staff.LoginID = Convert.ToInt32(txtLoginAccountID.Text);
            int rows = opr.editStaff(Staff);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getStaff();
                dgvStaff.DataSource = dt;
                this.StripStatusDisplay.Text = "Staff Data Changed";
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff Staff = new Staff();

            Staff.IDCard = Convert.ToInt32(txtIDCard.Text);
            Staff.Name = txtName.Text;
            Staff.Surname = txtSurname.Text;
            Staff.ContactNo = Convert.ToInt32(txtContactNo.Text);
            Staff.Salary = Convert.ToInt32(txtSalary.Text);
            Staff.Address = txtAddress.Text;
            Staff.JobTitleID = Convert.ToInt32(txtJobTitleID.Text);
            Staff.VehicleID = Convert.ToInt32(txtVehicleID.Text);
            Staff.LoginID = Convert.ToInt32(txtLoginAccountID.Text);
            int rows = opr.deleteStaff(Staff);
            if (rows > 0)
            {
                DataTable st = new DataTable();
                st = opr.getStaff();
                dgvStaff.DataSource = st;
                this.StripStatusDisplay.Text = "Staff Data Deleted";
                ClearTextBoxes();
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.getStaff();
            dgvStaff.DataSource = dt;
            dgvStaff.Columns["IDCard"].HeaderText = "ID Card";
            dgvStaff.Columns["Name"].HeaderText = "Name";
            dgvStaff.Columns["Surname"].HeaderText = "Surname";
            dgvStaff.Columns["ContactNo"].HeaderText = "Contact No";
            dgvStaff.Columns["Salary"].HeaderText = "Salary";
            dgvStaff.Columns["Address"].HeaderText = "Address";
            dgvStaff.Columns["JobTitleID"].HeaderText = "Job Title";
            dgvStaff.Columns["VehicleID"].HeaderText = "Vehicle";
            dgvStaff.Columns["LoginID"].HeaderText = "Login";
            cbJobTitle.Items.Clear();
            this.cbJobTitle.DataSource = new Operations().getJobTitle();
            this.cbJobTitle.DisplayMember = "JobTitle";
            this.cbVehicle.Refresh();
            this.cbVehicle.DataSource = new Operations().getvehicles();
            this.cbVehicle.DisplayMember = "NumberPlate";
            this.cbVehicle.Refresh();
            this.cbLoginAccount.DataSource = new Operations().getLogin();
            this.cbLoginAccount.DisplayMember = "Username";
            this.cbLoginAccount.Refresh();
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

        private void cbJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.cbJobTitle.SelectedItem;
            txtJobTitleID.Text = drv["JobTitleID"].ToString();
        }

        private void cbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.cbVehicle.SelectedItem;
            txtVehicleID.Text = drv["VehicleID"].ToString();
        }

        private void cbLoginAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.cbLoginAccount.SelectedItem;
            txtLoginAccountID.Text = drv["LoginID"].ToString();
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
    }
}