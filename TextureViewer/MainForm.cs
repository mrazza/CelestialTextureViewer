// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="">
// Copyright (C) 2018 Matthew Razza
// </copyright>
// -----------------------------------------------------------------------

namespace TextureViewer
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private Graphics colorGraphics;
        private Graphics normalGraphics;
        private Bitmap colorBitmap;
        private Bitmap normalBitmap;

        public MainForm()
        {
            this.InitializeComponent();
            this.colorGraphics = this.colorPictureBox.CreateGraphics();
            this.normalGraphics = this.normalPictureBox.CreateGraphics();
        }

        private void colorPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.DrawCross(e.Location);
            this.UpdateNormalInfo(e.Location);
            this.UpdateZoomedImages(e.Location);
        }

        private void normalPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.DrawCross(e.Location);
            this.UpdateNormalInfo(e.Location);
            this.UpdateZoomedImages(e.Location);
        }

        private void UpdateZoomedImages(Point point)
        {
            if (this.normalBitmap != null)
            {
                var localPoint = this.ClampPoint(this.ConvertCoordinates(this.normalPictureBox, point), 0, 0, this.normalBitmap.Width - 1, this.normalBitmap.Height - 1);
                Rectangle cropRect = new Rectangle(localPoint.X - 32, localPoint.Y - 32, 64, 64);
                Bitmap target = new Bitmap(128, 128);

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(this.normalBitmap, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                    g.DrawLine(new Pen(Color.Red, 1), new Point(54, 64), new Point(74, 64));
                    g.DrawLine(new Pen(Color.Red, 1), new Point(64, 54), new Point(64, 74));
                }

                this.zoomedNormalMapPictureBox.Image = target;
                this.zoomedNormalMapPictureBox.Refresh();
            }

            if (this.colorBitmap != null)
            {
                var localPoint = this.ClampPoint(this.ConvertCoordinates(this.colorPictureBox, point), 0, 0, this.colorBitmap.Width - 1, this.colorBitmap.Height - 1);
                Rectangle cropRect = new Rectangle(localPoint.X - 32, localPoint.Y - 32, 64, 64);
                Bitmap target = new Bitmap(128, 128);

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(this.colorBitmap, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                    g.DrawLine(new Pen(Color.Red, 1), new Point(54, 64), new Point(74, 64));
                    g.DrawLine(new Pen(Color.Red, 1), new Point(64, 54), new Point(64, 74));
                }

                this.zoomedColorPictureBox.Image = target;
                this.zoomedColorPictureBox.Refresh();
            }
        }
        
        private Point ConvertCoordinates(PictureBox pictureBox, Point point)
        {
            int resultX = point.X;
            int resultY = point.Y;
            float pictureBoxAspectRatio = pictureBox.ClientSize.Width / (float)pictureBox.ClientSize.Height;
            float imageAspectRatio = pictureBox.Image.Width / (float)pictureBox.Image.Height;
            if (pictureBoxAspectRatio > imageAspectRatio)
            {
                resultY = (int)(pictureBox.Image.Height * point.Y / (float)pictureBox.ClientSize.Height);
                float scaledX = pictureBox.Image.Width * pictureBox.ClientSize.Height / pictureBox.Image.Height;
                float shiftX = (pictureBox.ClientSize.Width - scaledX) / 2;
                resultX = (int)((point.X - shiftX) * pictureBox.Image.Height / (float)pictureBox.ClientSize.Height);
            }
            else
            {
                resultX = (int)(pictureBox.Image.Width * point.X / (float)pictureBox.ClientSize.Width);
                float scaledY = pictureBox.Image.Height * pictureBox.ClientSize.Width / pictureBox.Image.Width;
                float shiftY = (pictureBox.ClientSize.Height - scaledY) / 2;
                resultY = (int)((point.Y - shiftY) * pictureBox.Image.Width / pictureBox.ClientSize.Width);
            }
            return new Point(resultX, resultY);
        }

        private void DrawCross(Point point)
        {
            this.colorPictureBox.Refresh();
            this.colorGraphics.DrawLine(new Pen(Color.Red, 1), new Point(point.X - 10, point.Y), new Point(point.X + 10, point.Y));
            this.colorGraphics.DrawLine(new Pen(Color.Red, 1), new Point(point.X, point.Y - 10), new Point(point.X, point.Y + 10));
            this.normalPictureBox.Refresh();
            this.normalGraphics.DrawLine(new Pen(Color.Red, 1), new Point(point.X - 10, point.Y), new Point(point.X + 10, point.Y));
            this.normalGraphics.DrawLine(new Pen(Color.Red, 1), new Point(point.X, point.Y - 10), new Point(point.X, point.Y + 10));
        }

        private Point ClampPoint(Point point, int minX, int minY, int maxX, int maxY)
        {
            return new Point(Math.Max(minX, Math.Min(maxX, point.X)), Math.Max(minY, Math.Min(maxY, point.Y)));
        }

        private void UpdateNormalInfo(Point position)
        {
            if (this.normalBitmap != null)
            {
                position = this.ClampPoint(this.ConvertCoordinates(this.normalPictureBox, position), 0, 0, normalBitmap.Width - 1, normalBitmap.Height - 1);

                var vector = Vector3.FromPixel(normalBitmap.GetPixel(position.X, position.Y));
                this.normalVectorXValueLabel.Text = vector.X.ToString();
                this.normalVectorXValueLabel.Refresh();
                this.normalVectorYValueLabel.Text = vector.Y.ToString();
                this.normalVectorYValueLabel.Refresh();
                this.normalVectorZValueLabel.Text = vector.Z.ToString();
                this.normalVectorZValueLabel.Refresh();
                this.normalVectorLengthValueLabel.Text = vector.Length.ToString();
                this.normalVectorLengthValueLabel.Refresh();
                this.directionLabel.Text = vector.GetDirectionString();
                this.directionLabel.Refresh();
            }
            else
            {
                this.normalVectorXValueLabel.Text = "N/A";
                this.normalVectorYValueLabel.Text = "N/A";
                this.normalVectorZValueLabel.Text = "N/A";
                this.normalVectorLengthValueLabel.Text = "N/A";
                this.directionLabel.Text = "N/A";
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.colorPictureBox.Refresh();
            this.normalPictureBox.Refresh();
            Cursor.Show();
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void browseNormalButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseDialog = new OpenFileDialog();
            browseDialog.Multiselect = false;
            browseDialog.Title = "Select normal map file...";
            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                this.normalBitmap = new Bitmap(browseDialog.FileName);

                if (this.colorBitmap != null && (this.colorBitmap.Width != this.normalBitmap.Width || this.colorBitmap.Height != this.normalBitmap.Height))
                {
                    this.colorBitmap = null;
                    this.colorPictureBox.Image = null;
                }

                this.normalPictureBox.Image = this.normalBitmap;
            }
        }

        private void browseColorButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseDialog = new OpenFileDialog();
            browseDialog.Multiselect = false;
            browseDialog.Title = "Select color map file...";
            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                this.colorBitmap = new Bitmap(browseDialog.FileName);

                if (this.normalBitmap != null && (this.colorBitmap.Width != this.normalBitmap.Width || this.colorBitmap.Height != this.normalBitmap.Height))
                {
                    this.normalBitmap = null;
                    this.normalPictureBox.Image = null;
                }

                this.colorPictureBox.Image = this.colorBitmap;
            }
        }

        private void normalizeButton_Click(object sender, EventArgs e)
        {
            if (this.normalBitmap == null)
            {
                return;
            }

            for (int x = 0; x < this.normalBitmap.Width; x++)
            {
                for (int y = 0; y < this.normalBitmap.Height; y++)
                {
                    this.normalBitmap.SetPixel(x, y, Vector3.FromPixel(normalBitmap.GetPixel(x, y)).Normalize().ToPixel());
                }
            }

            this.normalPictureBox.Refresh();
        }

        private void numbersOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (e.KeyChar == '-' && text.Length == 0)
            {
                e.Handled = false;
                return;
            }
            
            if (e.KeyChar == '.' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }
            
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void applyTransformationButton_Click(object sender, EventArgs e)
        {
            if (this.normalBitmap == null)
            {
                return;
            }

            float xTransform, yTransform, zTransform;
            try
            {
                xTransform = float.Parse(this.vectorTransformationXTextBox.Text);
                yTransform = float.Parse(this.vectorTransformationYTextBox.Text);
                zTransform = float.Parse(this.vectorTransformationZTextBox.Text);
            }
            catch
            {
                MessageBox.Show("The supplied transformation is not valid.", "Invalid Transformation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Vector3 transformation = new Vector3(xTransform, yTransform, zTransform);

            for (int x = 0; x < this.normalBitmap.Width; x++)
            {
                for (int y = 0; y < this.normalBitmap.Height; y++)
                {
                    this.normalBitmap.SetPixel(x, y, Vector3.FromPixel(normalBitmap.GetPixel(x, y)).Mul(transformation).ToPixel());
                }
            }

            this.normalPictureBox.Refresh();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Export image...";
            saveDialog.DefaultExt = ".png";
            saveDialog.Filter = "PNG Image File (*.png)|*.png";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                this.normalBitmap.Save(saveDialog.FileName, ImageFormat.Png);
            }
        }
    }
}
