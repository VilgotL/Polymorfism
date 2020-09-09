using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }
        public override void Area()
        {
            double area = width * height;
            Console.WriteLine("Area: " + area);
        }

        public override void Circumferance()
        {
            double circ = width + width + height + height;
            Console.WriteLine("Omkrets: " + circ);
        }
    }
}
