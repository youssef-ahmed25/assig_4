using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace assig_4
{
    internal class Complex_Number
    {
        public int r { get; set; }
        public int i { get; set; }

        public static Complex_Number operator +(Complex_Number left, Complex_Number right)
        {
            return new Complex_Number()
            {
                r = (left?.r ?? 0) + (right?.r ?? 0),
                i = (left?.i ?? 0) + (right?.i ?? 0)
            };
        }

        public static Complex_Number operator -(Complex_Number left, Complex_Number right)
        {
            return new Complex_Number()
            {
                r = left.r - right.r,
                i = left.i - right.i
            };
        }
        public override string ToString()
        {
            return $"{r} + {i}i";
        }
    }
}
