using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores
{
    class Rectangle
    {
        private int Width => Area / Height;
        private int Height { get; }
        private int Area { get; }

        public Rectangle(int width, int height)//, ConsoleColor? color = null)
        {
            //if (color == null) color = ConsoleColor.Black;
            Height = height;
            Area = width * height;
        }

        /*
                
        public int Width { get; }
        public int Height { get; }
        public int Area => Width * Height;

        public Rectangle(int width, int height)
        {
            Height = height;
            Width = width;
        }
         */

    }
}
