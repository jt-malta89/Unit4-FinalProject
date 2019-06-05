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
    public partial class ClientsForm : Form
    {
        //public Informations info = new Informations();
        public Operations opr = new Operations();

        public ClientsForm()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Informations info = new Informations();

            info.IDCard = txtIDCard.Text;
            info.Name = txtName.Text;
            info.Surname = txtSurname.Text;
            info.ContactNo = txtContactNo.Text;
            info.Address = txtAddress.Text;
            int rows = opr.insertClient(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewClient(info);
                dgvClient.DataSource = dt;
                this.StripStatusVehicles.Text = "Client Data Saved";
                ClearTextBoxes();
            }
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            Informations info = new Informations();

            info.IDCard = txtIDCard.Text;
            info.Name = txtName.Text;
            info.Surname = txtSurname.Text;
            info.ContactNo = txtContactNo.Text;
            info.Address = txtAddress.Text;
            int rows = opr.editClient(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewClient(info);
                dgvClient.DataSource = dt;
                this.StripStatusVehicles.Text = "Client Data Changed";
                ClearTextBoxes();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Informations info = new Informations();

            info.IDCard = txtIDCard.Text;
            info.Name = txtName.Text;
            info.Surname = txtSurname.Text;
            info.ContactNo = txtContactNo.Text;
            info.Address = txtAddress.Text;
            int rows = opr.deleteClient(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewClient(info);
                dgvClient.DataSource = dt;
                this.StripStatusVehicles.Text = "Client Data Deleted";
                ClearTextBoxes();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Informations info = new Informations();

            info.IDCard = txtSearch.Text;
            DataTable dt = new DataTable();
            dt = opr.SearchClient(info);
            dgvClient.DataSource = dt;
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
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

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvClient.Rows[e.RowIndex];
            txtIDCard.Text = dgvRow.Cells[0].Value.ToString();
            txtName.Text = dgvRow.Cells[1].Value.ToString();
            txtSurname.Text = dgvRow.Cells[2].Value.ToString();
            txtContactNo.Text = dgvRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvRow.Cells[4].Value.ToString();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            Informations info = new Informations();
            DataTable dt = new DataTable();
            dt = opr.viewClient(info);
            dgvClient.DataSource = dt;
        }
    }
}
