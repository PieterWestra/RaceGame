using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Engine
{
    public static class Loop
    {
        private static Sprite car1 = new Sprite();

        #region
        /*
        Random r = new Random();

        public BouncingCube bc = new BouncingCube();
        public BouncingCube bc2 = new BouncingCube();
        public BouncingCube bc3 = new BouncingCube();
        public BouncingCube bc4 = new BouncingCube();
        */
        #endregion

        private static Image image = Image.FromFile(@"C:\Users\Pieter\Desktop\car.png");
        
        private static float angle { get;  set; }


        public static void Start(Panel pnlCanvas)
        {
            #region
            /*
            bc.x = r.Next(pnlCanvas.Width - 64);
            bc.y = r.Next(pnlCanvas.Height - 64);
            bc.speed = r.Next(5, 20);

            bc2.x = r.Next(pnlCanvas.Width - 64);
            bc2.y = r.Next(pnlCanvas.Height - 64);
            bc2.speed = r.Next(5, 20);

            bc3.x = r.Next(pnlCanvas.Width - 64);
            bc3.y = r.Next(pnlCanvas.Height - 64);
            bc3.speed = r.Next(5, 20);

            bc4.x = r.Next(pnlCanvas.Width - 64);
            bc4.y = r.Next(pnlCanvas.Height - 64);
            bc4.speed = r.Next(5, 20);
            */
            #endregion

            
        }

        public static void Update(Panel pnlCanvas, Graphics g)
        {
            
        }

        public static void Render(Panel pnlCanvas, Graphics g)
        {
            #region
            /*
            g.Clear(Color.Black);

            bc.RenderCube(g, Brushes.Red, pnlCanvas.Width, pnlCanvas.Height);
            bc2.RenderCube(g, Brushes.Blue, pnlCanvas.Width, pnlCanvas.Height);
            bc3.RenderCube(g, Brushes.Green, pnlCanvas.Width, pnlCanvas.Height);
            bc4.RenderCube(g, Brushes.HotPink, pnlCanvas.Width, pnlCanvas.Height);
            */
            #endregion
            g.DrawImage(car1.GetSprite(), 0 - car1.newWidth / 2, 0 - car1.newHeight / 2);
            
        }
    }
}
