using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStation
{
    class MyPoint
    {
        private int x = 0;
        private int y = 0;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
            
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public static bool Equals(MyPoint a, MyPoint b)
        {
            return (a != null && b != null && a.X == b.X && a.Y == b.Y);
        }

        public bool Equals(MyPoint point)
        {
            return (point != null && X == point.X && Y == point.Y);
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;

            MyPoint p = obj as MyPoint;
            if ((System.Object)p == null)
                return false;

            return (X == p.X) && (Y == p.Y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
}
