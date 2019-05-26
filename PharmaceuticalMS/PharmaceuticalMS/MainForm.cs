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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            LoginForm myLoginForm = new LoginForm();
            myLoginForm.Show();
            this.Hide();
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

        ProductForm pf;
        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (pf == null)
            {
                pf = new ProductForm();
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

        SalesForm slf;
        private void btnSales_Click(object sender, EventArgs e)
        {
            if (slf == null)
            {
                slf = new SalesForm();
                slf.MdiParent = this;
                slf.FormClosed += new FormClosedEventHandler(slf_FormClosed);
                slf.Show();
            }
            else
                slf.Activate();
        }
        void slf_FormClosed(object sender, FormClosedEventArgs e)
        {
            slf = null;
        }

        OptionsForm opf;
        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (opf == null)
            {
                opf = new OptionsForm();
                opf.MdiParent = this;
                opf.FormClosed += new FormClosedEventHandler(opf_FormClosed);
                opf.Show();
            }
            else
                opf.Activate();
        }
        void opf_FormClosed(object sender, FormClosedEventArgs e)
        {
            opf = null;
        }
    }
}
