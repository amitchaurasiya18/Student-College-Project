using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeProject
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person (int id, string name, string address, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        public virtual string PrintPersonDetails()
        {
            return $"Id : {Id}\nName : {Name}\nAddress : {Address}\nDOB : {DateOfBirth}\n-----------";
        }
    }
}
