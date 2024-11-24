using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Abstratas
{
    class Rectangles :  Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }
        public Rectangles (double width, double heigth, Color color) : base(color)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Area()
        {
            return Width * Heigth;
        }
    }
}
