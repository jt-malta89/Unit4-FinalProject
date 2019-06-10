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
        //Call methods found in operations
        public Operations opr = new Operations();

        public ClientsForm()
        {
            InitializeComponent();
        }
        //Clear text fields when ClearTextBoxes is called
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
        //Add button will store details found in text boxes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client Client = new Client();

            Client.IDCard = Convert.ToInt32(txtIDCard.Text);
            Client.Name = txtName.Text;
            Client.Surname = txtSurname.Text;
            Client.ContactNo = Convert.ToInt32(txtContactNo.Text);
            Client.Address = txtAddress.Text;
            int rows = opr.insertClient(Client);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getClient();
                dgvClient.DataSource = dt;
                this.StripStatusDisplay.Text = "Client Data Saved";
                ClearTextBoxes();
            }
        }
        //Edit button will change any details that are found in table
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Client Client = new Client();

            Client.IDCard = Convert.ToInt32(txtIDCard.Text);
            Client.Name = txtName.Text;
            Client.Surname = txtSurname.Text;
            Client.ContactNo = Convert.ToInt32(txtContactNo.Text);
            Client.Address = txtAddress.Text;
            int rows = opr.editClient(Client);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getClient();
                dgvClient.DataSource = dt;
                this.StripStatusDisplay.Text = "Client Data Changed";
                ClearTextBoxes();

            }
        }
        //Delete button that will delete records from data base
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Client Client = new Client();

            Client.IDCard = Convert.ToInt32(txtIDCard.Text);
            Client.Name = txtName.Text;
            Client.Surname = txtSurname.Text;
            Client.ContactNo = Convert.ToInt32(txtContactNo.Text);
            Client.Address = txtAddress.Text;
            int rows = opr.deleteClient(Client);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getClient();
                dgvClient.DataSource = dt;
                this.StripStatusDisplay.Text = "Client Data Deleted";
                ClearTextBoxes();
            }
        }
        //Search data by primary key from table
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Client Client = new Client();

            Client.IDCard = Convert.ToInt32(txtSearch.Text);
            DataTable dt = new DataTable();
            dt = opr.SearchClient(Client);
            dgvClient.DataSource = dt;
        }
        //The text box only accept number
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
        //The text box only accept text
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        //The text box only accept text
        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        //The text box only accept number
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
        //Select text from data view grid 
        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvClient.Rows[e.RowIndex];
            txtIDCard.Text = dgvRow.Cells[0].Value.ToString();
            txtName.Text = dgvRow.Cells[1].Value.ToString();
            txtSurname.Text = dgvRow.Cells[2].Value.ToString();
            txtContactNo.Text = dgvRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvRow.Cells[4].Value.ToString();
        }
        //Load data in data grid view when form opens
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.getClient();
            dgvClient.DataSource = dt;
            dgvClient.Columns["IDCard"].HeaderText = "ID Card";
            dgvClient.Columns["Name"].HeaderText = "Name";
            dgvClient.Columns["Surname"].HeaderText = "Surname";
            dgvClient.Columns["ContactNo"].HeaderText = "Contact No";
            dgvClient.Columns["Address"].HeaderText = "Address";
        }
    }
}
