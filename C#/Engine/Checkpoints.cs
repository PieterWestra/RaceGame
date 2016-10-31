using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Engine
{
    public class Checkpoints
    {
        public static Rectangle Checkpoint1 = new Rectangle(new Point(0, 100), new Size(200, 40));
        public static Rectangle Checkpoint2 = new Rectangle(new Point(0, 200), new Size(200, 40));
        public static Rectangle Checkpoint3 = new Rectangle(new Point(0, 300), new Size(200, 40));
        public static Rectangle Checkpoint4 = new Rectangle(new Point(0, 400), new Size(200, 40));
        public bool Checkpoint1PassCar1, Checkpoint2PassCar1 = false, Checkpoint3PassCar1 = false, Checkpoint4PassCar1 = false;
        public bool Checkpoint1PassCar2, Checkpoint2PassCar2 = false, Checkpoint3PassCar2 = false, Checkpoint4PassCar2 = false;

        public string WORK = string.Empty;

        public int Lapcar1 = 1,Lapcar2 = 1;
       

        public void CheckPass(Sprite car1, Sprite car2)
        {
            if (Checkpoint1.IntersectsWith(car1.collisionCenter1))
                Checkpoint1PassCar1 = true;
            if (Checkpoint2.IntersectsWith(car1.collisionCenter1))
                Checkpoint2PassCar1 = true;
            if (Checkpoint3.IntersectsWith(car1.collisionCenter1))
                Checkpoint3PassCar1 = true;
            if (Checkpoint4.IntersectsWith(car1.collisionCenter1))
                Checkpoint4PassCar1 = true;

            if (Checkpoint1.IntersectsWith(car2.collisionCenter1))
                Checkpoint1PassCar2 = true;
            if (Checkpoint2.IntersectsWith(car2.collisionCenter1))
                Checkpoint2PassCar2 = true;
            if (Checkpoint3.IntersectsWith(car2.collisionCenter1))
                Checkpoint3PassCar2 = true;
            if (Checkpoint4.IntersectsWith(car2.collisionCenter1))
                Checkpoint4PassCar2 = true;

            if (Checkpoint4PassCar1 && Checkpoint2PassCar1 && Checkpoint1PassCar1 && Checkpoint3PassCar1)
            {
                WORK = "Haha yes!";
                Lapcar1++;
                Checkpoint1PassCar1 = Checkpoint2PassCar1 = Checkpoint3PassCar1 = Checkpoint4PassCar1 = false;
            }
                

        }
    }
}
