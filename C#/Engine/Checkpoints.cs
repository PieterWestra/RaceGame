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
        #region Variables
        //for drawing them at the screen.
        public static Rectangle Checkpoint1 = new Rectangle(new Point(450, 300), new Size(300, 40));
        public static Rectangle Checkpoint2 = new Rectangle(new Point(400, 450), new Size(40, 200));
        public static Rectangle Checkpoint3 = new Rectangle(new Point(0, 300), new Size(300, 40));
        public static Rectangle Checkpoint4 = new Rectangle(new Point(400, 0), new Size(40, 200));




        private bool Checkpoint1PassCar1, Checkpoint2PassCar1, Checkpoint3PassCar1, Checkpoint4PassCar1;
        private bool Checkpoint1PassCar2, Checkpoint2PassCar2, Checkpoint3PassCar2, Checkpoint4PassCar2;

        public string WORK = string.Empty; // for testing 

        public int Lapcar1 = 1,Lapcar2 = 1;//Laps start at 1
        #endregion

        public void CheckPass(Sprite car1, Sprite car2)
        {
            if (Checkpoint1.IntersectsWith(car1.collisionCenter1))
            {
                Checkpoint1PassCar1 = true;
                Checkpoint4PassCar1 = false;
            }
            if (Checkpoint2.IntersectsWith(car1.collisionCenter1))
                Checkpoint2PassCar1 = true;
            if (Checkpoint3.IntersectsWith(car1.collisionCenter1))
                Checkpoint3PassCar1 = true;
            if (Checkpoint4.IntersectsWith(car1.collisionCenter1))
            {
                Checkpoint4PassCar1 = true;
                if (Checkpoint4PassCar1 && Checkpoint2PassCar1 && Checkpoint1PassCar1 && Checkpoint3PassCar1)
                {
                    WORK = "Haha yes!";
                    Loop.LapCountCar1++;
                    Lapcar1++;
                    Checkpoint1PassCar1 = Checkpoint2PassCar1 = Checkpoint3PassCar1 = false; //all of the boolians are reset to false
                }
            }

            if (Checkpoint1.IntersectsWith(car2.collisionCenter1))
            {
                Checkpoint1PassCar2 = true;
                Checkpoint4PassCar2 = false;
            }
            if (Checkpoint2.IntersectsWith(car2.collisionCenter1))
                Checkpoint2PassCar2 = true;
            if (Checkpoint3.IntersectsWith(car2.collisionCenter1))
                Checkpoint3PassCar2 = true;
            if (Checkpoint4.IntersectsWith(car2.collisionCenter1))
            {
                Checkpoint4PassCar2 = true;
                if (Checkpoint4PassCar1 && Checkpoint2PassCar1 && Checkpoint1PassCar1 && Checkpoint3PassCar1)
                {
                    WORK = "Haha yes!";
                    Lapcar2++;
                    Loop.LapCountCar2++;
                    Checkpoint1PassCar2= Checkpoint2PassCar2= Checkpoint3PassCar2= false; //all of the boolians are reset to false
                }
            }
            
          

        }
    }
}
