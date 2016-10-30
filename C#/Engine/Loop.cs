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
        
        public  void Start()
        {
			            
        }

        public  void Update(Sprite car1,Sprite car2)
        {
			car1.Transform();
            car2.Transform();
        }

        public  void Render(Graphics g, Sprite car1,Sprite car2)
        {
			g.Clear(Color.Gray);

			// Sprite.GetSprite heeft een optionele parameter voor een startrotatie (In hoeken van 90 houden!)
            g.DrawImage(car1.GetSprite(180), car1.x - car1.newWidth / 2, car1.y - car1.newHeight / 2);
            g.DrawImage(car2.GetSprite(180), car2.x - car2.newWidth / 2, car2.y - car2.newHeight / 2);

            g.FillRectangle(Brushes.White, 12, 8, 96, 56); // Witte achtergrond voor labels
		}
    }
}
