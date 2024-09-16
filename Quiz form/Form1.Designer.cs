namespace Quizify
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.choice_radioButton1 = new System.Windows.Forms.RadioButton();
            this.choice_radioButton2 = new System.Windows.Forms.RadioButton();
            this.choice_radioButton3 = new System.Windows.Forms.RadioButton();
            this.choice_radioButton4 = new System.Windows.Forms.RadioButton();
            this.next_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(168, 51);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(54, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Questions";
            // 
            // choice_radioButton1
            // 
            this.choice_radioButton1.AutoSize = true;
            this.choice_radioButton1.Location = new System.Drawing.Point(171, 139);
            this.choice_radioButton1.Name = "choice_radioButton1";
            this.choice_radioButton1.Size = new System.Drawing.Size(69, 17);
            this.choice_radioButton1.TabIndex = 1;
            this.choice_radioButton1.TabStop = true;
            this.choice_radioButton1.Text = "choice_1";
            this.choice_radioButton1.UseVisualStyleBackColor = true;
            // 
            // choice_radioButton2
            // 
            this.choice_radioButton2.AutoSize = true;
            this.choice_radioButton2.Location = new System.Drawing.Point(438, 139);
            this.choice_radioButton2.Name = "choice_radioButton2";
            this.choice_radioButton2.Size = new System.Drawing.Size(69, 17);
            this.choice_radioButton2.TabIndex = 2;
            this.choice_radioButton2.TabStop = true;
            this.choice_radioButton2.Text = "choice_2";
            this.choice_radioButton2.UseVisualStyleBackColor = true;
            // 
            // choice_radioButton3
            // 
            this.choice_radioButton3.AutoSize = true;
            this.choice_radioButton3.Location = new System.Drawing.Point(171, 211);
            this.choice_radioButton3.Name = "choice_radioButton3";
            this.choice_radioButton3.Size = new System.Drawing.Size(69, 17);
            this.choice_radioButton3.TabIndex = 3;
            this.choice_radioButton3.TabStop = true;
            this.choice_radioButton3.Text = "choice_3";
            this.choice_radioButton3.UseVisualStyleBackColor = true;
            // 
            // choice_radioButton4
            // 
            this.choice_radioButton4.AutoSize = true;
            this.choice_radioButton4.Location = new System.Drawing.Point(438, 211);
            this.choice_radioButton4.Name = "choice_radioButton4";
            this.choice_radioButton4.Size = new System.Drawing.Size(69, 17);
            this.choice_radioButton4.TabIndex = 4;
            this.choice_radioButton4.TabStop = true;
            this.choice_radioButton4.Text = "choice_4";
            this.choice_radioButton4.UseVisualStyleBackColor = true;
            // 
            // next_button1
            // 
            this.next_button1.BackColor = System.Drawing.Color.LimeGreen;
            this.next_button1.Location = new System.Drawing.Point(432, 293);
            this.next_button1.Name = "next_button1";
            this.next_button1.Size = new System.Drawing.Size(75, 23);
            this.next_button1.TabIndex = 5;
            this.next_button1.Text = "Next";
            this.next_button1.UseVisualStyleBackColor = false;
            this.next_button1.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next_button1);
            this.Controls.Add(this.choice_radioButton4);
            this.Controls.Add(this.choice_radioButton3);
            this.Controls.Add(this.choice_radioButton2);
            this.Controls.Add(this.choice_radioButton1);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "quizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton choice_radioButton1;
        private System.Windows.Forms.RadioButton choice_radioButton2;
        private System.Windows.Forms.RadioButton choice_radioButton3;
        private System.Windows.Forms.RadioButton choice_radioButton4;
        private System.Windows.Forms.Button next_button1;
    }
}

