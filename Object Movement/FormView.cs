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

        private int _x;
        private int _y;
        private Position _objPosition;
        //public static object Keyboard { get; private set; }
        //public class KeyEventArgs : EventArgs 



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
        
        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Red, _x, _y, 100, 100);
        
            // Create image.
            Image newImage = Image.FromFile("Car.png");

            // of image and for size of image.
            int height = 48;
            int width = 96;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, _x, _y, width, height);
        }



        /*
        public static IEnumerable<Key> FormView_KeysDown()
        {
            foreach (Key key in Enum.GetValues(typeof(Key)))
            {
                if (Keyboard.IsKeyDown(key))
                    yield return key;
            }
        }
        */




        private void tmrMoving_Tick(object sender, EventArgs e)
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


            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
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
    }
}
