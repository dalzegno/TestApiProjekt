using System;

namespace Logic.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { private get; set; }

        public string DateString => DateOfBirth.ToShortDateString();
    }
}
