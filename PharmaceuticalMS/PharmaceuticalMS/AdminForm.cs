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

        OrdersForm of;
        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (of == null)
            {
                of = new OrdersForm();
                of.MdiParent = this;
                of.FormClosed += new FormClosedEventHandler(of_FormClosed);
                of.Show();
            }
            else
                of.Activate();
        }
        void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            of = null;
        }

        PoSForm pos;
        private void btnPointOfSale_Click(object sender, EventArgs e)
        {
            if (pos == null)
            {
                pos = new PoSForm();
                pos.MdiParent = this;
                pos.FormClosed += new FormClosedEventHandler(pos_FormClosed);
                pos.Show();
            }
            else
                pos.Activate();
        }
        void pos_FormClosed(object sender, FormClosedEventArgs e)
        {
            pos = null;
        }

        ProductsForm pf;
        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (pf == null)
            {
                pf = new ProductsForm();
                pf.MdiParent = this;
                pf.FormClosed += new FormClosedEventHandler(pf_FormClosed);
                pf.Show();
            }
            else
                pf.Activate();
        }
        void pf_FormClosed(object sender, FormClosedEventArgs e)
        {
            pf = null;
        }

        ClientsForm cl;
        private void btnClients_Click(object sender, EventArgs e)
        {
            if (cl == null)
            {
                cl = new ClientsForm();
                cl.MdiParent = this;
                cl.FormClosed += new FormClosedEventHandler(cl_FormClosed);
                cl.Show();
            }
            else
                cl.Activate();
        }
        void cl_FormClosed(object sender, FormClosedEventArgs e)
        {
            cl = null;
        }

        StorePharmaciesForm spf;
        private void btnStore_Click(object sender, EventArgs e)
        {
            if (spf == null)
            {
                spf = new StorePharmaciesForm();
                spf.MdiParent = this;
                spf.FormClosed += new FormClosedEventHandler(cl_FormClosed);
                spf.Show();
            }
            else
                spf.Activate();
        }
        void spf_FormClosed(object sender, FormClosedEventArgs e)
        {
            spf = null;
        }
    }
}
