using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Person
    {
        public Person(int id, string firstname, string lastname, DateTime date, string phone, string city,string street,int house, int? flat)
        {
            Id = id;
            FirstName = firstname; 
            LastName = lastname;
            Date = date;
            Phone = phone;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }
        public Person() { }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Date { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public string Street { get; set; }

        public int House { get; set; }

        public int? Flat { get; set; }

    }
}
