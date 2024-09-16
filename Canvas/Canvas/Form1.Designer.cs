namespace Canvas
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
            this.drawingBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // drawingBoard
            // 
            this.drawingBoard.BackColor = System.Drawing.Color.White;
            this.drawingBoard.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.drawingBoard.Location = new System.Drawing.Point(12, 12);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(547, 327);
            this.drawingBoard.TabIndex = 0;
            this.drawingBoard.UseWaitCursor = true;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.drawingBoard);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form1";
            this.Text = "drawingCanvas";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingBoard;
    }
}

