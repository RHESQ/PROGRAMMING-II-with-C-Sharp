namespace addressBook
{
    partial class Form1
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
            this.name_textBox1 = new System.Windows.Forms.TextBox();
            this.email_textBox2 = new System.Windows.Forms.TextBox();
            this.phoneNumber_textBox3 = new System.Windows.Forms.TextBox();
            this.save_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textBox1
            // 
            this.name_textBox1.Location = new System.Drawing.Point(133, 87);
            this.name_textBox1.Name = "name_textBox1";
            this.name_textBox1.Size = new System.Drawing.Size(201, 20);
            this.name_textBox1.TabIndex = 0;
            this.name_textBox1.Text = "You Name Here";
            // 
            // email_textBox2
            // 
            this.email_textBox2.Location = new System.Drawing.Point(133, 138);
            this.email_textBox2.Name = "email_textBox2";
            this.email_textBox2.Size = new System.Drawing.Size(201, 20);
            this.email_textBox2.TabIndex = 1;
            this.email_textBox2.Text = "Your Email Address";
            // 
            // phoneNumber_textBox3
            // 
            this.phoneNumber_textBox3.Location = new System.Drawing.Point(133, 192);
            this.phoneNumber_textBox3.Name = "phoneNumber_textBox3";
            this.phoneNumber_textBox3.Size = new System.Drawing.Size(201, 20);
            this.phoneNumber_textBox3.TabIndex = 2;
            this.phoneNumber_textBox3.Text = "Your Phone Number";
            // 
            // save_button1
            // 
            this.save_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.save_button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.save_button1.Location = new System.Drawing.Point(190, 267);
            this.save_button1.Name = "save_button1";
            this.save_button1.Size = new System.Drawing.Size(75, 23);
            this.save_button1.TabIndex = 3;
            this.save_button1.Text = "save";
            this.save_button1.UseVisualStyleBackColor = false;
            this.save_button1.Click += new System.EventHandler(this.save_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 426);
            this.Controls.Add(this.save_button1);
            this.Controls.Add(this.phoneNumber_textBox3);
            this.Controls.Add(this.email_textBox2);
            this.Controls.Add(this.name_textBox1);
            this.Name = "Form1";
            this.Text = "Address Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox1;
        private System.Windows.Forms.TextBox email_textBox2;
        private System.Windows.Forms.TextBox phoneNumber_textBox3;
        private System.Windows.Forms.Button save_button1;
    }
}

