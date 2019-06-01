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
        public Informations info = new Informations();
        public Operations opr = new Operations();

        public CreateLoginForm()
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
            info.Username = txtUsername.Text;
            info.Password = txtPassword.Text;
            info.Type = txtAccessType.Text;
            int rows = opr.insertLog(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewCreateLogin(info);
                dgvLoginAccount.DataSource = dt;
                dgvLoginAccount.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Login Account Saved";
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.Username = txtUsername.Text;
            info.Password = txtPassword.Text;
            info.Type = txtAccessType.Text;
            int rows = opr.deleteLog(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewCreateLogin(info);
                dgvLoginAccount.DataSource = dt;
                dgvLoginAccount.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Login Account Deleted";
                ClearTextBoxes();
            }
        }

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

        private void CreateLoginForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewCreateLogin(info);
            dgvLoginAccount.DataSource = dt;
            dgvLoginAccount.Columns[0].Visible = false;
        }
    }
}
