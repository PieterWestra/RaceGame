using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Engine
{
	public static class PitStop
	{
		private static Rectangle hitbox = new Rectangle(642, 231, 63, 301);
		private static bool car1InPitstop = false;
		private static bool car2InPitstop = false;

		public static void InPitstop(Sprite car1, Sprite car2)
		{
			// Speler 1
			if (hitbox.IntersectsWith(car1.collisionFront))
			{
				if (car1.force > 1.2f)
					car1.force = 1.2f;
				if (car1.fuel < 100)
					car1.fuel += 1.0f;
				car1InPitstop = true;
			}
			else
			{
				if (car1InPitstop)
				{
					car1InPitstop = false;
					car1.fuelCounter++;
				}
			}

			// Speler 2
			if (hitbox.IntersectsWith(car2.collisionFront))
			{
				if (car2.force > 1.2f)
					car2.force = 1.2f;
				if (car2.fuel < 100)
					car2.fuel += 1.0f;
				car2InPitstop = true;
			}
			else
			{
				if (car2InPitstop)
				{
					car2InPitstop = false;
					car2.fuelCounter++;
				}
			}
		}

		public static void DebugRender(Graphics g)
		{
			g.DrawRectangle(Pens.Red, hitbox);
		}
	}
}
