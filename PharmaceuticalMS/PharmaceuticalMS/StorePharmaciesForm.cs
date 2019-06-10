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

    public partial class StorePharmaciesForm : Form
    {
        //Call methods found in operations
        public Operations opr = new Operations();
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

        public StorePharmaciesForm()
        {
            InitializeComponent();
        }
        //Add button will store details found in text boxes
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            Store Store = new Store();

            Store.Name = txtStorName.Text;
            Store.Address = txtStorAddress.Text;
            int rows = opr.insertStore(Store);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getStore();
                dgvStore.DataSource = dt;
                dgvStore.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Store Data Saved";
                ClearTextBoxes();
            }
        }
        //Delete button that will delete records from data base
        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            Store Store = new Store();

            Store.Name = txtStorName.Text;
            Store.Address = txtStorAddress.Text;
            int rows = opr.deleteStore(Store);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getStore();
                dgvStore.DataSource = dt;
                dgvStore.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Store Data Deleted";
                ClearTextBoxes();
            }
        }
        //Edit button will change any details that are found in table
        private void btnAddPhar_Click(object sender, EventArgs e)
        {
            Pharmacy Pharmacy = new Pharmacy();

            Pharmacy.Name = txtPharName.Text;
            Pharmacy.Address = txtPharAddress.Text;
            int rows = opr.insertPharmacy(Pharmacy);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getPharmacy();
                dgvPharmacy.DataSource = dt;
                dgvPharmacy.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Pharmacy Data Saved";
                ClearTextBoxes();
            }
        }
        //Delete button that will delete records from data base
        private void btnDeletePhar_Click(object sender, EventArgs e)
        {
            Pharmacy Pharmacy = new Pharmacy();

            Pharmacy.Name = txtPharName.Text;
            Pharmacy.Address = txtPharAddress.Text;
            int rows = opr.deletePharmacy(Pharmacy);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getPharmacy();
                dgvPharmacy.DataSource = dt;
                dgvPharmacy.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Pharmacy Data Deleted";
                ClearTextBoxes();
            }
        }
        //Load data in data grid view when form opens
        private void StorePharmaciesForm_Load(object sender, EventArgs e)
        {
            DataTable dts = new DataTable();
            dts = opr.getStore();
            dgvStore.DataSource = dts;
            dgvStore.Columns[0].Visible = false;
            DataTable dtp = new DataTable();
            dtp = opr.getPharmacy();
            dgvPharmacy.DataSource = dtp;
            dgvPharmacy.Columns[0].Visible = false;
        }
        //Select text from data view grid 
        private void dgvPharmacy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvPharmacy.Rows[e.RowIndex];
            txtPharName.Text = dgvRow.Cells[1].Value.ToString();
            txtPharAddress.Text = dgvRow.Cells[2].Value.ToString();
        }
        //Select text from data view grid 
        private void dgvStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvStore.Rows[e.RowIndex];
            txtStorName.Text = dgvRow.Cells[1].Value.ToString();
            txtStorAddress.Text = dgvRow.Cells[2].Value.ToString();
        }
        //The text box only accept text
        private void txtStorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        //The text box only accept text
        private void txtPharName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
