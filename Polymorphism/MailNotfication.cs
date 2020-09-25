using System;

namespace Polymorphism
{
    public class MailNotfication : INotfication
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail");
        }
    }
}
