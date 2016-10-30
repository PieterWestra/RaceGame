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
		public Rectangle collisionCenter1;
		public Rectangle collisionCenter2;
		public Rectangle collisionFront;
		public Rectangle collisionBack;

        #region declaring variables
        public int newWidth, newHeight;
        public float angleDegrees = 0f;

        public Image image = Image.FromFile(@"resources\sprites\car1.png");
        private Bitmap bmp;

		public bool right = false;
		public bool left = false;
		public bool reverse = false;
		public float force = 0f;
		private float direction;

        public bool Throttle = false;   // needed for the redesign of the the speed-o-meter
        public bool Brake = false;      // comment for later.
        public short Speed = 0;

		public float xMult, yMult;
		public float x = 0;
		public float y = 0;
        #endregion

		// TESTVERSIE VAN COLLISIDERS MET HARDCODED FORMULES
		public void Collider()
		{
			if (angleDegrees >= 0 && angleDegrees < 90)
			{
				collisionCenter1 = new Rectangle(new Point(
					(int)(x + 16 * (xMult - .9f)),
					(int)(y - 16 / (yMult + 1f))),
					new Size(32, 32));

				collisionCenter2 = new Rectangle(new Point(
					(int)(x - 24 * (xMult + .55f)),
					(int)(y - 16 * (yMult + 1f))),
					new Size(32, 32));
			}
			if (angleDegrees >= 90 && angleDegrees < 180)
			{
				collisionCenter1 = new Rectangle(new Point(
					(int)(x - 16 * (xMult + .9f)),
					(int)(y - 16 / (yMult + 1f))),
					new Size(32, 32));

				collisionCenter2 = new Rectangle(new Point(
					(int)(x - 24 / (xMult + 1.7f)),
					(int)(y - 16 * (yMult + 1f))),
					new Size(32, 32));
			}
			if (angleDegrees >= 180 && angleDegrees < 270)
			{
				collisionCenter1 = new Rectangle(new Point(
					(int)(x - 16 * (xMult + .9f)),
					(int)(y - 16 * (yMult + 1f))),
					new Size(32, 32));

				collisionCenter2 = new Rectangle(new Point(
					(int)(x + 24 * (xMult - .7f)),
					(int)(y - 16 / (yMult + 1.7f))),
					new Size(32, 32));
			}
			if (angleDegrees >= 270 && angleDegrees < 360)
			{
				collisionCenter1 = new Rectangle(new Point(
					(int)(x - 16 / (xMult + .9f)),
					(int)(y - 16 * (yMult + 1f))),
					new Size(32, 32));

				collisionCenter2 = new Rectangle(new Point(
					(int)(x - 24 * (xMult + .55f)),
					(int)(y - 16 / (yMult + 1.7f))),
					new Size(32, 32));
			}
		}

        public void Transform()
		{
			#region Transform_Steering
			if (left && force != 0)
				angleDegrees -= force / 2;
			if (right && force != 0)
				angleDegrees += force / 2;

			if (angleDegrees >= 360)
				angleDegrees -= 360;
			if (angleDegrees < 0)
				angleDegrees += 360;
            #endregion Transform_Steering

            #region Transform_Force/Speed
		    if (Throttle && (Brake == false))
		        if (force < 10)
		            force += 0.125f;
		        else
		            force = 10;
		    if ((Throttle == false) && (Brake == false))
		        if (force > 0)
		            force -= 0.1f;
		        else
		            force = 0;
		    if (Throttle && Brake)
		    {
		        if (force > 0)
		            force = -0.5f;
		        if (force <= 0)
		            force = 0;
		    }
		    if ((Throttle == false) && Brake)
		    {
		        if (force > 0)
		            force -= 2;
		        if ((force <= 0) && (force >= -1))
		            force -= -0.1f;
		        if (force < -1)
		            force = -2;
		    }

            //Speed for Speed-O-Meter
		    if (force < 0)
		        Speed = (short) (force*-10);
		    else
		        Speed = (short) (force*10);
			#endregion Transform_Force/Speed

			#region  Transform_Movement
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
            #endregion
        }


        public Image GetSprite(int initialRotation = 0)
        {
            #region Black magic
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
            //gfx.Clear(Color.Black);
            gfx.DrawImage(image, 0, 0, image.Width, image.Height);

			// gfx disposen
			gfx.Dispose();

            return bmp;
            #endregion
        }
    }
}
