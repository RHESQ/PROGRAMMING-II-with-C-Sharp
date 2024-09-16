using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginInScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextBox.Text;

            string message = $" Your Username: {username}\n Your Password: {password}";
            MessageBox.Show(message, "Your Login Info***", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
