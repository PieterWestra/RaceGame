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

namespace Forms
{
    
    public partial class Form : System.Windows.Forms.Form
    {
        Graphics g;

        bool left = false;
        bool right = false;
        float force = 0f;

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
            Loop.Start(pnlCanvas);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            Loop.Update(pnlCanvas, g);
            Loop.Render(pnlCanvas, g);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                Movement.right = true;
            if (e.KeyCode == Keys.A)
                Movement.left = true;
            if (e.KeyCode == Keys.W)
                Movement.force = 5f;
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                Movement.right = false;
            if (e.KeyCode == Keys.A)
                Movement.left = false;
            if (e.KeyCode == Keys.W)
                Movement.force = 0f;
        }
    }
}
