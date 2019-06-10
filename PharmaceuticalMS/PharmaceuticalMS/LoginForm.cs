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
        //Call methods found in operations
        public Operations opr = new Operations();
        public string utype;

        DataTable dt = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        //Login account button to check username and pssword, to check what type of privilage the account got
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login Login = new Login();

            Login.Username = txtUsername.Text;
            Login.Password = txtPassword.Text;
            dt = opr.login(Login);

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
        //The username text box only accept text
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}