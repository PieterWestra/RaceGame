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
        private Loop _Loop = new Loop();
        private Sprite _Car1 = new Sprite();  // new instance of Sprite called _Car1
		private Sprite _Car2  = new Sprite(); // new instance of Sprite called _Car2
        private Sprite _Speed = new Sprite();
        private Sprite _Fuel = new Sprite();
        private Checkpoints _Checkpoints = new Checkpoints();
        private Graphics _Graphics;

        public int LapCountCar1 = 1;
        ////NEW
        private Bitmap Backbuffer;
        private Image BACKGROUND = Image.FromFile(@"Resources\map1.png");
        private List<Sprite> cars = new List<Sprite>();
        ////


        
        #endregion

        public Form()
        {
            InitializeComponent();
            //NEW
            cars.Add(_Car1);
            cars.Add(_Car2);

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            this.ResizeEnd += new EventHandler(Form_CreateBackBuffer);
            this.Load += new EventHandler(Form_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form_Paint);

            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.KeyUp += new KeyEventHandler(Form_KeyUp);
            //OLD
            tmrMoving.Interval = 16;
            _Car2.image = Image.FromFile(@"resources\sprites\car2.png");
            _Fuel.image = Image.FromFile(@"resources\sprites\Fuel.png");
            _Speed.image = Image.FromFile(@"resources\sprites\Speed.png");
       }
        //NEW
        private void Form_Paint(object sender, PaintEventArgs e)//NEW
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }

            Draw(e.Graphics);
        }

        private void Form_CreateBackBuffer(object sender, EventArgs e)//NEW
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        void Draw(Graphics _gg)//NEW
        {
            _gg.DrawImage(BACKGROUND, 0, 0);
            foreach (Sprite car in cars)
                _gg.DrawImage(car.getImage(), car.getPosition());

        }
        //

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            _Graphics = pnlCanvas.CreateGraphics();
		}


        private void Form_Load(object sender, EventArgs e)
        {
            _Loop.Start(_Car1, _Car2);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            //NEW
            foreach (Sprite car in cars)
                car.calculateNewPosition();

            Invalidate();
            //


            _Loop.Update(_Car1, _Car2);    //
           _Loop.Render(_Graphics, _Car1, _Car2, _Fuel, _Speed); //changed some of the rendercode - it works but could be done better. - Peter 
            _Checkpoints.CheckPass(_Car1, _Car2); //Checks id you have passed the checkpoints

            
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
            Car1_Bar.Value = _Car1.Speed;
            Car2_Bar.Value = _Car2.Speed;
            Fuelbarcar1.Value = (int)_Car1.fuel;
            Fuelbarcar2.Value = (int)_Car2.fuel;
            #endregion

            #region Labels

            lblAngle.Text = "Angle: " + _Car1.angleDegrees;
			lblForce.Text = "Speed: " + _Car1.Speed;
			lblXmult.Text = "Xmult: " + _Car1.xMult;
			lblYmult.Text = "Ymult: " + _Car1.yMult;

            label1.Text = "Angle _Car2: " + _Car2.angleDegrees;
            label2.Text = "Speed: " + _Car2.Speed;
            label3.Text = "Xmult _Car2: " + _Car2.xMult;
            label4.Text = "Ymult _Car2: " + _Car2.yMult;
            lblFuel1.Text = "Fuel: " + _Car1.fuel;
            lblFuel2.Text = "Fuel: " + _Car2.fuel;
            
            lblTest.Text = "Total refueled" + _Loop.refuelCount;

            label5.Text = "geraakt?" + _Loop.vraag;

            lblRondencar1.Text = "Ronde: " + _Checkpoints.Lapcar1;
            lblRondencar2.Text = "Ronde " + _Checkpoints.Lapcar2;

            LBLRNDE.Text = "DO THE CHECKPOINTS WORK???\n " + _Checkpoints.WORK;

            //label6.Text = "Ronde 1 Car1\n"+ getal1 + " : " + getal2;//TIMER PREVIEW

            if (Loop.LapCountCar1 >= 4)
            {
                YouWonBox.Visible = true;
            }
            
            #endregion

            // "Double buffering" hack
            _Graphics.CopyFromScreen(new Point(0, 0), new Point(pnlCanvas.Width, pnlCanvas.Height), new Size(1, 1));
			_Graphics.CopyFromScreen(new Point(0, 0), new Point(pnlCanvas.Width, pnlCanvas.Height), new Size(1, 1));
		}

        // Key press detectie
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            #region Car1 config
            // I removed out the original force version for the more advanced throttle/brake version
            // you can see the _Speed code in the sprite.cs -- transform() method -- 
            //
            // - Peter

            //Car 1 config
            if (e.KeyCode == Keys.D)
                _Car1.right = true;
            if (e.KeyCode == Keys.A)
                _Car1.left = true;
            if (e.KeyCode == Keys.W)
                _Car1.Throttle = true;
            if (e.KeyCode == Keys.S)
               _Car1.Brake = true;
            #endregion

            #region Car2 config
            //Car 2 config
            if (e.KeyCode == Keys.Right)
                _Car2.right = true;
            if (e.KeyCode == Keys.Left)
                _Car2.left = true;
            if (e.KeyCode == Keys.Up)
                _Car2.Throttle =  true;
            if (e.KeyCode == Keys.Down)
                _Car2.Brake = true;
            #endregion
        }

        // Key unpress detectie
        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            #region Car1 config
            //Car 1 config
            if (e.KeyCode == Keys.D)
                _Car1.right = false;
            if (e.KeyCode == Keys.A)
                _Car1.left = false;
            if (e.KeyCode == Keys.W)
                _Car1.Throttle = false;
            if (e.KeyCode == Keys.S)
                _Car1.Brake = false;
            #endregion

            #region Car2 Config
            //Car 2 config
            if (e.KeyCode == Keys.Right)
                _Car2.right = false;
            if (e.KeyCode == Keys.Left)
                _Car2.left = false;
            if (e.KeyCode == Keys.Up)
                _Car2.Throttle = false;
            if (e.KeyCode == Keys.Down)
                _Car2.Brake = false;
            #endregion
        }


    }
}
