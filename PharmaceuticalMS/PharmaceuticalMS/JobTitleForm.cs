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
    public partial class JobTitleForm : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        public JobTitleForm()
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
            info.JobTitle = txtJobTitle.Text;
            int rows = opr.insertJobTitle(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewJobTitle(info);
                dgvJobTitle.DataSource = dt;
                dgvJobTitle.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Job Title Saved";
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.JobTitle = txtJobTitle.Text;
            int rows = opr.deleteJobTitle(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewJobTitle(info);
                dgvJobTitle.DataSource = dt;
                dgvJobTitle.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Job Title Deleted";
                ClearTextBoxes();
            }
        }

        private void dgvJobTitle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvJobTitle.Rows[e.RowIndex];
                txtJobTitle.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void JobTitleForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewJobTitle(info);
            dgvJobTitle.DataSource = dt;
            dgvJobTitle.Columns[0].Visible = false;
        }

        private void txtJobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
