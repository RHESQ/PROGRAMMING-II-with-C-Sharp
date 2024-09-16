namespace gameStore
{
    partial class GamesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GameName = new System.Windows.Forms.Label();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.GameImage = new System.Windows.Forms.PictureBox();
            this.GamePrice = new System.Windows.Forms.Label();
            this.GameDescription = new System.Windows.Forms.Label();
            this.SaveGame = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imagePathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(370, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGames_CellClick);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Location = new System.Drawing.Point(490, 28);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(66, 13);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Game Name";
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(727, 28);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(88, 23);
            this.PurchaseButton.TabIndex = 2;
            this.PurchaseButton.Text = "Purchase Game";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // GameImage
            // 
            this.GameImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GameImage.Location = new System.Drawing.Point(370, 16);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(100, 50);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameImage.TabIndex = 3;
            this.GameImage.TabStop = false;
            // 
            // GamePrice
            // 
            this.GamePrice.AutoSize = true;
            this.GamePrice.Location = new System.Drawing.Point(490, 53);
            this.GamePrice.Name = "GamePrice";
            this.GamePrice.Size = new System.Drawing.Size(62, 13);
            this.GamePrice.TabIndex = 4;
            this.GamePrice.Text = "Game Price";
            // 
            // GameDescription
            // 
            this.GameDescription.AutoSize = true;
            this.GameDescription.Location = new System.Drawing.Point(367, 94);
            this.GameDescription.Name = "GameDescription";
            this.GameDescription.Size = new System.Drawing.Size(91, 13);
            this.GameDescription.TabIndex = 5;
            this.GameDescription.Text = "Game Description";
            // 
            // SaveGame
            // 
            this.SaveGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveGame.Location = new System.Drawing.Point(552, 146);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(75, 23);
            this.SaveGame.TabIndex = 6;
            this.SaveGame.Text = "Save Game";
            this.SaveGame.UseVisualStyleBackColor = false;
            this.SaveGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 148);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(180, 148);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(133, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 219);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(130, 20);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add the details to the game you would like \r\n                   to keep in the st" +
    "ore";
            // 
            // addGame
            // 
            this.addGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addGame.Location = new System.Drawing.Point(12, 288);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(75, 23);
            this.addGame.TabIndex = 12;
            this.addGame.Text = "Add Game";
            this.addGame.UseVisualStyleBackColor = false;
            this.addGame.Click += new System.EventHandler(this.addGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name of Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price of the Game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description of the Game";
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Location = new System.Drawing.Point(180, 190);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(89, 23);
            this.buttonBrowseImage.TabIndex = 17;
            this.buttonBrowseImage.Text = "Browse Images";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Location = new System.Drawing.Point(180, 219);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(133, 20);
            this.imagePathTextBox.TabIndex = 18;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(gameStore.Game);
            // 
            // GamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.buttonBrowseImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.GameDescription);
            this.Controls.Add(this.GamePrice);
            this.Controls.Add(this.GameImage);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GamesPage";
            this.Text = "GamesPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.PictureBox GameImage;
        private System.Windows.Forms.Label GamePrice;
        private System.Windows.Forms.Label GameDescription;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.TextBox imagePathTextBox;
    }
}