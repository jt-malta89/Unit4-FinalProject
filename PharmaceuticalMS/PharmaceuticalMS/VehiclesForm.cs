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
    public partial class VehiclesForm : Form
    {
        public Operations opr = new Operations();
       
        public VehiclesForm()
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
            Vehicles vehicle = new Vehicles();

            vehicle.NumberPlate = txtNumberPlate.Text;
            vehicle.MakeModel = txtMakeModel.Text;
            vehicle.VehicleType = txtVehicleType.Text;
            vehicle.FuelType = txtFuelType.Text;
            int rows = opr.insertVeh(vehicle);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getvehicles();
                dgvVehicles.DataSource = dt;
                dgvVehicles.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Vehicle Data Saved";
                ClearTextBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();

            vehicle.NumberPlate = txtNumberPlate.Text;
            vehicle.MakeModel = txtMakeModel.Text;
            vehicle.VehicleType = txtVehicleType.Text;
            vehicle.FuelType = txtFuelType.Text;
            int rows = opr.deleteVeh(vehicle);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.getvehicles();
                dgvVehicles.DataSource = dt;
                dgvVehicles.Columns[0].Visible = false;
                this.StripStatusDisplay.Text = "Vehicle Data Deleted";
                ClearTextBoxes();
            }
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvVehicles.Rows[e.RowIndex];
                txtNumberPlate.Text = dgvRow.Cells[1].Value.ToString();
                txtMakeModel.Text = dgvRow.Cells[2].Value.ToString();
                txtVehicleType.Text = dgvRow.Cells[3].Value.ToString();
                txtFuelType.Text = dgvRow.Cells[4].Value.ToString();
            }
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();

            DataTable dt = new DataTable();
            dt = opr.getvehicles();
            dgvVehicles.DataSource = dt;
            dgvVehicles.Columns[0].Visible = false;
        }

        private void txtMakeModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtVehicleType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtFuelType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}