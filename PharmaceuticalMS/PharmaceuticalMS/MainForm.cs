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

        AddStaffForm asf;
        private void tsmiAddStaff_Click(object sender, EventArgs e)
        {
            if (asf == null)
            {
                asf = new AddStaffForm();
                asf.MdiParent = this;
                asf.FormClosed += new FormClosedEventHandler(asf_FormClosed);
                asf.WindowState = FormWindowState.Maximized;
                asf.Show();
            }
            else
                asf.Activate();
        }
        void asf_FormClosed(object sender, FormClosedEventArgs e)
        {
            asf = null;
        }

        AddClientForm acf;
        private void tsmiAddClient_Click(object sender, EventArgs e)
        {
            if (acf == null)
            {
                acf = new AddClientForm();
                acf.MdiParent = this;
                acf.FormClosed += new FormClosedEventHandler(asf_FormClosed);
                acf.WindowState = FormWindowState.Maximized;
                acf.Show();
            }
            else
                acf.Activate();
        }
        void acf_FormClosed(object sender, FormClosedEventArgs e)
        {
            acf = null;
        }
    }
}
