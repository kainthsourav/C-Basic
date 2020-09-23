using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
   public class Operateors
    {
        public Operateors(){}

        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Div(int a,int b)
        {
           
            Console.WriteLine((float)a / (float) b);
        }
        public void Min(int a,int b)
        {
           
            Console.WriteLine(a-b);
        }
        public  void Mul(int a,int b)
        {
            Console.WriteLine(a*b);
        }

        public void Logcial(int a,int b,int c)
        {
            Console.WriteLine(a>b);
        }

    }
    

}
