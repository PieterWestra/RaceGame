using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Engine
{
	public static class Boost
	{
		private static Rectangle hitbox = new Rectangle(740, 185, 16, 32);
		private static Image sprite = Image.FromFile(@"resources\sprites\speed.png");

		public static void Booster(Sprite car1, Sprite car2)
		{
			if (hitbox.IntersectsWith(car1.collisionFront))
			{
				car1.boost = true;
			}

			if (hitbox.IntersectsWith(car2.collisionFront))
			{
				car2.boost = true;
			}
		}

		public static void Render(Graphics g)
		{
			g.DrawImage(sprite, 740, 185, 16, 32);
		}
	}
}
