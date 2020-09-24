using System.Collections.Generic;

namespace CSharpIntermediate
{
    //constructors Demo
    public class Customer
    {
        public int id;
        public string Name;
        public List<Order> Orders;

        //No Parameter -custom  constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        
        //constructors overloading
        public Customer(int id):this()//--this will call cust with no param so List can be initizied
        {
            this.id = id;
        }
        //with Para
        public Customer(int id, string Name) : this(id) //--this will call cust with id param so it can be initizied
        {
            this.id = id;
            this.Name = Name;
        }
    }
}
