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

        ClientForm cf;
        private void btnClients_Click(object sender, EventArgs e)
        {
            if (cf == null)
            {
                cf = new ClientForm();
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

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            LoginForm myLoginForm = new LoginForm();
            myLoginForm.Show();
            this.Hide();
        }
    }
}
