using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Sprite
    {
        public int oldWidth, oldHeight, newWidth, newHeight;
        public float scaleFactor = 1f;
        public float angleDegrees = 0f;

        Image spriteImage = Image.FromFile(@"C:\Users\Pieter\Desktop\image.png");
        Bitmap bmp;

        public Image GetSprite()
        {
            // Dispose bmp om memory leaks tegen te gaan
            if (bmp != null)
                bmp.Dispose();

            Image image = Image.FromFile(@"C:\Users\Pieter\Desktop\image.png");
            
            oldWidth = image.Width;
            oldHeight = image.Height;

            // Bereken de nieuwe breedte en hoogte van bmp
            double angleRadians = angleDegrees * Math.PI / 180d;

            double cos = Math.Abs(Math.Cos(angleRadians));
            double sin = Math.Abs(Math.Sin(angleRadians));
            newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
            newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);

            // Initialiseer bmp en gfx
            bmp = new Bitmap(newWidth, newHeight);
            Graphics gfx = Graphics.FromImage(bmp);

            scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);

            // Roteer de sprite
            gfx.TranslateTransform(newWidth / 2f, newHeight / 2f);
            gfx.RotateTransform(angleDegrees);
            gfx.TranslateTransform(-oldWidth / 2, -oldHeight / 2);

            // Teken de sprite
            gfx.Clear(Color.Black);
            gfx.DrawImage(image, 0, 0, image.Width, image.Height);

            // Opschonen
            spriteImage.Dispose();
            gfx.Dispose();

            return bmp;
        }
    }
}
