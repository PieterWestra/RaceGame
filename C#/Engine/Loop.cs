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
        #region
        /*
        Random r = new Random();

        public BouncingCube bc = new BouncingCube();
        public BouncingCube bc2 = new BouncingCube();
        public BouncingCube bc3 = new BouncingCube();
        public BouncingCube bc4 = new BouncingCube();
        */
        #endregion

        public  void Start()
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

        public  void Update(Sprite car1,Sprite _car2)
        {
			car1.Transform();
            _car2.Transform();
        }

        public  void Render(Graphics g, Sprite car1,Sprite _car2)
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

			g.Clear(Color.Gray);
			// Sprite.GetSprite heeft een optionele parameter voor een startrotatie (In hoeken van 90 houden!)
            g.DrawImage(car1.GetSprite(180), car1.x - car1.newWidth / 2, car1.y - car1.newHeight / 2);
            g.DrawImage(_car2.GetSprite(180), _car2.x - _car2.newWidth / 2, _car2.y - _car2.newHeight / 2);
            g.FillRectangle(Brushes.White, 12, 8, 96, 56);
		}
    }
}
