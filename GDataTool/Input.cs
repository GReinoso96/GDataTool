using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDataTool
{
    public partial class Input : UserControl
    {
        public string returnString = "";
        public Input(string input)
        {
            InitializeComponent();
            lblInput.Text += " " + input;
        }
        public string ShowInputDialog(string input)
        {
            return returnString;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            returnString = textBox1.Text;
        }
    }
}
