using System;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Employee : Person
    {
        public Employee() : base()
        {
        }

        public Access Access { get; set; }
        public string User { get; set; }
        public string Password { get; set; } //TODO 
    }
}
