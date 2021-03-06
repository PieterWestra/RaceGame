﻿using System;
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

        public bool CloseRace;

        private short _minutes, _seconds;
        private short _minutes2, _seconds2 = 2;
        private short _minutes3, _seconds3 = 2;

        private short _2minutes, _2seconds;
        private short _2minutes2, _2seconds2 = 2;
        private short _2minutes3, _2seconds3 = 2;

        private Graphics g;
        public int LapCountCar1 = 1;

        public static string Player1Name = "Player 1";
        public static string Player2Name = "Player 2";

        ////moving without borders
        //private const int WM_NCHITTEST = 0x84;
        //private const int HT_CLIENT = 0x1;
        //private const int HT_CAPTION = 0x2;
        ////

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
            
            fuel.image = Image.FromFile(@"resources\sprites\Fuel.png");
            speed.image = Image.FromFile(@"resources\sprites\Speed.png");
		}

        //protected override void WndProc(ref Message m) //moving without borders
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST)
        //        m.Result = (IntPtr)(HT_CAPTION);
        //}
    
                

        public void Reset()
        {
            //reset laps
            LapCountCar1 = 1;
            Loop.LapCountCar1 = 1;
            Loop.LapCountCar2 = 1;
            _Checkpoints.Lapcar1 = 1;
            _Checkpoints.Lapcar2 = 1;

            //reset car values
            car1.force = 0;
            car1.fuel = 100;
            car1.timer = 0;
            car1.x = 0;
            car1.y = 0;
            car1.angleDegrees = 0f;

            //reset car values
            car2.force = 0;
            car2.fuel = 100;
            car2.timer = 0;
            car2.x = 0;
            car2.y = 0;
            car2.angleDegrees = 0f;

            //reset to loop values
            car1.x = 300;
            car1.y = 128; //X and Y coordinates Car1
            car2.x = 300;
            car2.y = 160; //X and Y coordinates Car2



            //make You Won image invisible
            LBL_info.Visible = false;
            winner.Visible = false;
            //YouWonBox.Visible = false;

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
            loop.Update(car1, car2);    // HELP
            g.DrawImage(loop.Render(car1, car2, fuel, speed), 0, 0, 1024, 768);// Save Our Souls.
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
            lblFuel1.Text = "Fuel: " + (int)car1.fuel;
            lblFuel2.Text = "Fuel: " + (int)car2.fuel;

            lblRefuelP1.Text = "Player 1, Times Refueled: " + car1.fuelCounter;
            lblRefuelP2.Text = "Player 2, Times Refueled: " + car2.fuelCounter;

            //label5.Text = "geraakt?" + loop.vraag; // niet meer nodig


            lblRondencar1.Text = "Ronde: " + _Checkpoints.Lapcar1;
            lblRondencar2.Text = "Ronde " + _Checkpoints.Lapcar2;

            label_player1.Text = Player1Name;
            label_player2.Text = Player2Name;


            if (Loop.LapCountCar1 < 4 && Loop.LapCountCar2 < 4)
            {
               label_player1.BackColor = Color.Gray;
               label_player2.BackColor = Color.Gray;


               Minutes.BackColor = Color.Gray;
               Minutes2.BackColor = Color.Gray;
               Minutes3.BackColor = Color.Gray;

               test.BackColor = Color.Gray;
               car2minutes2.BackColor = Color.Gray;
               car2minutes3.BackColor = Color.Gray;

               Seconds.BackColor = Color.Gray;
               Seconds2.BackColor = Color.Gray;
               Seconds3.BackColor = Color.Gray;
                    
               test2.BackColor = Color.Gray;
               car2seconds2.BackColor = Color.Gray;
               car2seconds3.BackColor = Color.Gray;

                label6.BackColor = Color.Gray; //Car 1 round 1
                label7.BackColor = Color.Gray; // BEST LAP
                label8.BackColor = Color.Gray; //Car 1 round 2
                label9.BackColor = Color.Gray; //Car 1 round 3

                label10.BackColor = Color.Gray; //Car 2 round 1
                label11.BackColor = Color.Gray; //Car 2 round 2
                label14.BackColor = Color.Gray; //Car 2 round 3
            }
            //LBLRNDE.Text = "DO THE CHECKPOINTS WORK??? " + _Checkpoints.WORK; //Only for testing
            LBLRNDE.Visible = false;


            #region YouWin-SCREEN + LABEL-Color change
            if (Loop.LapCountCar1 >= 4 || Loop.LapCountCar2  >= 4)
            {
                LBL_info.Visible = true;
                LBL_info.Text = "Press Enter to Q to the main menu.\nPress Enter to restart. ";

                if(Loop.LapCountCar1 >= 4)
                {
                    winner.Visible = true;
                    winner.Text = Player1Name;
                    if (CloseRace == true)
                    {
                        Menu_Form Form_Menu = new Menu_Form();
                        //this.Dispose();
                        this.Close();
                        Form_Menu.Show();

                        ///Menu_Form.Show;
                    }
                }
                else if (Loop.LapCountCar2 >= 4)
                {
                    winner.Visible = true;
                    winner.Text = Player2Name;
                    if (CloseRace == true)
                    {
                        Menu_Form Form_Menu = new Menu_Form();
                        //this.Dispose();
                        this.Close();
                        Form_Menu.Show();

                        ///Menu_Form.Show;
                    }
                }
                //Win screen
                //YouWonBox.Visible = true;

                //PLayer Names
                label_player1.BackColor = Color.Black;
                label_player2.BackColor = Color.Black;

                label_player1.ForeColor = Color.White;
                label_player2.ForeColor = Color.White;

                //Background color Minutes
                Minutes.BackColor = Color.Black;
                Minutes2.BackColor = Color.Black;
                Minutes3.BackColor = Color.Black;

                test.BackColor = Color.Black;
                car2minutes2.BackColor = Color.Black;
                car2minutes3.BackColor = Color.Black;


                //fore ground color Minutes
                Minutes.ForeColor = Color.White;
                Minutes2.ForeColor = Color.White;
                Minutes3.ForeColor = Color.White;

                test.ForeColor = Color.White;
                car2minutes2.ForeColor = Color.White;
                car2minutes3.ForeColor = Color.White;
                
                //Background color Seconds
                Seconds.BackColor = Color.Black;
                Seconds2.BackColor = Color.Black;
                Seconds3.BackColor = Color.Black;

                test2.BackColor = Color.Black;
                car2seconds2.BackColor = Color.Black;
                car2seconds3.BackColor = Color.Black;

                //fore ground color Seconds
                Seconds.ForeColor = Color.White;
                Seconds2.ForeColor = Color.White;
                Seconds3.ForeColor = Color.White;

                test2.ForeColor = Color.Black;
                car2seconds2.ForeColor = Color.Black;
                car2seconds3.ForeColor = Color.Black;

                //Background color Laps
                label6.BackColor = Color.Black; //Car 1 round 1
                label7.BackColor = Color.Black; // BEST LAP
                label8.BackColor = Color.Black; //Car 1 round 2
                label9.BackColor = Color.Black; //Car 1 round 3

                label10.BackColor = Color.Black; //Car 2 round 1
                label11.BackColor = Color.Black; //Car 2 round 2
                label14.BackColor = Color.Black; //Car 2 round 3

                //fore ground color Laps
                label6.ForeColor = Color.White; //Car 1 round 1
                label7.ForeColor = Color.White; // BEST LAP
                label8.ForeColor = Color.White; //Car 1 round 2
                label9.ForeColor = Color.White; //Car 1 round 3

                label10.ForeColor = Color.White; //Car 2 round 1
                label11.ForeColor = Color.White; //Car 2 round 2
                label14.ForeColor = Color.White; //Car 2 round 3


            }

            #endregion
            #endregion

            
        }


        // Key press detectie
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (Loop.LapCountCar1 >= 4 || Loop.LapCountCar2 >= 4)
            {
                if (e.KeyCode == Keys.Q)
                {
                    CloseRace = true;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    Reset();
                }
            }

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


        #region timer car 1 + extra labels
 
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
            if ((_seconds + (_minutes * 60)) <= (_seconds2 + (_minutes2 * 60)) && (_seconds + (_minutes * 60)) <= (_seconds3 + (_minutes3 * 60)))
            {
                label7.Visible = true;
                label7.Text = "Best lap : Lap 1";
            }
            else if ((_seconds2 + (_minutes2 * 60)) <= (_seconds + (_minutes * 60)) && (_seconds2 + (_minutes2 * 60)) <= (_seconds3 + (_minutes3 * 60)))
            {
                label7.Visible = true;
                label7.Text = "Best lap : Lap 2";
            }
            else if ((_seconds3 + (_minutes3 * 60)) <= (_seconds2 + (_minutes2 * 60)) && (_seconds3 + (_minutes3 * 60)) <= (_seconds + (_minutes * 60)))
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
        #region timer car2
        #region car 2 round 1
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Loop.LapCountCar2 == 1)
            {
                _2increaseseconds();
                _2ShowTime();
            }
            if (Loop.LapCountCar2 > 1)
            {
                _2starttimer2();
                _2stoptimer();

            }
        }
        private void _2starttimer2()
        {
            timer5.Enabled = true;
        }
        private void _2stoptimer()
        {
            timer4.Enabled = false;

        }
        private void _2increaseseconds()
        {

            if (_2seconds == 59)
            {
                _2seconds = 0;
                _2minutes++;
            }
            else
            {
                _2seconds++;
            }
        }

        private void _2ShowTime()
        {
            test.Text = _2minutes.ToString("00");
            test2.Text = _2seconds.ToString("00");
        }
        #endregion
        #region car 2 round 2
        private void timer5_Tick_1(object sender, EventArgs e)
        {
            if (Loop.LapCountCar2 == 2)
            {
                _2increaseseconds2();
                _2ShowTime2();
            }
            else
            {
                _2stoptimer2();
                _2starttimer3();
            }
        }
        private void _2starttimer3()
        {
            timer6.Enabled = true;
            timer5.Enabled = false;
        }
        private void _2stoptimer2()
        {
            timer5.Enabled = false;
        }

        private void _2increaseseconds2()
        {
            if (_seconds2 == 59)
            {
                _seconds2 = 0;
                _2minutes2++;
            }
            else
            {
                _seconds2++;
            }
        }

        private void Seconds_Click(object sender, EventArgs e)
        {

        }

        private void Seconds2_Click(object sender, EventArgs e)
        {

        }

        private void _2ShowTime2()
        {
            car2minutes2.Text = _2minutes2.ToString("00");
            car2seconds2.Text = _seconds2.ToString("00");
        }
        #endregion
        #region car 2 round 3 + lapcalc
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (Loop.LapCountCar2 == 3)
            {
                _2increaseseconds3();
                _2ShowTime3();
            }
            else
            {
                _2stoptimer3();
                _2calculatebest();
            }
        }
        private void _2calculatebest()
        {
            if ((_2seconds + (_2minutes * 60)) <= (_2seconds2 + (_2minutes2 * 60)) && (_2seconds + (_2minutes * 60)) <= (_2seconds3 + (_2minutes3 * 60)))
            {
                label7.Visible = true;
                label7.Text = "Best lap : Lap 1";
            }
            else if ((_2seconds2 + (_2minutes2 * 60)) <= (_2seconds + (_2minutes * 60)) && (_2seconds2 + (_2minutes2 * 60)) <= (_2seconds3 + (_2minutes3 * 60)))
            {
                label7.Visible = true;
                label7.Text = "Best lap : Lap 2";
            }
            else if ((_2seconds3 + (_2minutes3 * 60)) <= (_2seconds2 + (_2minutes2 * 60)) && (_2seconds3 + (_2minutes3 * 60)) <= (_2seconds + (_2minutes * 60)))
            {
                label7.Visible = true;
                label7.Text = "Best lap: Lap 3";
            }
        }
        private void _2stoptimer3()
        {
            timer6.Enabled = false;
        }
        private void _2increaseseconds3()
        {
            if (_2seconds3 == 59)
            {
                _2seconds3 = 0;
                _2minutes3++;
            }
            else
            {
                _2seconds3++;
            }
        }
        private void _2ShowTime3()
        {
            car2minutes3.Text = _2minutes3.ToString("00");
            car2seconds3.Text = _2seconds3.ToString("00");
        }
        #endregion
        #endregion

    }
}

