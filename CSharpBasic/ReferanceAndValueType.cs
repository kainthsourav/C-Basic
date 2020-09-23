using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
   public class ReferanceAndValueType
    {
        public void Value()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a :" + a + " b:" + b);
        }
        public void Refer()
        {
            var array_1 = new int[3] { 1, 2, 3 };
            var array_2 = array_1;
            array_2[0] = 0;


            Console.WriteLine(array_1[0] +" "+array_2[0]);
        }

    }
}
