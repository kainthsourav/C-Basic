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

          //  Explicit / Casting Type Conversaton
            int x = 1;
            byte by = (byte)x;
            float ff = 1.0f;
            int y = (int)ff;

            //Non Compatible Type
            string s = "1";
            i = Convert.ToInt32(s);
            int j = int.Parse(s);

            try
            {
                var num = "1";
                b = Convert.ToByte(num);
                Console.WriteLine(b);
                Operateors op = new Operateors();
                op.Add(30,40);
                op.Div(10, 2);
                op.Min(100, 50);
                op.Mul(5, 5);
                op.Logcial(4, 2, 6);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Enum Demo Class
            var enumDemo = new DemoEnum();
            enumDemo.EnumDemo();


            //Reference Types and Values Types
            var referAndValue = new ReferanceAndValueType();
            referAndValue.Value();
            referAndValue.Refer();

            //condtional statements
            var cStatements = new CondtionalStatements();
            cStatements.ControlFlow();

            Console.ReadLine();
        }
    }
}
