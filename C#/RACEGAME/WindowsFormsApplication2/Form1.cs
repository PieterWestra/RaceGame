using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Bitmap Backbuffer;              //truc om flikkeren te voorkomen bij tekenen

       
        Image image = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Miara.png"));
        //Opmerking: als je nieuwe plaatje wilt inladen zorg ervoor dat je de volgende Property aanpast in visual studio voor het desbtrefende plaatje:
        //Copy To Output Directory: Copy if newer


        float angleDegrees = 0f;
        float scaleFactor = 1f;
        bool turn = false;
        bool left = false;

        float force;
        float direction;
        double newX, newY;

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

            // MOVEMENT
            if (angleDegrees >= 0 && angleDegrees <= 90)
            {
                direction = 90 - angleDegrees;

                double A = Math.Sin(direction);
                double B = Math.Sqrt(1 - Math.Pow(A, 2));

                newX += (double)(1 * Math.Pow(B, 2));
                newY += (double)(1 * A);

                /*
                 * float percentageTurned = (100 / 90) * direction;
                 * float newX += speed * 
                 * float newY += speed * 
                 * 
                 * C = 1
                 * sin(direction) = A
                 * B = sqrt(C^2 - A^2)
                 * 
                 * */
            }
            if (angleDegrees >= 90 && angleDegrees <= 180)
            {
                direction = 180 - angleDegrees;
            }
            if (angleDegrees >= 180 && angleDegrees <= 270)
            {
                direction = 270 - angleDegrees;
            }
            if (angleDegrees >= 270 && angleDegrees <= 360)
            {
                direction = 360 - angleDegrees;
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

            gfx.DrawImage(GetImage(), (int)Math.Pow(newX, 2), (int)Math.Pow(newY, 2));
            gfx.Dispose();
            
        }

        Image GetImage()
        {
            if (b != null)
                b.Dispose();

            Image image = Image.FromFile(@"C:\Users\Peter\Documents\School\Periode 1\RACEGAME\C#\RACEGAME\WindowsFormsApplication2\Miara.png");


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
