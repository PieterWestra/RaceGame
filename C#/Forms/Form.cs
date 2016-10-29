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
		private Loop loop = new Loop();

		private Sprite car1 = new Sprite();
	    private Sprite _car2  = new Sprite(); //new instance of Sprite called car2

	    private void setbitmap(string location)
	    {
	        location =@"sprites\car1.png";
          _car2.image = Image.FromFile(@location);
         }



	    private Graphics g;
		

        public Form()
        {
            InitializeComponent();
            tmrMoving.Interval = 18;
		}

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            g = pnlCanvas.CreateGraphics();
		}


        private void Form_Load(object sender, EventArgs e)
        {
            loop.Start();
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            loop.Update(car1, _car2);
            //loop.Update(_car2);
            loop.Render(g, car1, _car2);
            //loop.Render(g, _car2);  

			lblAngle.Text = "Angle: " + car1.angleDegrees;
			lblForce.Text = "Force: " + car1.force;
			lblXmult.Text = "Xmult: " + car1.xMult;
			lblYmult.Text = "Ymult: " + car1.yMult;

			// "Double buffering" hack
			g.CopyFromScreen(new Point(0, 0), new Point(pnlCanvas.Width, pnlCanvas.Height), new Size(1, 1));
			g.CopyFromScreen(new Point(0, 0), new Point(pnlCanvas.Width, pnlCanvas.Height), new Size(1, 1));
		}

		// Key press detectie
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                car1.right = true;
            if (e.KeyCode == Keys.A)
                car1.left = true;
            if (e.KeyCode == Keys.W)
                car1.force = 10f;
			if (e.KeyCode == Keys.S)
				car1.force = -5f;
        }

		// Key unpress detectie
        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                car1.right = false;
            if (e.KeyCode == Keys.A)
                car1.left = false;
            if (e.KeyCode == Keys.W)
                car1.force = 0f;
			if (e.KeyCode == Keys.S)
				car1.force = 0f;
		}
	}
}
