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
    public partial class LoginForm : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        public string utype;

        DataTable dt = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            info.Username = txtUsername.Text;
            info.Password = txtPassword.Text;
            dt = opr.login(info);

            if (dt.Rows.Count > 0)
            {
                utype = dt.Rows[0][3].ToString().Trim();
                if (utype == "Admin")
                {
                    this.Hide();
                    AdminForm mda = new AdminForm();
                    mda.Show();
                }
                else
                {
                    this.Hide();
                    UserForm mde = new UserForm();
                    mde.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}