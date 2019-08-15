using System;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner.Entities
{
    public class Employee : IUpsertable
    {
        public Guid EmployeeId { get; set; }
        public int EmployeeNumber { get; set; }
        public Country Country { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }
        public string Street { get; set; }
        public string Housenumber { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }

        public Employee()
        {
        }

        public override string ToString()
        {
            return $"{EmployeeNumber} - {Lastname}";
        }
    }
}