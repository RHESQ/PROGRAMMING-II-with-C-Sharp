using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class Form1 : Form
    {
        private List<Point> drawingPoints;
        private bool isDrawing;

        public Form1()
        {
            InitializeComponent();

            drawingPoints = new List<Point>();
            isDrawing = false;
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            drawingPoints.Clear(); // Clear previous drawing points

            // Add the initial mouse position as the starting point for drawing
            drawingPoints.Add(e.Location);
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                // Add the current mouse position to the list of drawing points
                drawingPoints.Add(e.Location);
                drawingBoard.Invalidate(); // Trigger a repaint to update the drawing on the canvas
            }
        }

        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            if (drawingPoints.Count > 1)
            {
                // Draw lines between consecutive points to create the drawing
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    for (int i = 0; i < drawingPoints.Count - 1; i++)
                    {
                        e.Graphics.DrawLine(pen, drawingPoints[i], drawingPoints[i + 1]);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
