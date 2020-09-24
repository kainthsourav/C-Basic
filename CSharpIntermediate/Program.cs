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
           
           

            Program.Method();

            //Properties
            var prop = new PropertiesDemo();
            prop.SetDateTime(new DateTime(1980, 1, 1));
            Console.WriteLine(prop.GetDateTime());

            Console.ReadLine();
        }
        public static void Method()
        {
            //Method Demo and overloading
            try
            {
                var methodDemo = new MethodDemo(10, 20);
                methodDemo.Move(new MethodDemo(40, 60));
                Console.WriteLine("Point is at X: {0} Y:{1}", methodDemo.x, methodDemo.y);

                methodDemo.Move(400, 800);
                Console.WriteLine("Point is at X: {0} Y:{1}", methodDemo.x, methodDemo.y);
            }
            catch (Exception)
            {

                Console.WriteLine("Error Occured");
            }
        }
    }
}
