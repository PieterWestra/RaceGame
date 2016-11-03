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
		
        #region declaring variables
        public int newWidth, newHeight;
        public float angleDegrees = 0f;

        public Image image;
        private Bitmap bmp;

		public bool right = false;
		public bool left = false;
		public bool reverse = false;
		public float force = 0f;
		//private float speedmult;
		private float direction;

        public bool Throttle = false;   // needed for the redesign of the the speed-o-meter
        public bool Brake = false;      // comment for later.
        public short Speed = 0;

		public float xMult, yMult;
		public float x = 0;
		public float y = 0;

        public Rectangle collisionFront;
        public Rectangle collisionBack;
        public Rectangle fuelRectangle;
        public Rectangle speedRectangle;

        public float fuel = 100;
		public int fuelCounter = 0;
		public bool boost = false;
		private int boostCounter = 0;
        public float timer = 0;
		#endregion

		Image track = Image.FromFile(@"resources/sprites/track/track.png");

		public void Collider()
		{
            // Nieuwe versimpelde formule (Op het moment nog steeds hardcoded)
            collisionFront = new Rectangle(new Point(
                (int)((x) + 6 * xMult - 6), (int)((y - 6) + 6 * yMult)),
                new Size(12, 12));

            collisionBack = new Rectangle(new Point(
                (int)((x) - 6 * xMult - 6), (int)((y - 6) - 6 * yMult)),
                new Size(12, 12));
        }

        public void Transform()
        {
            #region Transform_Steering
            if (left && force != 0)
                angleDegrees -= force;
            if (right && force != 0)
                angleDegrees += force;

            if (angleDegrees >= 360)
                angleDegrees -= 360;
            if (angleDegrees < 0)
                angleDegrees += 360;
			#endregion Transform_Steering
			
			#region Transform_Force/Speed
			if (boost)
			{
				boostCounter += 1;
				if (boostCounter >= 100)
				{
					boostCounter = 0;
					boost = false;
				}
			}
			if (Throttle && (Brake == false))
			{
				if (force < 5 && !boost)
					force += 0.125f;
				else if (force < 8 && boost)
					force += 0.25f;
				else
					force -= 0.3f;
			}
		    if ((Throttle == false) && (Brake == false))
		        if (force > 0)
		            force -= 0.2f;
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

			if (force > 2 && fuel <= 0)
				force = 2;

            //Speed for Speed-O-Meter
            if (force < 10)
            {
                if (force < 0)
                    Speed = (short)(-(force * 20));
                else
                    Speed = (short)(force * 20);
            }
            else
            {
                Speed = 200;
            }
		    
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
				xMult = -(float)(Math.Sqrt(1 - Math.Pow(yMult, 2)));

				x += force * xMult;
				y += force * yMult;
			}
			if (angleDegrees >= 180 && angleDegrees < 270)
			{
				direction = (270 - angleDegrees) * 0.0174533f;

				xMult = -(float)Math.Sin(direction);
				yMult = -(float)(Math.Sqrt(1 - Math.Pow(xMult, 2)));

				x += force * xMult;
				y += force * yMult;
			}
			if (angleDegrees >= 270 && angleDegrees < 360)
			{
				direction = (360 - angleDegrees) * 0.0174533f;

				yMult = -(float)Math.Sin(direction);
				xMult = (float)(Math.Sqrt(1 - Math.Pow(yMult, 2)));

				x += force * xMult;
				y += force * yMult;
			}
            #endregion

            // Fuel
            Fuel f = new Fuel();
            fuel = f.fuelSystem(this.fuel, this.force);
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
