using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace gameStore
{
    public partial class GamesPage : Form
    {
        private const string GamesFilePath = "games.txt"; 
        private List<Game> availableGames;

        public GamesPage()
        {
            InitializeComponent();
            availableGames = new List<Game>();
            LoadAvailableGames();
        }

        private void LoadAvailableGames()
        {
            try
            {
                // Read the game details from the text file
                string[] lines = File.ReadAllLines(GamesFilePath);
                foreach (string line in lines)
                {
                    string[] gameDetails = line.Split('\t');
                    if (gameDetails.Length == 4) 
                    {
                        string name = gameDetails[0];
                        decimal price = decimal.Parse(gameDetails[1]);
                        string description = gameDetails[2];
                        string imagePath = gameDetails[3];

                        Game game = new Game(name, price, description, imagePath);
                        availableGames.Add(game);
                    }
                }

                foreach (Game game in availableGames)
                {
                    dataGridView1.Rows.Add(game.Name, game.Price.ToString("C2"), game.Description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available games: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected game from the DataGridView
                Game selectedGame = (Game)dataGridView1.SelectedRows[0].DataBoundItem;

                // Update the Labels, Buttons, and PictureBox with the selected game details
                GameName.Text = selectedGame.Name;
                GamePrice.Text = selectedGame.Price.ToString("C2");
                GameDescription.Text = selectedGame.Description;
                GameImage.Image = Image.FromFile(selectedGame.ImagePath);
            }
            else
            {
                // No game selected, clear the details
                GameName.Text = "";
                GamePrice.Text = "";
                GameDescription.Text = "";
                GameImage.Image = null;
            }
        }

        private void SaveGameDetailsToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("games.txt"))
                {
                    foreach (Game game in availableGames)
                    {
                        writer.WriteLine($"{game.Name}\t{game.Price}\t{game.Description}\t{game.ImagePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving game details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveGameDetailsToFile();
            MessageBox.Show("Game details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid cell is clicked (not a header cell)
            {
                // Get the selected game from the selected row
                Game selectedGame = (Game)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // Update the labels and picture box with the selected game details
                GameName.Text = selectedGame.Name;
                GamePrice.Text = selectedGame.Price.ToString("C2");
                GameDescription.Text = selectedGame.Description;
                GameImage.Image = Image.FromFile(selectedGame.ImagePath);
            }
        }

        private void AddGameToFile(Game newGame)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("games.txt", true))
                {
                    // Write the details of the new game to the file
                    writer.WriteLine($"{newGame.Name}\t{newGame.Price}\t{newGame.Description}\t{newGame.ImagePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding game to the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void addGame_Click(object sender, EventArgs e)
        {
            // Get the details of the new game from the input controls (e.g., text boxes)
            string name = nameTextBox.Text;
            decimal price = decimal.Parse(priceTextBox.Text);
            string description = descriptionTextBox.Text;
            string imagePath = imagePathTextBox.Text;

            // Create a new Game object with the details
            Game newGame = new Game(name, price, description, imagePath);

            // Add the new game to the file
            

            // Update the DataGridView to display the new game
            availableGames.Add(newGame);

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = availableGames;
            RefreshDataGridView();

            // Clear the input controls for the next entry
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
            imagePathTextBox.Text = "";

            GameImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void RefreshDataGridView()
        {
            // Clear the current data source and re-bind the data
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = availableGames;
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.gif;.bmp|All files (*.*)|*.*";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePathTextBox.Text = openFileDialog.FileName;
                }
            }
        }
    }

    public class Game
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public Game(string name, decimal price, string description, string imagePath)
        {
            Name = name;
            Price = price;
            Description = description;
            ImagePath = imagePath;
        }
    }

}