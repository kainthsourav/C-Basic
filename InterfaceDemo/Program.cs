using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var dbm = new Dbmigrator(new ConsoleLogger());
            dbm.Migrate();
           

            //Extensible to FileSystem
            var FileObj = new Dbmigrator(new FileLogger("D:\\log.txt"));
            FileObj.Migrate();

            System.Console.ReadLine();


        }
    }
}
