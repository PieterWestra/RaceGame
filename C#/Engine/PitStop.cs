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

		public static void InPitstop(Sprite car1, Sprite car2)
		{
			// Pitstop code hier plaatsen voor beide auto's
			//
			// Er moet een snelheidslimiet komen en refuelling
		}

		public static void DebugRender(Graphics g)
		{
			g.DrawRectangle(Pens.Red, hitbox);
		}
	}
}
