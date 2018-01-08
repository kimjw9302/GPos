using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    class MakeBarcode
    {
        public Bitmap Barcode(string num)
        {
            Bitmap bitmap = new Bitmap(num.Length*40,150);
            using (Graphics graphics  = Graphics.FromImage(bitmap))
            {
                Font oFont = new Font("IDAHC39M Code 39 Barcode", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*"+num+"*",oFont,black,point);
            }
      


            return bitmap;
       
        }
        
    }
}
