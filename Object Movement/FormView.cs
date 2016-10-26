using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Object_Movement
{
    public partial class FormView : Form
    {
        enum Position
        {
            Up, Down, Left, Right
        }
        enum Rotation
        {
            Q, E
        }

        public int _x;
        public int _y;
        private Position _objPosition;
        //public static object Keyboard { get; private set; }
        //public class KeyEventArgs : EventArgs 
        public static Keys ModifierKeys { get; }


        public FormView()
        {
            InitializeComponent();
            _x = 50;
            _y = 50;
            _objPosition = Position.Right;
        }

        private void FormView_KeyUp(object sender, KeyEventArgs e)
        {
            
        }



        public Graphics car = null;
        public Bitmap image = new Bitmap(@"Car1.png");


        public void FormView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("Car1.png"), _x, _y, 48, 24);
            car = CreateGraphics();
        }







        private void FormView_KeyDown(object sender, KeyEventArgs e/*, PaintEventArgs g*/)
        {
            if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
                /*if (e.KeyCode == Keys.Q)
                {
                    g.Graphics.DrawImage(new Bitmap("Car.png"), _x, _y, 48, 24);
                    g.Graphics.RotateTransform(10.0F);
                }*/
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }
            else if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
        }


        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            bool vroom;
            if (Control.ModifierKeys == Keys.Shift)
            {
                vroom = true;
            }
            else
            {
                vroom = false;
            }

            if (vroom == true)
            {
                if (_objPosition == Position.Up)
                {
                    _y -= 10;
                }
                else if (_objPosition == Position.Down)
                {
                    _y += 10;
                }
                else if (_objPosition == Position.Right)
                {
                    _x += 10;
                }
                else if (_objPosition == Position.Left)
                {
                    _x -= 10;
                }
            }

            Invalidate();
        }




    }
}
