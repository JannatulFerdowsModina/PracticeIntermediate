using System;

namespace PracticeIntermediate
{
    public class employee
    {
        public DateTime _birthDate { get; private set; }
        public employee(DateTime datetime)
        {
            _birthDate = datetime;
        }
        public int Age
        {
            get{
                var timespan = DateTime.Today - _birthDate;
                var years = timespan.Days / 365;
                return years;
            }
            
        }
    }
}
