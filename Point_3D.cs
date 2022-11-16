using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_16_11_2022_3D_point
{
    internal class Point_3D : Point<int>
    {
        public int z1 { get; set; }
        public Point_3D(int X1, int Y1, int Z1) :base (X1,Y1)
        {

            this.z1 = Z1;
        }
        public override string ToString()
        {
            return $"Точка  x {this.x1}, y {this.y1}, z{this.z1}";
        }

    }
}

