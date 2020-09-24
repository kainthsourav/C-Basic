using System;

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
}
