using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvDictionaryClientWindows
{
    public partial class LoginRegisterForm : Form
    {
        public bool RememberMe { get; private set; }
        private bool newUser = false;
        public LoginRegisterForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (newUser)
            {
                RememberMe = checkBoxRememberMe.Checked;
                success = await Register();
            }
            else
            {
                RememberMe = checkBoxRememberMe.Checked;
                success = await Login();
            }
            if(success)
            {
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            newUser = !newUser;
            if (newUser) {
                labelConfirmPassword.Visible = true;
                textBoxConfirmPassword.Visible = true;
                labelRegister.Text = "Back to Login";
                buttonRegister.Text = "Login";
                buttonLogin.Text = "Register";
            } else
            {
                labelConfirmPassword.Visible = false;
                textBoxConfirmPassword.Visible = false;
                labelRegister.Text = "New Here? Register!";
                buttonRegister.Text = "Register";
                buttonLogin.Text = "Login";
            }
        }

        private async Task<bool> Login()
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            //add login 
            return true;
        }

        private async Task<bool> Register()
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            //return add register
            return true;
        }
    }
}
