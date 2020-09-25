using System.Collections.Generic;

namespace Polymorphism
{
    internal class VideoEncoder
    {
        private readonly IList<INotfication> _notification;
        public VideoEncoder()
        {
            _notification = new List<INotfication>();

        }
        public void Encode(Video video)
        {
            foreach (var item in _notification)
            {
                item.Send(new Message());
            }
        }
        public void RegisterNotfication(INotfication notfication)
        {
            _notification.Add(notfication);
        }
    }
}