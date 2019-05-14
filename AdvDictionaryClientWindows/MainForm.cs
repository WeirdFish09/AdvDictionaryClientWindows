using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountTransactions;

namespace AdvDictionaryClientWindows
{
    public partial class MainForm : Form
    {
        int pageCounter = 0;
        public MainForm()
        {
            InitializeComponent();
            LoginRegisterForm loginRegisterForm = new LoginRegisterForm();
            if(loginRegisterForm.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {
                this.Load += (sender, e) => { ((MainForm)sender).Close(); };
            }
        }
    }
}
