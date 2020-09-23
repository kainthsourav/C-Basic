using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{

    public class CondtionalStatements
    {
        public void ControlFlow()
        {
            var hour = 10;
            //if else elseif
            if(hour>0 && hour<13)
            {
                Console.WriteLine("It's Morning");
            }
            else if(hour>=12 && hour<18)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Evening");
            }

            var season = Season.Authum;
            switch(season)
            {
                case Season.Authum:
                    Console.WriteLine("It is authum");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer");
                    break;
                default:
                    Console.WriteLine("Invaild Case");
                    break;
            }
            
        }
    }
}
