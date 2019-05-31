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
        public Informations info = new Informations();
        public Operations opr = new Operations();
       
        public VehiclesForm()
        {
            InitializeComponent();
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewvehicles(info);
            dgvVehicles.DataSource = dt;
            dgvVehicles.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            info.NumberPlate = txtNumberPlate.Text;
            info.MakeModel = txtMakeModel.Text;
            info.VehicleType = txtVehicleType.Text;
            info.FuelType = txtFuelType.Text;
            int rows = opr.insertVeh(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewvehicles(info);
                dgvVehicles.DataSource = dt;
                dgvVehicles.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Vehicle Data Saved";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.viewvehicles(info);
            dgvVehicles.DataSource = dt;
            dgvVehicles.Columns[0].Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            info.NumberPlate = txtNumberPlate.Text;
            info.MakeModel = txtMakeModel.Text;
            info.VehicleType = txtVehicleType.Text;
            info.FuelType = txtFuelType.Text;
            int rows = opr.updateVeh(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewvehicles(info);
                dgvVehicles.DataSource = dt;
                dgvVehicles.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Vehicle Data Changed";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.NumberPlate = txtNumberPlate.Text;
            info.MakeModel = txtMakeModel.Text;
            info.VehicleType = txtVehicleType.Text;
            info.FuelType = txtFuelType.Text;
            int rows = opr.deleteVeh(info);
            if (rows > 0)
            {
                DataTable dt = new DataTable();
                dt = opr.viewvehicles(info);
                dgvVehicles.DataSource = dt;
                dgvVehicles.Columns[0].Visible = false;
                this.StripStatusVehicles.Text = "Vehicle Data Deleted";
            }
        }
    }
}