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
        private Loop loop = new Loop();

		private Sprite car1 = new Sprite();  // new instance of Sprite called car1
		private Sprite car2  = new Sprite(); // new instance of Sprite called car2
        
	    private Graphics g;
        #endregion

        public Form()
        {
            InitializeComponent();
            tmrMoving.Interval = 16;
            car2.image = Image.FromFile(@"resources\sprites\car2.png");
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
           loop.Render(g, car1, car2); //changed some of the rendercode - it works but could be done better. - Peter 

            #region Speed-o-meter
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
                car2.Throttle =  true;
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


    }
}
