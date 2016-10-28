using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Image img = Image.FromFile(@"C:\Users\Pieter\Desktop\image.png");
        float angleDegrees = 0f;
        float scaleFactor = 1f;
        bool turn = false;
        bool left = false;

        float force;
        float direction;

        float xMult, yMult;
        float x = 0;
        float y = 0;

        Bitmap b;

        int oldWidth, oldHeight, newWidth, newHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            //graph = pnlCanvas.CreateGraphics();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                turn = true;
            if (e.KeyCode == Keys.A)
                left = true;
            if (e.KeyCode == Keys.W)
                force = 5f;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                turn = false;
            if (e.KeyCode == Keys.A)
                left = false;
            if (e.KeyCode == Keys.W)
                force = 0f;
        }

        private void tmrGameTicks_Tick(object sender, EventArgs e)
        {
           // angleDegrees += 1;

            if (turn)
                angleDegrees += 5;
            if (left)
                angleDegrees -= 5;

            if (angleDegrees >= 360)
                angleDegrees -= 360;
            if (angleDegrees < 0)
                angleDegrees += 360;

            lblAngle.Text = "Angle: " +  Convert.ToString(angleDegrees);
            lblForce.Text = "Force: " + Convert.ToString(force);
            lblX.Text = "Xpos: " + xMult;
            lblY.Text = "Ypos: " + yMult;

            // MOVEMENT
            if (angleDegrees >= 0 && angleDegrees <= 90)
            {
                direction = (90 - angleDegrees) * 0.0174533f;

                xMult = (float)Math.Sin(direction);
                yMult = (float)(Math.Sqrt(1 - Math.Pow(xMult, 2)));

                x += force * xMult;
                y += force * yMult;
            }
            if (angleDegrees >= 90 && angleDegrees < 180)
            {
                direction = (180 - angleDegrees) * 0.0174533f;

                yMult = (float)Math.Sin(direction);
                xMult = (float)(Math.Sqrt(1 - Math.Pow(yMult, 2)));

                x -= force * xMult;
                y += force * yMult;
            }
            if (angleDegrees >= 180 && angleDegrees < 270)
            {
                direction = (270 - angleDegrees) * 0.0174533f;

                xMult = (float)Math.Sin(direction);
                yMult = (float)(Math.Sqrt(1 - Math.Pow(xMult, 2)));

                x -= force * xMult;
                y -= force * yMult;
            }
            if (angleDegrees >= 270 && angleDegrees <= 360)
            {
                direction = (360 - angleDegrees) * 0.0174533f;

                yMult = (float)Math.Sin(direction);
                xMult = (float)(Math.Sqrt(1 - Math.Pow(yMult, 2)));

                x += force * xMult;
                y -= force * yMult;
            }

            Render();
        }

        void Render()
        {
            Graphics gfx = pnlCanvas.CreateGraphics();

            gfx.Clear(Color.Gray);
            
           // gfx.TranslateTransform();
           // gfx.RotateTransform();

           // draw

           // gfx.ResetTransform();

            gfx.DrawImage(GetImage(), x - newWidth / 2, y - newHeight / 2);
            gfx.DrawImage(GetImage(), x - newWidth / 2 + 50, y - newHeight / 2 + 50);
            gfx.Dispose();
            
        }

        Image GetImage()
        {
            if (b != null)
                b.Dispose();

            Image image = Image.FromFile(@"C:\Users\Pieter\Desktop\image.png");


            oldWidth = image.Width;
            oldHeight = image.Height;

            // Math
            double angleRadians = angleDegrees * Math.PI / 180d;

            double cos = Math.Abs(Math.Cos(angleRadians));
            double sin = Math.Abs(Math.Sin(angleRadians));
            newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
            newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);

            // Image bounds


            b = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(b);

            oldWidth = image.Width;
            oldHeight = image.Height;
            scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);

            g.TranslateTransform(newWidth / 2f, newHeight / 2f);
            g.RotateTransform(angleDegrees);
            g.TranslateTransform(-oldWidth / 2, -oldHeight / 2);

            g.Clear(Color.Black);
            g.DrawImage(image, 0, 0, image.Width, image.Height);

            image.Dispose();
            g.Dispose();

            return b;
        }
    }
}
