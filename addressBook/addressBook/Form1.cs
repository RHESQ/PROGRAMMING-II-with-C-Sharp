using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addressBook
{
    public partial class Form1 : Form
    {
        private const string fileName = "address_book.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void save_button1_Click(object sender, EventArgs e)
        {

            string name = name_textBox1.Text;
            string email = email_textBox2.Text;
            string phone = phoneNumber_textBox3.Text;

            try
            {
                using (StreamWriter writer = new StreamWriter (fileName, true))
                {
                    writer.WriteLine($"Name: {name}, Email: {email}, Phone: {phone}");
                }

                MessageBox.Show("Information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error saving information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

            string message = $"Name: {name}\n Email: {email}\n Phone: {phone}";
            MessageBox.Show(message, "Saved Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            name_textBox1.Clear();
            email_textBox2.Clear();
            phoneNumber_textBox3.Clear();
        }
    }
}
