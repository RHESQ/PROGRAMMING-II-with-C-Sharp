using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameStore
{
    public partial class LoginPage : Form
    {
        private const string baseUsername = "selorm";
        private const string basePassword = "laks@001";

        public LoginPage()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer( )
        {
            timer1 = new Timer();
            timer1.Interval = 180000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Login_button1_Click(object sender, EventArgs e)
        {
            string personaUsername = username_textBox1.Text;
            string personaPassword = password_textBox2.Text;

            if (personaUsername == baseUsername && personaPassword == basePassword)
            {
                //GamesPage gamesPage = new GamesPage();
                //gamesPage.Show();
                //this.Hide();

                ShowGamesPage();
            }
            else
            {
                MessageBox.Show("Login failed\n", "Invalid useername or passwrod, please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowGamesPage()
        {
            GamesPage gamesPage = new GamesPage();
            gamesPage.Show();
            timer1.Stop();
            this.Hide();
        }

        private void HideGamesPage( )
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GamesPage) 
                {
                    form.Hide();
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("You have been loogged out automatically due to inactivity", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Stop();
            timer1.Start();
            HideGamesPage();
        }
    }
}
