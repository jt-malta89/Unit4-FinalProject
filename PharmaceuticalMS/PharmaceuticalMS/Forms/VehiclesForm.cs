using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLogic;
using Model;
using DataAccess;

namespace PharmaceuticalMS
{
    public partial class VehiclesForm : Form
    {
        Vehicle model = new Vehicle();

        public VehiclesForm()
        {
            InitializeComponent();
        }

        /*private void VehiclesForm_Load(object sender, EventArgs e)
        {
            
        }*/

        private void btnLoad_Click(object sender, EventArgs e)
        {
            vehicleBindingSource.DataSource = VehiclesServices.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            model.NumberPlate = txtNumberPlate.Text.Trim();
            model.MakeModel = txtMakeModel.Text.Trim();
            model.VehicleType = txtVehicleType.Text.Trim();
            model.FuelType = txtFuelType.Text.Trim();
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                db.Vehicles.Add(model);
                db.SaveChanges();
            }
            MessageBox.Show("Vehicle Saved");
            /*VehiclesServices.Insert(vehicleBindingSource.Current as Vehicle);
            vehicleBindingSource.DataSource = VehiclesServices.GetAll();*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to delete vehicle record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VehiclesServices.Delete(vehicleBindingSource.Current as Vehicle);
                vehicleBindingSource.RemoveCurrent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            VehiclesServices.Update(vehicleBindingSource.Current as Vehicle);
            vehicleBindingSource.DataSource = VehiclesServices.GetAll();
        }
    }
}