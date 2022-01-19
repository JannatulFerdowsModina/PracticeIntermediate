using System;

namespace PracticeIntermediate
{
    public class Student
    {
        private DateTime _birthDate;
        public void set(DateTime birthdate)
        {
            _birthDate = birthdate;
        }
        public DateTime get()
        {
            return _birthDate;
        }
    }
}
