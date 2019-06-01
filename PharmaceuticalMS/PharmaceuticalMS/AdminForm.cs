using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaceuticalMS
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        VehiclesForm vf;
        private void btnVehiclesForm_Click(object sender, EventArgs e)
        {
            if (vf == null)
            {
                vf = new VehiclesForm();
                vf.MdiParent = this;
                vf.FormClosed += new FormClosedEventHandler(vf_FormClosed);
                vf.Show();
            }
            else
                vf.Activate();
        }
        void vf_FormClosed(object sender, FormClosedEventArgs e)
        {
            vf = null;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            LoginForm myLoginForm = new LoginForm();
            myLoginForm.Show();
            this.Hide();
        }

        JobTitleForm jtf;
        private void btnJobTitle_Click(object sender, EventArgs e)
        {
            if (jtf == null)
            {
                jtf = new JobTitleForm();
                jtf.MdiParent = this;
                jtf.FormClosed += new FormClosedEventHandler(jtf_FormClosed);
                jtf.Show();
            }
            else
                jtf.Activate();
        }
        void jtf_FormClosed(object sender, FormClosedEventArgs e)
        {
            jtf = null;
        }

        CategoryForm cf;
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (cf == null)
            {
                cf = new CategoryForm();
                cf.MdiParent = this;
                cf.FormClosed += new FormClosedEventHandler(cf_FormClosed);
                cf.Show();
            }
            else
                cf.Activate();
        }
        void cf_FormClosed(object sender, FormClosedEventArgs e)
        {
            cf = null;
        }

        CreateLoginForm clf;
        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            if (clf == null)
            {
                clf = new CreateLoginForm();
                clf.MdiParent = this;
                clf.FormClosed += new FormClosedEventHandler(clf_FormClosed);
                clf.Show();
            }
            else
                clf.Activate();
        }
        void clf_FormClosed(object sender, FormClosedEventArgs e)
        {
            clf = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        StaffForm sf;
        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (sf == null)
            {
                sf = new StaffForm();
                sf.MdiParent = this;
                sf.FormClosed += new FormClosedEventHandler(sf_FormClosed);
                sf.Show();
            }
            else
                sf.Activate();
        }
        void sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            sf = null;
        }
    }
}
