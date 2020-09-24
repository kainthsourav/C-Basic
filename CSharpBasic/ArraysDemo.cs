using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class ArraysDemo
    {
        public void Demo()
        {
            var number = new [] { 3, 4, 5, 6, 7 };
            Console.WriteLine(number.Length);
            var index=Array.IndexOf(number, 4);
            Console.WriteLine("Index of 4 is "+index);


        }
    }
}
