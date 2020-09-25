using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();
            videoEncoder.RegisterNotfication(new MailNotfication());
            videoEncoder.RegisterNotfication(new SmsNotfication());

            videoEncoder.Encode(new Video());
            System.Console.ReadLine();

        }
    }
}
