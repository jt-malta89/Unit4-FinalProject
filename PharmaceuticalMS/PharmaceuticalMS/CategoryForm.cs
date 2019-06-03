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
    public partial class CategoryForm : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        public CategoryForm()
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
            info.Category = txtCategory.Text;
            int rows = opr.insertCat(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewCategory(info);
                dgvCategory.DataSource = dt;
                dgvCategory.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Category Saved";
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.Category = txtCategory.Text;
            int rows = opr.deleteCat(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewCategory(info);
                dgvCategory.DataSource = dt;
                dgvCategory.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Category Deleted";
                ClearTextBoxes();
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvCategory.Rows[e.RowIndex];
                txtCategory.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewCategory(info);
            dgvCategory.DataSource = dt;
            dgvCategory.Columns[0].Visible = false;
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
