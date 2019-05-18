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

        CreateStaffForm sf;
        private void tsmiAddStaff_Click(object sender, EventArgs e)
        {
            if (sf == null)
            {
                sf = new CreateStaffForm();
                sf.MdiParent = this;
                sf.FormClosed += new FormClosedEventHandler(sf_FormClosed);
                //asf.WindowState = FormWindowState.Maximized;
                sf.Show();
            }
            else
                sf.Activate();
        }
        void sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            sf = null;
        }

        CreateClientForm cf;
        private void tsmiAddClient_Click(object sender, EventArgs e)
        {
            if (cf == null)
            {
                cf = new CreateClientForm();
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

        private void createStoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
