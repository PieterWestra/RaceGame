using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BouncingCube
    {
        bool ping = true;
        bool pong = true;

        public int x = 0;
        public int y = 0;
        public int speed = 10;

        Random r = new Random();

        public void InitCube(int width, int height)
        {
            x = r.Next(width - 64);
            y = r.Next(height - 64);
            speed = r.Next(5, 20);
        }

        public  void RenderCube(Graphics g, Brush col, int width, int height)
        {
            if (x <= 0)
                ping = true;
            if (x >= (width - 64))
                ping = false;
            if (y <= 0)
                pong = true;
            if (y >= (height - 64))
                pong = false;

            if (ping)
                x += speed;
            if (!ping)
                x -= speed;
            if (pong)
                y += speed;
            if (!pong)
                y -= speed;

            g.FillRectangle(col, new Rectangle(x, y, 64, 64));
        }
    }
}
