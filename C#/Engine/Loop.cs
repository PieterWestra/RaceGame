using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Engine
{
    public class Loop : Sprite
    {
		Rectangle rect2 = new Rectangle(new Point(256, 180), new Size(128, 256));
        public int refuelCount = 0;
        private static System.Timers.Timer aTimer;
        

        public void Start(Sprite car1, Sprite car2)
		{
			car1.x = 256;
			car1.y = 256;
		}

        public  void Update(Sprite car1,Sprite car2)
        {
			// transform pass
			car1.Transform();
			car2.Transform();

			// Collision pass
			car1.Collider();
			car2.Collider();

			if (rect2.IntersectsWith(car1.collisionCenter1))
				car1.force = -5f;
			if (rect2.IntersectsWith(car1.collisionCenter2))
				car1.force = 10f;
		}

        public void Render(Graphics g, Sprite car1, Sprite car2, Sprite fuelImage, Sprite speedImage)
        {
            g.Clear(Color.Gray);

            // Sprite.GetSprite heeft een optionele parameter voor een startrotatie (In hoeken van 90 houden!)
            g.DrawImage(car1.GetSprite(180), car1.x - car1.newWidth / 2, car1.y - car1.newHeight / 2);
            g.DrawImage(car2.GetSprite(180), car2.x - car2.newWidth / 2, car2.y - car2.newHeight / 2);

            //g.FillRectangle(Brushes.White, 12, 8, 96, 56); // Witte achtergrond voor labels //fuck deze - Peter

            g.FillRectangle(Brushes.Purple, car1.collisionCenter1);
            g.FillRectangle(Brushes.Purple, car1.collisionCenter2);

            g.FillRectangle(Brushes.Blue, rect2);


            // Drawing fuel and speed icon
            g.DrawImage(fuelImage.GetSprite(), 200, 200);
            g.DrawImage(speedImage.GetSprite(), 500, 400);

            // Drawig rectangle behind fuel and speed icon
            fuelImage.fuelRectangle = new Rectangle(new Point(200, 200), new Size(32, 32));
            speedImage.speedRectangle = new Rectangle(new Point(500, 400), new Size(32, 32));

            // Giving the fuelRectangle a black outline en draw'd deze
            g.DrawRectangle(Pens.Black, fuelImage.fuelRectangle);

            if (fuelImage.fuelRectangle.IntersectsWith(car1.collisionCenter1))
            {
                refuelCount++;
                if (car1.fuel <= 100 && car1.force == 0)
                {
                    car1.fuel = Convert.ToSingle(car1.fuel + 0.5);
                    if (car1.fuel > 100)
                    {
                        car1.fuel = 100;
                    }
                }

            }
            else if (speedImage.speedRectangle.IntersectsWith(car1.collisionCenter1))
            {
                car1.boost = true;
                timer = 20;
            }
            else if (speedImage.speedRectangle.IntersectsWith(car1.collisionCenter1) == false)
            {
                if (timer > 0)
                {
                    timer--;
                }
                else if (timer == 0)
                {
                    car1.boost = false;
                }

            }

            //g.DrawRectangle(Pens.Black, rect2);

            g.DrawLine(Pens.White, new Point((int)car1.x, (int)car1.y), new Point(
                (int)(car1.x + 64 * car1.xMult),
                (int)(car1.y + 64 * car1.yMult)));

		}
    }
}
