using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
   public class IterationStatements
    {
        public void Iteration()
        {
            //for  foreach  while while_do
            Console.WriteLine("For");
            for (var i = 0; i <10; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("Number is "+i);
                }
            }

            Console.WriteLine("Foreach");
            var array = new int[3] { 1, 2, 10 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("While");
            var x = 0;
            while (x<=10)
            {
                if(x%2==0)
                    Console.WriteLine(x);

                x++;
            }

            Console.WriteLine("DO While");
            var y = 10;
            do
            {
               if(y%2==0)
                    Console.WriteLine(y);
                y--;
            } while (y!=0);
        }
    }
}
