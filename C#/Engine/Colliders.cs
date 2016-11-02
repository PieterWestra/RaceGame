using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Engine
{
	public class Colliders
	{
		private Rectangle collider;

		public void Collider(Rectangle _collider)
		{
			collider = _collider;
		}

		public void Collide(Sprite car1, Sprite car2)
		{
			if (collider.IntersectsWith(car1.collisionFront))
				car1.force = -1f;
			if (collider.IntersectsWith(car1.collisionBack))
				car1.force = 2f;

			if (collider.IntersectsWith(car2.collisionFront))
				car2.force = -1f;
			if (collider.IntersectsWith(car2.collisionBack))
				car2.force = 2f;
		}

		public void DebugRender(Graphics g)
		{
			g.DrawRectangle(Pens.Blue, collider);
		}
	}
}
