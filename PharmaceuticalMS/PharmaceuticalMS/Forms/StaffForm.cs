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
    public partial class StaffForm : Form
    {
        
        public StaffForm()
        {
            InitializeComponent();
            Load += new EventHandler(StaffForm_Load);
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            staffBindingSource.DataSource = StaffServices.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffServices.Insert(staffBindingSource.Current as Staff);
            staffBindingSource.DataSource = StaffServices.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StaffServices.Delete(staffBindingSource.Current as Staff);
                staffBindingSource.RemoveCurrent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StaffServices.Update(staffBindingSource.Current as Staff);
            staffBindingSource.DataSource = StaffServices.GetAll();
        }
    }
}