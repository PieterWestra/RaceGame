using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Engine
{
    public class Image
    {
        public Bitmap b = null;

        public void InitializeImage (string path)
        {
            b = new Bitmap(path);
        }

        public void DrawImage (Graphics g)
        {
            g.DrawImage(b, 128, 128, 128, 64);
        }
    }
}
