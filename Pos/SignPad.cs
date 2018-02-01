using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class SignPad : UserControl
    {
        //펜의 굵기 
        public int PenWidth
        {
            get;
            set;
        }
        //펜이 색깔
        public Color PenColor
        {
            get;
            set;
        }

        public SignPad()
        {
            InitializeComponent();
            PenWidth = 2;
            PenColor = Color.Black;
        }
        public void Clear()
        {
            Image image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
        }
        public void Save()
        {
            bool bResult = true;
            string title = "sign.png";

                using (var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                { 
                    pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);
                    System.Drawing.Imaging.ImageFormat imageFormat = null;
                    var extension = System.IO.Path.GetExtension(title);
                    switch (extension.ToLower())
                    {
                        case ".bmp":
                            imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                        case ".png":
                            imageFormat = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                       case ".jpeg":
                     case ".jpg":
                            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".gif":
                            imageFormat = System.Drawing.Imaging.ImageFormat.Gif;
                            break;
                        default:
                            bResult = false;
                            break;


                    }
           if (bResult)
                        bitmap.Save(title, imageFormat);

                }
            }

        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                Image image = new Bitmap(pictureBox1.Width,pictureBox1.Height);
                if (pictureBox1.Image != null)
                    image = pictureBox1.Image;

                Graphics g = Graphics.FromImage(image);
                g.DrawEllipse(new Pen(PenColor),e.X,e.Y,PenWidth,PenWidth);
                g.FillEllipse(new SolidBrush(PenColor), e.X, e.Y, PenWidth, PenWidth);
                pictureBox1.Image = image;
            }
        }
    }
}
