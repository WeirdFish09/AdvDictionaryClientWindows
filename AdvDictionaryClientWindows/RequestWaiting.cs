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
    public partial class RequestWaiting : Form
    {
        public RequestWaiting(string request)
        {
            InitializeComponent();
            label1.Text = request;
        }

        private void RequestWaiting_Load(object sender, EventArgs e)
        {

        }
    }
}
