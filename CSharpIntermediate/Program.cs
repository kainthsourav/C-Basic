using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{


    public class Program
    {
        public string Name;
        //default constructors
        public Program()
        {

        }
        //parameterised constructors
        public Program(string name)
        {
            this.Name = name;
        }
        //constructors overloading
        public Program(int id,string Name)
        {

        }

        static void Main(string[] args)
        {
            //var Person = new Person();
            // Person.Name = "Sourav";
            // Person.Intro("Kainth");

            //class and Static Function Demo
            var Per = Person.Parse("Sourav");
            Per.Intro("Kainth");

            //constructors demo
            //Default constructor
            var customer = new Customer();
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.Name);

            //Parameter constructor
            var cus = new Customer(1, "Sourav");
            Console.WriteLine("Parameter constructo {0} {1}", cus.id, cus.Name);

            //constructors overloading
            var cusm = new Customer(5);
            Console.WriteLine("constructors overloading {0}", cusm.id);

            //Orders --- Custructoer
            var order = new Order();
            customer.Orders.Add(order);


            //Object Intitialzers
            //without making mutiple const
            var Oi = new ObjectInitializer
            {
                FirstName = "Sourav",
                LastName = "Kainth"
            };



            Console.ReadLine();
        }
    }
}
