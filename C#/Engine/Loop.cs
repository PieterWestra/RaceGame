using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Engine
{
    public class Loop
    {
        #region
        /*
        Random r = new Random();

        public BouncingCube bc = new BouncingCube();
        public BouncingCube bc2 = new BouncingCube();
        public BouncingCube bc3 = new BouncingCube();
        public BouncingCube bc4 = new BouncingCube();
        */
        #endregion

        Image image = Image.FromFile(@"C:\Users\Pieter\Desktop\car.png");
        
        float angle { get;  set; }


        public void Start(Panel pnlCanvas)
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

        public void Update(Panel pnlCanvas, Graphics g)
        {
            //angle += .2f;

            if (angle > 360)
                angle -= 360;
        }

       

        public void Render(Panel pnlCanvas, Graphics g)
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

            //g = Graphics.FromImage(image);

            g.Clear(Color.Black);

            g.TranslateTransform(image.Width / 2.0f + 0.35f, image.Height / 2.0f - 0.35f);
            g.RotateTransform(-2);
            g.TranslateTransform(-image.Width / 2.0f, -image.Height / 2.0f);

            g.DrawImage(image, 0, 0);

            //return image;
        }
    }
}
