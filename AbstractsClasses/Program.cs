using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectange = new Rectangle();
            rectange.Draw();

            Console.WriteLine("Press any key to exit.....");
            Console.ReadLine();
        }
    }
}
