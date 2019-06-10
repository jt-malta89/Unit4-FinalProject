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
    public partial class ProductsForm : Form
    {
        //Call methods found in operations
        public Operations opr = new Operations();

        public ProductsForm()
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
        //Load data in data grid view when form opens
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.getproduct();
            dgvProducts.DataSource = dt;
            dgvProducts.Columns["Barcode"].HeaderText = "Barcode";
            dgvProducts.Columns["ItemName"].HeaderText = "Item Name";
            dgvProducts.Columns["ItemDescription"].HeaderText = "Item Description";
            dgvProducts.Columns["NotifThre"].HeaderText = "Quantity Notification";
            dgvProducts.Columns["Price"].HeaderText = "Price";
            dgvProducts.Columns["Quantity"].HeaderText = "Quantity";
            dgvProducts.Columns["StoreID"].HeaderText = "Store";
            dgvProducts.Columns["CategoryID"].HeaderText = "Category";
            this.cbCategory.DataSource = new Operations().getCategory();
            this.cbCategory.DisplayMember = "Category";
            this.cbCategory.Refresh();
            this.cbStore.DataSource = new Operations().getStore();
            this.cbStore.DisplayMember = "Name";
            this.cbStore.Refresh();
        }
        //Add button will store details found in text boxes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            product.Barcode = Convert.ToInt32(txtBarcode.Text);
            product.ItemName = txtTitle.Text;
            product.ItemDescription = txtDescription.Text;
            product.NotifThre = Convert.ToInt32(txtQuantityNotification.Text);
            product.Price = txtPrice.Text;
            product.Quantity = Convert.ToInt32(txtQuantity.Text);
            product.StoreID = Convert.ToInt32(txtStore.Text);
            product.CategoryID = Convert.ToInt32(txtCategory.Text);
            int rows = opr.insertProduct(product);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getproduct();
                dgvProducts.DataSource = dt;
                this.StripStatusDisplay.Text = "Product Data Saved";
                ClearTextBoxes();
            }
        }
        //Delete button that will delete records from data base
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            product.Barcode = Convert.ToInt32(txtBarcode.Text);
            product.ItemName = txtTitle.Text;
            product.ItemDescription = txtDescription.Text;
            product.NotifThre = Convert.ToInt32(txtQuantityNotification.Text);
            product.Price = txtPrice.Text;
            product.Quantity = Convert.ToInt32(txtQuantity.Text);
            product.StoreID = Convert.ToInt32(txtStore.Text);
            product.CategoryID = Convert.ToInt32(txtCategory.Text);
            int rows = opr.deleteproduct(product);
            if (rows > 0)
            {
                DataTable st = new DataTable();
                st = opr.getproduct();
                dgvProducts.DataSource = st;
                this.StripStatusDisplay.Text = "Product Data Deleted";
                ClearTextBoxes();
            }
        }
        //Edit button will change any details that are found in table
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            product.Barcode = Convert.ToInt32(txtBarcode.Text);
            product.ItemName = txtTitle.Text;
            product.ItemDescription = txtDescription.Text;
            product.NotifThre = Convert.ToInt32(txtQuantityNotification.Text);
            product.Price = txtPrice.Text;
            product.Quantity = Convert.ToInt32(txtQuantity.Text);
            product.StoreID = Convert.ToInt32(txtStore.Text);
            product.CategoryID = Convert.ToInt32(txtCategory.Text);
            int rows = opr.editproduct(product);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getproduct();
                dgvProducts.DataSource = dt;
                this.StripStatusDisplay.Text = "Product Data Changed";
                ClearTextBoxes();
            }
        }
        //Select text from data view grid 
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvProducts.Rows[e.RowIndex];
            txtBarcode.Text = dgvRow.Cells[0].Value.ToString();
            txtTitle.Text = dgvRow.Cells[1].Value.ToString();
            txtDescription.Text = dgvRow.Cells[2].Value.ToString();
            txtQuantityNotification.Text = dgvRow.Cells[3].Value.ToString();
            txtPrice.Text = dgvRow.Cells[4].Value.ToString();
            txtQuantity.Text = dgvRow.Cells[5].Value.ToString();
            txtStore.Text = dgvRow.Cells[6].Value.ToString();
            txtCategory.Text = dgvRow.Cells[7].Value.ToString();
        }
        //Fill combo box with details from table
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.cbCategory.SelectedItem;
            txtCategory.Text = drv["CategoryID"].ToString();
        }
        //Fill combo box with details from table
        private void cbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.cbStore.SelectedItem;
            txtStore.Text = drv["StoreID"].ToString();
        }
        //The text box only accept number
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        //The text box only accept text
        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        //The text box only accept number
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
        //The text box only accept number
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
        //The text box only accept number
        private void txtQuantityNotification_KeyPress(object sender, KeyPressEventArgs e)
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
        //Search data by primary key from table
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Products product = new Products();

            product.Barcode = Convert.ToInt32(txtSearch.Text);
            DataTable dt = new DataTable();
            dt = opr.SearchProduct(product);
            dgvProducts.DataSource = dt;
        }
        //The text box only accept number
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
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