using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_4
{
    internal class Rectangle
    {
        public int w { get; set; }
        public int h { get; set; }

        public Rectangle(int w, int h)
        {
            this.w = w;
            this.h = h;
        }
        public Rectangle()
        {
            w = 0;
            h = 0;
        }
        public Rectangle(int x)
        {
            w=x;
            h = x;
        }


    }
}
