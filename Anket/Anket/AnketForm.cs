using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket
{
    internal class AnketForm
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FatherName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool? Gender { get; set; }

        public AnketForm() { }

        public AnketForm(string? name, string? surname, string? fatherName, 
            string? country, string? city, string? phone, DateTime birthDate, bool? gender)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            BirthDate = birthDate;
            Gender = gender;
        }
    }
}
