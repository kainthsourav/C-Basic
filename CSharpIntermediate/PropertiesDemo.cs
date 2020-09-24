using System;

namespace CSharpIntermediate
{
    public class PropertiesDemo
    {
        private DateTime _birthdate;
        public void SetDateTime(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetDateTime()
        {
            return _birthdate;
        }
    }
}
