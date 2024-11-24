using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Abstratas
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius,Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
