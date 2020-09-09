using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double höjd;
            double bredd;
            int form;
            Console.WriteLine("Höjd: ");
            höjd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bredd: ");
            bredd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv 1 om det är en rätvinklig triangel och 2 om det är en rektangel");
            form = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Shape s;
            if (form == 1)
            {
                s = new Triangle(bredd, höjd);
            }
            else
            {
                s = new Rectangle(bredd, höjd);
            }
            s.Area();
            s.Circumferance();
            Console.ReadLine();
        }
    }
}
