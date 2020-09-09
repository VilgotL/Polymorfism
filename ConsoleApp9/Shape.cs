using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Shape
    {
        protected double width;
        protected double height;

        public virtual void Area()
        {
        }

        public virtual void Circumferance()
        {
        }
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
