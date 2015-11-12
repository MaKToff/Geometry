using System;
using System.Drawing;
using System.Windows.Forms;
using GeomLibrary;

namespace GUI
{
    public partial class GUI : Form
    {
        private Image initImage;
        private bool error = false;

        public GUI()
        {
            InitializeComponent();
            draw();
            initImage = pictureBox.Image;
        }

        /// Clears bitmap.
        private void clear(Bitmap image)
        {
            for (int i = 0; i < pictureBox.Size.Height; i++)
                for (int j = 0; j < pictureBox.Size.Width; j++)
                    image.SetPixel(i, j, Color.White);
        }

        /// Tries to convert value into float.
        private float tryToConvert(String value)
        {
            try
            {
                return float.Parse(value);
            }
            catch (System.FormatException)
            {
                resultTextBox.Text = "Incorrect input";
                error = true;
                return 0.0f;
            }
        }

        /// Draws graph using input data.
        private void draw()
        {
            float x0 = pictureBox.Size.Height / 2;
            float y0 = pictureBox.Size.Width / 2;
            float scale = trackBar.Value * 10;

            float[] x = new float[4] 
            {
                x0 + tryToConvert(pointAx.Text) * scale,
                x0 + tryToConvert(pointBx.Text) * scale,
                x0 + tryToConvert(pointCx.Text) * scale,
                x0 + tryToConvert(pointDx.Text) * scale
            };

            float[] y = new float[4]
            {
                y0 - tryToConvert(pointAy.Text) * scale,
                y0 - tryToConvert(pointBy.Text) * scale,
                y0 - tryToConvert(pointCy.Text) * scale,
                y0 - tryToConvert(pointDy.Text) * scale
            };

            if (error)
            {
                error = false;
                pictureBox.Image = initImage;
            }
            else
            {
                Bitmap image = new Bitmap(pictureBox.Size.Height, pictureBox.Size.Width);
                clear(image);
                Graphics graph = Graphics.FromImage(image);

                // draws axes
                float t = 0;
                graph.DrawLine(Pens.Black, x0, 0.0f, x0, pictureBox.Size.Height);
                graph.DrawLine(Pens.Black, 0.0f, y0, pictureBox.Size.Width, y0);

                while (t < pictureBox.Size.Height)
                {
                    graph.DrawEllipse(Pens.Green, t + x0 - 1.5f, y0 - 1.5f, 3.0f, 3.0f);
                    graph.DrawEllipse(Pens.Green, -t + x0 - 1.5f, y0 - 1.5f, 3.0f, 3.0f);
                    graph.DrawEllipse(Pens.Green, x0 - 1.5f, y0 - t - 1.5f, 3.0f, 3.0f);
                    graph.DrawEllipse(Pens.Green, x0 - 1.5f, y0 + t - 1.5f, 3.0f, 3.0f);
                    t += scale;
                }

                // draws graph
                graph.DrawLine(Pens.Red, x[0], y[0], x[1], y[1]);
                graph.DrawLine(Pens.Red, x[1], y[1], x[2], y[2]);
                graph.DrawLine(Pens.Red, x[2], y[2], x[3], y[3]);
                graph.DrawLine(Pens.Red, x[3], y[3], x[0], y[0]);
                graph.DrawEllipse(Pens.Red, x[0] - 2.0f, y[0] - 2.0f, 4.0f, 4.0f);
                graph.DrawEllipse(Pens.Red, x[1] - 2.0f, y[1] - 2.0f, 4.0f, 4.0f);
                graph.DrawEllipse(Pens.Red, x[2] - 2.0f, y[2] - 2.0f, 4.0f, 4.0f);
                graph.DrawEllipse(Pens.Red, x[3] - 2.0f, y[3] - 2.0f, 4.0f, 4.0f);

                pictureBox.CreateGraphics();
                pictureBox.Image = image;
                pictureBox.Refresh();

                // refreshes result
                Library lib = new Library();
                resultTextBox.Text = lib.result(x, y);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pointAx.Text = "0";
            pointAy.Text = "0";
            pointBx.Text = "0";
            pointBy.Text = "0";
            pointCx.Text = "0";
            pointCy.Text = "0";
            pointDx.Text = "0";
            pointDy.Text = "0";
            trackBar.Value = 5;
            resultTextBox.Text = "";

            pictureBox.Image = initImage;
            error = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            draw();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            draw();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
