using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik.Services
{
    public class PersonService
    {
        private static readonly List<Person> _people = new()
        {
            new Person
            {
                FirstName = "Peter",
                LastName = "Wallenäs",
                DateOfBirth = new DateTime(1991, 11, 28)
            },
            new Person
            {
                FirstName = "Victor",
                LastName = "Nekludov",
                DateOfBirth = new DateTime(1992, 2, 6)
            },
            new Person
            {
                FirstName = "Barbro",
                LastName = "Larsson",
                DateOfBirth = new DateTime(1956, 01, 01)
            }
        };




    }
}
