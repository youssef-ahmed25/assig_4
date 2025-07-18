using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_4
{
    internal class Duration
    {

        public int hour { get; set; }
        public int min { get; set; }
        public int sec{ get; set; }

        public Duration(int h, int m, int s)
        {
            this.hour = h;
            this.min = m;
            this.sec = s;
        }
        public Duration(int total)
        {
            hour = total / 3600;
            min = (total / 60) % 60;
            sec = total % 60;
        }
        public override string ToString()
        {
         return $"hour:{hour}, min:{min}, sec:{sec}";
        }
        public override int GetHashCode()
        {
            return (hour*3600) + (min * 60) + sec;
        }
        //public static Duration operator +(Duration d1, Duration d2)
        //{
        //    return new Duration()
        //    {

        //    };
        //}

        //public static Duration operator +(Duration d1, int sec)
        //{
        //     return new Duration()
        //    {

        //    };


        //}
    }
}
