using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Engine
{
    public  class Loop
    {
		Rectangle rect2 = new Rectangle(new Point(256, 180), new Size(128, 256));
		

        public  void Start(Sprite car1, Sprite car2)
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

        public  void Render(Graphics g, Sprite car1,Sprite car2, Sprite fuelImage)
        {
			g.Clear(Color.Gray);

			// Sprite.GetSprite heeft een optionele parameter voor een startrotatie (In hoeken van 90 houden!)
            g.DrawImage(car1.GetSprite(180), car1.x - car1.newWidth / 2, car1.y - car1.newHeight / 2);
            g.DrawImage(car2.GetSprite(180), car2.x - car2.newWidth / 2, car2.y - car2.newHeight / 2);

            //g.FillRectangle(Brushes.White, 12, 8, 96, 56); // Witte achtergrond voor labels //fuck deze - Peter

			g.FillRectangle(Brushes.Purple, car1.collisionCenter1);
			g.FillRectangle(Brushes.Purple, car1.collisionCenter2);

			g.FillRectangle(Brushes.Blue, rect2);


            // Drawing fuel icon
            g.DrawImage(fuelImage.GetSprite(), 200, 200);

            // Drawig rectangle behind fuel icon
            fuelImage.fuelRectangle = new Rectangle(new Point(200, 200), new Size(32, 32));

            // Giving the fuelRectangle a black outline en draw'd deze
            g.DrawRectangle(Pens.Black, fuelImage.fuelRectangle);


            //g.DrawRectangle(Pens.Black, rect2);

            g.DrawLine(Pens.White, new Point((int)car1.x, (int)car1.y), new Point(
                (int)(car1.x + 64 * car1.xMult),
                (int)(car1.y + 64 * car1.yMult)));

		}
    }
}
