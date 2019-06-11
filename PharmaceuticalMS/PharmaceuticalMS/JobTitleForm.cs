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
        //Call methods found in operations
        public Operations opr = new Operations();

        public JobTitleForm()
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
            if (txtJobTitle.Text == "")
            {
                MessageBox.Show("Don't Leave the Fields Empty");
            }
            else
            {
                Staff Staff = new Staff();
                Staff.JobTitle = txtJobTitle.Text;
                int rows = opr.insertJobTitle(Staff);
                if (rows > 0)
                {
                    DataTable dt = new DataTable();
                    dt = opr.getJobTitle();
                    dgvJobTitle.DataSource = dt;
                    dgvJobTitle.Columns[0].Visible = false;
                    this.StripStatusDisplay.Text = "Job Title Saved";
                    ClearTextBoxes();
                }
            }
        }
        //Delete button that will delete records from data base
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff Staff = new Staff();
            Staff.JobTitle = txtJobTitle.Text;
            int rows = opr.deleteJobTitle(Staff);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getJobTitle();
                dgvJobTitle.DataSource = dt;
                dgvJobTitle.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Job Title Deleted";
                ClearTextBoxes();
            }
        }
        //Select text from data view grid 
        private void dgvJobTitle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvJobTitle.Rows[e.RowIndex];
                txtJobTitle.Text = dgvRow.Cells[1].Value.ToString();
            }
        }
        //Load data in data grid view when form opens
        private void JobTitleForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.getJobTitle();
            dgvJobTitle.DataSource = dt;
            dgvJobTitle.Columns[0].Visible = false;
        }
        //The text box only accept text
        private void txtJobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
