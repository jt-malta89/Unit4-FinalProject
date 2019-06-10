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
    public partial class CreateLoginForm : Form
    {
        public Staff Staff = new Staff();
        //Call methods found in operations
        public Operations opr = new Operations();

        public CreateLoginForm()
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
            Staff.Username = txtUsername.Text;
            Staff.Password = txtPassword.Text;
            Staff.Type = txtAccessType.Text;
            int rows = opr.insertLog(Staff);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getLogin();
                dgvLoginAccount.DataSource = dt;
                dgvLoginAccount.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Login Account Saved";
                ClearTextBoxes();
            }
        }
        //Delete button that will delete records from data base
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff.Username = txtUsername.Text;
            Staff.Password = txtPassword.Text;
            Staff.Type = txtAccessType.Text;
            int rows = opr.deleteLog(Staff);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getLogin();
                dgvLoginAccount.DataSource = dt;
                dgvLoginAccount.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Login Account Deleted";
                ClearTextBoxes();
            }
        }
        //Select text from data view grid 
        private void dgvLoginAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvLoginAccount.Rows[e.RowIndex];
                txtUsername.Text = dgvRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvRow.Cells[2].Value.ToString();
                txtAccessType.Text = dgvRow.Cells[3].Value.ToString();
            }
        }
        //Load data in data grid view when form opens
        private void CreateLoginForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.getLogin();
            dgvLoginAccount.DataSource = dt;
            dgvLoginAccount.Columns[0].Visible = false;
        }
        //The text box only accept text
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        //The text box only accept text
        private void txtAccessType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
