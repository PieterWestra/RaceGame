using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Timer = System.Timers.Timer;

namespace Engine
{
    public class Loop : Sprite
    {
        #region Variables

        private Rectangle rect2 = new Rectangle(new Point(300, 200), new Size(150, 250));
        public int refuelCount;
        private int refuelC = 1;
        private static Timer aTimer; //Not used?

        public static int LapCountCar1 = 1;
        public static int LapCountCar2 = 1;

        //  i tried to make a YouWin message, does not work at the moment will  look into why it doesn`t work.
        //
        // - Peter
        //
        private readonly Rectangle YouWin = new Rectangle(new Point(0, 0), new Size(768, 1024));
        public Image youWon = Image.FromFile(@"resources\sprites\YouWon.png");
        public Image background = Image.FromFile(@"resources\map.png");
        private Checkpoints _Checkpoints = new Checkpoints();

        public string vraag = string.Empty;

		#endregion

		// TEMPORARY
		Image track = Image.FromFile(@"resources/sprites/track/track.png");
		TextureBrush grassBrush = new TextureBrush(Image.FromFile(@"resources/sprites/track/Grass.png"), WrapMode.Tile);

		Graphics backBuffer;
		Bitmap bmp;

		#region Declaring Colliders
		Colliders colliders = new Colliders();
		Colliders colliders2 = new Colliders();
		Colliders colliders3 = new Colliders();
		Colliders colliders4 = new Colliders();
		Colliders colliders5 = new Colliders();
		Colliders colliders6 = new Colliders();
		Colliders colliders7 = new Colliders();
		Colliders colliders8 = new Colliders();
		Colliders colliders9 = new Colliders();
		Colliders colliders10 = new Colliders();
		Colliders colliders11 = new Colliders();
		Colliders colliders12 = new Colliders();
		Colliders colliders13 = new Colliders();
		#endregion
		// END TEMPORARY

		public void Start(Sprite car1, Sprite car2)
        {
            car1.image = Image.FromFile(@"resources\sprites\car1.png");
            car2.image = Image.FromFile(@"resources\sprites\car2.png");

            car1.x = 300;
            car1.y = 128; //X and Y coordinates Car1
            car2.x = 300;
            car2.y = 160; //X and Y coordinates Car2

			#region Initializing Colliders
			colliders.Collider(new Rectangle(0, 0, 170, 768));
			colliders2.Collider(new Rectangle(170, 0, 55, 358));
			colliders3.Collider(new Rectangle(225, 0, 800, 112));
			colliders4.Collider(new Rectangle(794, 112, 800, 650));
			colliders5.Collider(new Rectangle(170, 652, 624, 112));
			colliders6.Collider(new Rectangle(225, 295, 185, 63));
			colliders7.Collider(new Rectangle(353, 358, 57, 120));
			colliders8.Collider(new Rectangle(233, 421, 57, 166));
			colliders9.Collider(new Rectangle(290, 540, 352, 47));
			colliders10.Collider(new Rectangle(290, 177, 441, 54));
			colliders11.Collider(new Rectangle(474, 231, 168, 309));
			colliders12.Collider(new Rectangle(642, 532, 88, 55));
			colliders13.Collider(new Rectangle(706, 295, 23, 175));
			#endregion
		}

		public void Update(Sprite car1, Sprite car2)
        {
            // transform pass
            car1.Transform();
            car2.Transform();

            // Collision pass
            car1.Collider();
            car2.Collider();

			Collide(car1, car2);
			PitStop.InPitstop(car1, car2);
			Boost.Booster(car1, car2);

            #region Collisions
            // Cross car collision
            

            #endregion Collisions
        }

        public Image Render(Sprite car1, Sprite car2, Sprite fuelImage, Sprite speedImage)
        {

			if (bmp != null)
				bmp.Dispose();
			if (backBuffer != null)
				backBuffer.Dispose();

			bmp = new Bitmap(1024, 768);
			backBuffer = Graphics.FromImage(bmp);

			backBuffer.InterpolationMode = InterpolationMode.NearestNeighbor;
			//g.SmoothingMode = SmoothingMode.HighSpeed;
			// this may need some cleaning up.
			//
			// - Peter
			//g.Clear(Color.Gray); // Background -- IMPORTANT FOR LATER
			//g.DrawImage.image(@"resources\map.png");

			backBuffer.FillRectangle(grassBrush, 0, 0, 1024, 768);
			backBuffer.DrawImage(track, 0, 0, 1024, 768);
			Boost.Render(backBuffer);

			////Checkpoints
			//backBuffer.DrawRectangle(Pens.Red, Checkpoints.Checkpoint1);
			//backBuffer.DrawRectangle(Pens.Red, Checkpoints.Checkpoint2);
			//backBuffer.DrawRectangle(Pens.Red, Checkpoints.Checkpoint3);
			//backBuffer.DrawRectangle(Pens.Black, Checkpoints.Checkpoint4); //Finishline

			// Sprite.GetSprite heeft een optionele parameter voor een startrotatie (In hoeken van 90 houden!)
			backBuffer.DrawImage(car1.GetSprite(180), (car1.x - car1.newWidth / 2), (car1.y - car1.newHeight / 2));
            backBuffer.DrawImage(car2.GetSprite(180), (car2.x - car2.newWidth / 2), (car2.y - car2.newHeight / 2));

			//Collision Blocks for Testing
			//backBuffer.FillRectangle(Brushes.Yellow, car1.collisionBack);
			//backBuffer.FillRectangle(Brushes.Red, car1.collisionFront);

			//backBuffer.FillRectangle(Brushes.Yellow, car2.collisionBack);
			//backBuffer.FillRectangle(Brushes.Red, car2.collisionFront);

			// Debug Rendering voor hitboxes
			//colliders.DebugRender(backBuffer);
			//colliders2.DebugRender(backBuffer);
			//colliders3.DebugRender(backBuffer);
			//colliders4.DebugRender(backBuffer);
			//colliders5.DebugRender(backBuffer);
			//colliders6.DebugRender(backBuffer);
			//colliders7.DebugRender(backBuffer);
			//colliders8.DebugRender(backBuffer);
			//colliders9.DebugRender(backBuffer);
			//colliders10.DebugRender(backBuffer);
			//colliders11.DebugRender(backBuffer);
			//colliders12.DebugRender(backBuffer);
			//colliders13.DebugRender(backBuffer);

			//PitStop.DebugRender(backBuffer);

			if (LapCountCar2 >= 4 || LapCountCar1 >= 4)
				backBuffer.DrawImage(youWon, 0, 0, 1024, 768);

			return bmp;
			
        }

		// Collision Detectie
		public void Collide(Sprite car1, Sprite car2)
		{
			// Cross car collision
			if (car1.collisionFront.IntersectsWith(car2.collisionFront) ||
				car1.collisionFront.IntersectsWith(car2.collisionBack))
				car1.force = -2f;
			if (car1.collisionBack.IntersectsWith(car2.collisionFront) ||
				car1.collisionBack.IntersectsWith(car2.collisionBack))
				car1.force = 2f;

			if (car2.collisionFront.IntersectsWith(car1.collisionFront) ||
				car2.collisionFront.IntersectsWith(car1.collisionBack))
				car2.force = -2f;
			if (car2.collisionBack.IntersectsWith(car1.collisionFront) ||
				car2.collisionBack.IntersectsWith(car1.collisionBack))
				car2.force = 2f;

			// Map bounds
			colliders.Collide(car1, car2);
			colliders2.Collide(car1, car2);
			colliders3.Collide(car1, car2);
			colliders4.Collide(car1, car2);
			colliders5.Collide(car1, car2);
			colliders6.Collide(car1, car2);
			colliders7.Collide(car1, car2);
			colliders8.Collide(car1, car2);
			colliders9.Collide(car1, car2);
			colliders10.Collide(car1, car2);
			colliders11.Collide(car1, car2);
			colliders12.Collide(car1, car2);
			colliders13.Collide(car1, car2);
		}
    }
}
