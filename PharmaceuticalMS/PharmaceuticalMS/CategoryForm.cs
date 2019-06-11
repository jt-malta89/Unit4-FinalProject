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
        //Call methods found in operations
        public Operations opr = new Operations();

        public CategoryForm()
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
        //Add button will store details found in txtCategory 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                MessageBox.Show("Don't Leave the Fields Empty");
            }
            else
            {
                Categories Category = new Categories();
                Category.Category = txtCategory.Text;
                int rows = opr.insertCat(Category);
                if (rows > 0)
                {
                    DataTable dt = new DataTable();
                    dt = opr.getCategory();
                    dgvCategory.DataSource = dt;
                    dgvCategory.Columns[0].Visible = false;
                    this.StripStatusDisplay.Text = "Category Saved";
                    ClearTextBoxes();
                }
            }
        }
        //Delete button that will delete records from data base 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Categories Category = new Categories();

            Category.Category = txtCategory.Text;
            int rows = opr.deleteCat(Category);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getCategory();
                dgvCategory.DataSource = dt;
                dgvCategory.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Category Deleted";
                ClearTextBoxes();
            }
        }
        //Select text from data view grid 
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvCategory.Rows[e.RowIndex];
                txtCategory.Text = dgvRow.Cells[1].Value.ToString();
            }
        }
        //Load data in data grid view when from opens
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Categories Category = new Categories();

            DataTable dt = new DataTable();
            dt = opr.getCategory();
            dgvCategory.DataSource = dt;
            dgvCategory.Columns[0].Visible = false;
        }
        //The category text box only accept text
        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
