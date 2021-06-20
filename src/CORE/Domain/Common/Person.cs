using System;
using Domain.Enums;

namespace Domain.Common
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime BornDate { get; set; }

        public PersonalDocument TypeDocument { get; set; }
        public string Document { get; set; }

        public string Address { get; set; }
        public string TelephonNumber { get; set; }
        public string Email { get; set; }
    }
}
