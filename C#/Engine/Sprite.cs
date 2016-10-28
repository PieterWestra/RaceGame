﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Sprite
    {
        public int newWidth, newHeight;
        public float angleDegrees = 0f;

        Image image = Image.FromFile(@"sprites\car1.png");
        Bitmap bmp;

		public bool right = false;
		public bool left = false;
		public float force = 0f;
		float direction;

		public float xMult, yMult;
		public float x = 0;
		public float y = 0;

		public void Transform()
		{
			if (right)
				angleDegrees += 5;
			if (left)
				angleDegrees -= 5;

			if (angleDegrees >= 360)
				angleDegrees -= 360;
			if (angleDegrees < 0)
				angleDegrees += 360;

			// MOVEMENT
			if (angleDegrees >= 0 && angleDegrees < 90)
			{
				direction = (90 - angleDegrees) * 0.0174533f;

				xMult = (float)Math.Sin(direction);
				yMult = (float)(Math.Sqrt(1 - Math.Pow(xMult, 2)));

				x += force * xMult;
				y += force * yMult;
			}
			if (angleDegrees >= 90 && angleDegrees < 180)
			{
				direction = (180 - angleDegrees) * 0.0174533f;

				yMult = (float)Math.Sin(direction);
				xMult = (float)(Math.Sqrt(1 - Math.Pow(yMult, 2)));

				x -= force * xMult;
				y += force * yMult;
			}
			if (angleDegrees >= 180 && angleDegrees < 270)
			{
				direction = (270 - angleDegrees) * 0.0174533f;

				xMult = (float)Math.Sin(direction);
				yMult = (float)(Math.Sqrt(1 - Math.Pow(xMult, 2)));

				x -= force * xMult;
				y -= force * yMult;
			}
			if (angleDegrees >= 270 && angleDegrees < 360)
			{
				direction = (360 - angleDegrees) * 0.0174533f;

				yMult = (float)Math.Sin(direction);
				xMult = (float)(Math.Sqrt(1 - Math.Pow(yMult, 2)));

				x += force * xMult;
				y -= force * yMult;
			}
		}

        public Image GetSprite(int initialRotation = 0)
        {
            // Dispose bmp om memory leaks tegen te gaan
            if (bmp != null)
                bmp.Dispose();

            // Bereken de nieuwe breedte en hoogte van bmp
            double angleRadians = angleDegrees * Math.PI / 180d;

            double cos = Math.Abs(Math.Cos(angleRadians));
            double sin = Math.Abs(Math.Sin(angleRadians));
            newWidth = (int)Math.Round(image.Width * cos + image.Height * sin);
            newHeight = (int)Math.Round(image.Width * sin + image.Height * cos);

            // Initialiseer bmp en gfx
            bmp = new Bitmap(newWidth, newHeight);
            Graphics gfx = Graphics.FromImage(bmp);

			// Wordt nog niet gebruikt, hiermee kan de schaal aangepast worden
            // scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);

            // Roteer de sprite
            gfx.TranslateTransform(newWidth / 2f, newHeight / 2f);
            gfx.RotateTransform(angleDegrees + initialRotation);
            gfx.TranslateTransform(-image.Width / 2, -image.Height / 2);

            // Teken de sprite
            gfx.Clear(Color.Black);
            gfx.DrawImage(image, 0, 0, image.Width, image.Height);

            // gfx disposen
            gfx.Dispose();

            return bmp;
        }
    }
}