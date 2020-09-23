using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversation
            byte b = 1;
            int i = b;
            float f = i;

            //Explicit/Casting Type Conversaton
            //int x = 1;
            //byte by = (byte)x;
            //float ff = 1.0f;
            //int y = (int)ff;

            //Non Compatible Type
            string s = "1";
            i = Convert.ToInt32(s);
            int j = int.Parse(s);

            try
            {
                var num = "1";
                b = Convert.ToByte(num);
                Console.WriteLine(b);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
