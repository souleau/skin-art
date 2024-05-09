using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace skinart
{
    public partial class SkinArt : Form
    {
        private string skinFilePath;
        private string mapFilePath;
        private Timer fadeTimer;
        private Panel maskPanel;

        public SkinArt()
        {
            InitializeComponent();


            this.Opacity = 0;


            maskPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = this.Height,
                BackColor = this.BackColor
            };

            this.Controls.Add(maskPanel);


            fadeTimer = new Timer
            {
                Interval = 50,
            };
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();


        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.05;


                maskPanel.Height -= (int)(this.Height * 0.05);

                if (maskPanel.Height <= 0)
                {
                    fadeTimer.Stop();
                    maskPanel.Visible = false;
                }
            }
        }

        private void skinbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG Files (*.png)|*.png",
                Title = "Choose your skin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                skinFilePath = openFileDialog.FileName;
                MessageBox.Show($"Selected skin file : {skinFilePath}");
            }
        }

        private void mapbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG Files (*.png)|*.png",
                Title = "Choose your iamge"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mapFilePath = openFileDialog.FileName;
                MessageBox.Show($"Selected image file : {mapFilePath}");
            }
        }


        private void process_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(skinFilePath) || string.IsNullOrEmpty(mapFilePath))
            {
                MessageBox.Show("Please select your skin and image files.");
                return;
            }

            string skinsDirectory = "skins";
            if (!Directory.Exists(skinsDirectory))
            {
                Directory.CreateDirectory(skinsDirectory);
            }


            Image skinImage = Image.FromFile(skinFilePath);
            Bitmap skinBitmap = new Bitmap(skinImage);
            Image mapImage = Image.FromFile(mapFilePath);
            Bitmap mapBitmap = new Bitmap(mapImage);

            using (Graphics g = Graphics.FromImage(skinBitmap))
            {
                Brush brush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
                g.FillRectangle(brush, 40, 8, 8, 8);
            }

            int i = 0;
            int totalSteps = 27;

            for (int face_y = 0; face_y < 3; face_y++)
            {
                for (int face_x = 0; face_x < 9; face_x++)
                {
                    if (i != 0)
                    {
                        int x1 = face_x * 8;
                        int y1 = face_y * 8;
                        int x2 = x1 + 8;
                        int y2 = y1 + 8;

                        Rectangle cropRect = new Rectangle(x1, y1, 8, 8);
                        Bitmap faceImage = mapBitmap.Clone(cropRect, mapBitmap.PixelFormat);
                        Bitmap outputImage = new Bitmap(8, 8);

                        using (Graphics g = Graphics.FromImage(outputImage))
                        {
                            g.DrawImage(faceImage, 0, 0);
                        }

                        int paste_x = face_x * 8;
                        int paste_y = face_y * 8;

                        using (Graphics g = Graphics.FromImage(skinBitmap))
                        {
                            g.DrawImage(outputImage, new Point(8, 8));
                        }

                        string fileName = Path.Combine(skinsDirectory, $"skin_{i}.png");
                        skinBitmap.Save(fileName);
                    }


                    i++;
                    guna2ProgressBar1.Value = (i * 100) / totalSteps;
                }
            }

           
            skinImage.Dispose();
            mapImage.Dispose();
            mapBitmap.Dispose();
            MessageBox.Show("Processing completed. The images were saved in the 'skins' directory.");
        }

        private void ResizeMapImage(string mapFilePath)
        {

            Bitmap mapImage = new Bitmap(mapFilePath);

   
            Bitmap resizedMapImage = new Bitmap(mapImage, new Size(72, 32));

            string outputFilePath = Path.Combine(Path.GetDirectoryName(mapFilePath), "resized_map.png");

            resizedMapImage.Save(outputFilePath);

           
            mapImage.Dispose();
            resizedMapImage.Dispose();

         
            MessageBox.Show($"\r\nThe image was resized to 72x32 pixels and saved as {outputFilePath}.");
        }


        private void processmap_Click(object sender, EventArgs e)
        {
     
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG Files (*.png)|*.png",
                Title = "Choose image"
            };

          
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
   
                string mapFilePath = openFileDialog.FileName;
         

                ResizeMapImage(mapFilePath);
            }
        }

        private void skinPanel_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1 && Path.GetExtension(files[0]).Equals(".png", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void skinPanel_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1 && Path.GetExtension(files[0]).Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                skinFilePath = files[0];
                skinPanel.Refresh();
            }
        }

        private void mapPanel_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1 && Path.GetExtension(files[0]).Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                mapFilePath = files[0];
                mapPanel.Refresh();
            }
        }

        private void mapPanel_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1 && Path.GetExtension(files[0]).Equals(".png", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Yabyeu2SaY");
        }
    }
}