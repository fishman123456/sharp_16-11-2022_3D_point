

using System.Drawing;

namespace sharp_16_11_2022_3D_point
{
    internal class P_Line<T> where T : struct
    {
        Point<T> one;
        Point<T> two;
        public P_Line (Point<T> one,Point <T> two )
        {
            this.one = one;
            this.two = two;
        }
        public P_Line (T Ax, T Ay, T Bx, T By) 
        {
            one = new Point<T> (Ax, Ay);
            two = new Point<T> (Bx, By);
        }
        public override string ToString()
        {
            return $"Прямая от точки {this.one} до точки {this.two}";
        }
    }
}

