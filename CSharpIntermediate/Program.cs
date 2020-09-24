using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;

        public void Intro(string name)
        {
            Console.WriteLine("Hi {0}, I am {1}", name, Name);
        }
        public static Person Parse(string str)
        {
            var Person = new Person();
            Person.Name = str;
            return Person;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //var Person = new Person();
            // Person.Name = "Sourav";
            // Person.Intro("Kainth");

            //Static Function
            var Per = Person.Parse("Sourav");
            Per.Intro("Kainth");

            Console.ReadLine();
        }
    }
}
