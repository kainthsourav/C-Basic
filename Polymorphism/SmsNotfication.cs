using System;

namespace Polymorphism
{
    public class SmsNotfication : INotfication
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS");
        }
    }
}
