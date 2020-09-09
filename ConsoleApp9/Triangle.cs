using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override void Area()
        {
            double area = width * height;
            area = area / 2;
            Console.WriteLine("Area: " + area);
        }

        public override void Circumferance()
        {
            double hypotenusa = Math.Sqrt(width * width + height * height);
            double circ = width + height + hypotenusa;
            Console.WriteLine("Omkrets: " + circ);
        }
    }
}
