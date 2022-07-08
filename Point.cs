using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// comment
// Palash Tichkule
namespace Person_Library
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x,int y)
        {
          this.x = x;
          this.y = y;
        }
       public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public override string ToString()
        {
            string result = string.Format("X={0} Y={1}",this.x,this.y);
            return result;
        }

    }
}
