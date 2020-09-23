using System;

namespace CSharpBasic
{
    public class DemoEnum
    {
        public enum ShipingMethod
        {
            RegularAirMail=1,
            RegisterAirMail=2,
            Express=3
        }
       public  void EnumDemo()
        {
            var method = ShipingMethod.Express;
            System.Console.WriteLine(method);

            var methodId = 3; //data from somewhere else
            System.Console.WriteLine((ShipingMethod)methodId); //convert to enum

            System.Console.WriteLine(method.ToString());//converting to string

            var methodName = "Express";
            var shiping=(ShipingMethod)Enum.Parse(typeof(ShipingMethod), methodName); //convert stiring to enum

        }
    }
}
