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
        Loop loop = new Loop();
        Graphics g;

        public Form()
        {
            InitializeComponent();
            tmrMoving.Interval = 18;
            //loop.Start(pnlCanvas);
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            //g = pnlCanvas.CreateGraphics();

           // loop.Render(pnlCanvas, e.Graphics);
        }


        private void Form_Load(object sender, EventArgs e)
        {
            //loop.Start(pnlCanvas);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            //loop.Update(pnlCanvas, g);
            //loop.Render(pnlCanvas, g);
        }
    }
}
