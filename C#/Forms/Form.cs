using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Engine;
using System.Reflection;

namespace Forms
{

    public partial class Form : System.Windows.Forms.Form
    {
        #region Declaring variables
        // OLD
        private Loop loop = new Loop();


        private Sprite car1 = new Sprite();  // new instance of Sprite called car1
        private Sprite car2 = new Sprite(); // new instance of Sprite called car2

        private Sprite speed = new Sprite();
        private Sprite fuel = new Sprite();

        private Checkpoints _Checkpoints = new Checkpoints();

        private short _minutes, _seconds;
        private short _minutes2, _seconds2 = 2;
        private short _minutes3, _seconds3 = 2;
        private Graphics g;
        public int LapCountCar1 = 1;
        ////NEW
        //Bitmap Backbuffer;
        //private Image BACKGROUND = Image.FromFile(@"OpDeKaart.png");
        //List<Sprite> cars = new List<Sprite>();
        ////



        
        #endregion

        public Form()
        {
            InitializeComponent();
            tmrMoving.Interval = 16;
            car2.image = Image.FromFile(@"resources\sprites\car2.png");
            fuel.image = Image.FromFile(@"resources\sprites\Fuel.png");
            speed.image = Image.FromFile(@"resources\sprites\Speed.png");



        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            g = pnlCanvas.CreateGraphics();
        }


        private void Form_Load(object sender, EventArgs e)
        {
            loop.Start(car1, car2);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {



            loop.Update(car1, car2);    //
            loop.Render(g, car1, car2, fuel, speed); //changed some of the rendercode - it works but could be done better. - Peter 
            _Checkpoints.CheckPass(car1, car2); //Checks id you have passed the checkpoints

            
            #region Speed-O-Meter / FuelBar
            // Speed-o-meter is just an regular progressbarr at the moment if there is time ove we will look in to an replacement
            // it`s just an temporary fix. 29/10/16
            //
            // - Peter
            //
            // it broke the game -- if you try to drive backwards you break it -- because it can`t handle negative values
            // i will fix this tomorow
            //
            // - Peter
            //
            Car1_Bar.Value = car1.Speed;
            Car2_Bar.Value = car2.Speed;
            Fuelbarcar1.Value = (int)car1.fuel;
            Fuelbarcar2.Value = (int)car2.fuel;
            #endregion

            #region Labels

            lblAngle.Text = "Angle: " + car1.angleDegrees;
            lblForce.Text = "Speed: " + car1.Speed;
            lblXmult.Text = "Xmult: " + car1.xMult;
            lblYmult.Text = "Ymult: " + car1.yMult;

            label1.Text = "Angle car2: " + car2.angleDegrees;
            label2.Text = "Speed: " + car2.Speed;
            label3.Text = "Xmult car2: " + car2.xMult;
            label4.Text = "Ymult car2: " + car2.yMult;
            lblFuel1.Text = "Fuel: " + car1.fuel;
            lblFuel2.Text = "Fuel: " + car2.fuel;

            lblTest.Text = "Total refueled" + loop.refuelCount;

            label5.Text = "geraakt?" + loop.vraag;


            lblRondencar1.Text = "Ronde: " + _Checkpoints.Lapcar1;
            lblRondencar2.Text = "Ronde " + _Checkpoints.Lapcar2;


            //LBLRNDE.Text = "DO THE CHECKPOINTS WORK??? " + _Checkpoints.WORK; //Only for testing
            LBLRNDE.Visible = false;


            #region YouWin-SCREEN + LABEL-Color change
            if (Loop.LapCountCar1 >= 4 || Loop.LapCountCar2  >= 4)
            {
                //Win screen
                YouWonBox.Visible = true;

                //Background color Minutes
                Minutes.BackColor = Color.Black;
                Minutes2.BackColor = Color.Black;
                Minutes3.BackColor = Color.Black;
                
                //fore ground color Minutes
                Minutes.ForeColor = Color.White;
                Minutes2.ForeColor = Color.White;
                Minutes3.ForeColor = Color.White;

                //Background color Seconds
                Seconds.BackColor = Color.Black;
                Seconds2.BackColor = Color.Black;
                Seconds3.BackColor = Color.Black;
                 
                //fore ground color Seconds
                Seconds.ForeColor = Color.White;
                Seconds2.ForeColor = Color.White;
                Seconds3.ForeColor = Color.White;

                //Background color Laps
                label6.BackColor = Color.Black; //Car 1 round 1
                label7.BackColor = Color.Black; // BEST LAP
                label8.BackColor = Color.Black; //Car 1 round 2
                label9.BackColor = Color.Black; //Car 1 round 3

                //fore ground color Laps
                label6.ForeColor = Color.White; //Car 1 round 1
                label7.ForeColor = Color.White; // BEST LAP
                label8.ForeColor = Color.White; //Car 1 round 2
                label9.ForeColor = Color.White; //Car 1 round 3
            }
            #endregion
            #endregion

            // "Double buffering" hack
            g.CopyFromScreen(new Point(0, 0), new Point(pnlCanvas.Width, pnlCanvas.Height), new Size(1, 1));
            g.CopyFromScreen(new Point(0, 0), new Point(pnlCanvas.Width, pnlCanvas.Height), new Size(1, 1));
        }

        // Key press detectie
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            #region Car1 config
            // I removed out the original force version for the more advanced throttle/brake version
            // you can see the speed code in the sprite.cs -- transform() method -- 
            //
            // - Peter

            //Car 1 config
            if (e.KeyCode == Keys.D)
                car1.right = true;
            if (e.KeyCode == Keys.A)
                car1.left = true;
            if (e.KeyCode == Keys.W)
                car1.Throttle = true;
            if (e.KeyCode == Keys.S)
                car1.Brake = true;
            #endregion

            #region Car2 config
            //Car 2 config
            if (e.KeyCode == Keys.Right)
                car2.right = true;
            if (e.KeyCode == Keys.Left)
                car2.left = true;
            if (e.KeyCode == Keys.Up)
                car2.Throttle = true;
            if (e.KeyCode == Keys.Down)
                car2.Brake = true;
            #endregion
        }

        // Key unpress detectie
        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            #region Car1 config
            //Car 1 config
            if (e.KeyCode == Keys.D)
                car1.right = false;
            if (e.KeyCode == Keys.A)
                car1.left = false;
            if (e.KeyCode == Keys.W)
                car1.Throttle = false;
            if (e.KeyCode == Keys.S)
                car1.Brake = false;
            #endregion

            #region Car2 Config
            //Car 2 config
            if (e.KeyCode == Keys.Right)
                car2.right = false;
            if (e.KeyCode == Keys.Left)
                car2.left = false;
            if (e.KeyCode == Keys.Up)
                car2.Throttle = false;
            if (e.KeyCode == Keys.Down)
                car2.Brake = false;
            #endregion
        }


        
        #region timer + extra labels
        #region round 1
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Loop.LapCountCar1 == 1)
            {
                increaseseconds();
                ShowTime();
            }
            if (Loop.LapCountCar1 > 1)
            {
                starttimer2();
                stoptimer();
                ShowTime();

            }
        }

        private void starttimer2()
        {
            timer2.Enabled = true;
        }

        private void stoptimer()
        {
            timer1.Enabled = false;
        }
        private void increaseseconds()
        {

            if (_seconds == 59)
            {
                _seconds = 0;
                _minutes++;
            }
            else
            {
                _seconds++;
            }
        }

        private void ShowTime()
        {
            Minutes.Text = _minutes.ToString("00");
            Seconds.Text = _seconds.ToString("00");
        }
        #endregion
        #region round 2
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (Loop.LapCountCar1 == 2)
            {
                increaseseconds2();
                ShowTime2();
            }
            else
            {
                stoptimer2();
                starttimer3();
            }
        }
        private void starttimer3()
        {
            timer3.Enabled = true;
            timer2.Enabled = false;
        }
        private void stoptimer2()
        {
           timer2.Enabled = false;
        }

        private void increaseseconds2()
        {
            if (_seconds2 == 59)
            {
                _seconds2 = 0;
                _minutes2++;
            }
            else
            {
                _seconds2++;
            }
        }
        private void ShowTime2()
        {
            Minutes2.Text = _minutes2.ToString("00");
            Seconds2.Text = _seconds2.ToString("00");
        }
        #endregion
        #region round 3 + lapcalc
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Loop.LapCountCar1 == 3)
            {
                increaseseconds3();
                ShowTime3();
            }
            else
            {
                stoptimer3();
                calculatebest();
            }
        }
        private void calculatebest()
        {
            if ((_seconds + _minutes) <= (_seconds2 + _minutes2) && (_seconds + _minutes) <= (_seconds3 + _minutes3))
            {
                label7.Visible = true;
                label7.Text = "Best lap : Lap 1";
            }
            else if ((_seconds2 + _minutes2) <= (_seconds + _minutes) && (_seconds2 + _minutes2) <= (_seconds3 + _minutes3))
            {
                label7.Visible = true;
                label7.Text = "Best lap : Lap 2";
            }
            else if ((_seconds3 + _minutes3) <= (_seconds2 + _minutes2) && (_seconds3 + _minutes3) <= (_seconds + _minutes))
            {
                label7.Visible = true;
                label7.Text = "Best lap: Lap 3";
            }
        }
        private void stoptimer3()
        {
            timer3.Enabled = false;
        }
        private void increaseseconds3()
        {
            if (_seconds3 == 59)
            {
                _seconds3 = 0;
                _minutes3++;
            }
            else
            {
                _seconds3++;
            }
        }
        private void ShowTime3()
        {
            Minutes3.Text = _minutes3.ToString("00");
            Seconds3.Text = _seconds3.ToString("00");
        }
   
        #endregion
        #endregion
    }
}

