namespace gameStore
{
    partial class LoginPage
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
            this.userNmae_label1 = new System.Windows.Forms.Label();
            this.password_label2 = new System.Windows.Forms.Label();
            this.username_textBox1 = new System.Windows.Forms.TextBox();
            this.password_textBox2 = new System.Windows.Forms.TextBox();
            this.Login_button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // userNmae_label1
            // 
            this.userNmae_label1.AutoSize = true;
            this.userNmae_label1.BackColor = System.Drawing.Color.Linen;
            this.userNmae_label1.Location = new System.Drawing.Point(202, 77);
            this.userNmae_label1.Name = "userNmae_label1";
            this.userNmae_label1.Size = new System.Drawing.Size(55, 13);
            this.userNmae_label1.TabIndex = 0;
            this.userNmae_label1.Text = "Username";
            // 
            // password_label2
            // 
            this.password_label2.AutoSize = true;
            this.password_label2.BackColor = System.Drawing.Color.Linen;
            this.password_label2.Location = new System.Drawing.Point(201, 152);
            this.password_label2.Name = "password_label2";
            this.password_label2.Size = new System.Drawing.Size(53, 13);
            this.password_label2.TabIndex = 1;
            this.password_label2.Text = "Password";
            // 
            // username_textBox1
            // 
            this.username_textBox1.Location = new System.Drawing.Point(198, 99);
            this.username_textBox1.Name = "username_textBox1";
            this.username_textBox1.Size = new System.Drawing.Size(215, 20);
            this.username_textBox1.TabIndex = 2;
            // 
            // password_textBox2
            // 
            this.password_textBox2.Location = new System.Drawing.Point(198, 174);
            this.password_textBox2.Name = "password_textBox2";
            this.password_textBox2.Size = new System.Drawing.Size(215, 20);
            this.password_textBox2.TabIndex = 3;
            // 
            // Login_button1
            // 
            this.Login_button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_button1.Location = new System.Drawing.Point(338, 244);
            this.Login_button1.Name = "Login_button1";
            this.Login_button1.Size = new System.Drawing.Size(75, 23);
            this.Login_button1.TabIndex = 4;
            this.Login_button1.Text = "Login";
            this.Login_button1.UseVisualStyleBackColor = false;
            this.Login_button1.Click += new System.EventHandler(this.Login_button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 180000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_button1);
            this.Controls.Add(this.password_textBox2);
            this.Controls.Add(this.username_textBox1);
            this.Controls.Add(this.password_label2);
            this.Controls.Add(this.userNmae_label1);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNmae_label1;
        private System.Windows.Forms.Label password_label2;
        private System.Windows.Forms.TextBox username_textBox1;
        private System.Windows.Forms.TextBox password_textBox2;
        private System.Windows.Forms.Button Login_button1;
        private System.Windows.Forms.Timer timer1;
    }
}

