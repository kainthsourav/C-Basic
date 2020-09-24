using System;

namespace CSharpIntermediate
{
    public class PropertiesDemo
    {

        public DateTime Birthdate{get;private set; }//this can't be changed or accessed to set

        //public void SetDateTime(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}
        //public DateTime GetDateTime()
        //{
        //    return _birthdate;
        //}
        public PropertiesDemo(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
    }
}
