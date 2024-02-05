using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Non-default constructor
        public Rectangle(int length, int width)
        {
            SetLength(length);
            SetWidth(width);
        }

        public int GetLength()
        {           
            return length;
        }

        public int SetLength(int newLength)
        {
            length = newLength;
            if (length < 0 || length > 1100)
            {
                length = -1;
            }
            return length;
        }


        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int newWidth)
        {
            width = newWidth;
            if (width < 0 || width > 1100)
            {
                width = -1;
            }
            return width;
        }

        public int GetPerimeter()
        {
            if (width < 0 || length <0 || width >1100 || length > 1100)
            {
                return -1;
            }
            return 2 * (length + width);
        }

        public int GetArea()
        {
            if (width < 0 || length < 0 || width > 1100 || length > 1100)
            {
                return -1;
            }
            return length * width;
        }
    }
}
