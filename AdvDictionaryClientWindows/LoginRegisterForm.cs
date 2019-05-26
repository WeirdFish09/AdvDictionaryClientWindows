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
            RequestWaiting requestWaiting;
            if (newUser)
            {
                requestWaiting = new RequestWaiting("Registering new user");
                if (!requestWaiting.IsHandleCreated)
                {
                    requestWaiting.CreateControl();
                }
                this.BeginInvoke(new Action(() => requestWaiting.ShowDialog()));
                success = await Register();
                requestWaiting.Close();
            }else
            {
                requestWaiting = new RequestWaiting("Logging in");
                if (!requestWaiting.IsHandleCreated)
                {
                    requestWaiting.CreateControl();
                }
                this.BeginInvoke(new Action(() => 
                {
                    requestWaiting.ShowDialog();
                }));
                success = await Login();
                requestWaiting.Close();                
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
            return await Controller.Login(email, password);
        }

        private async Task<bool> Register()
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            return await Controller.Register(email, password,"english");
        }
    }
}
