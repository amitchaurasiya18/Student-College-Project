using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeProject
{
    class Student : Person
    {
        public string Branch { get; set; }

        public Student(int id, string name, string address, DateTime dateOfBirth, string branch) : base(id, name, address, dateOfBirth)
        {
            Branch = branch;
        }

        public override string PrintPersonDetails()
        {
            return $"Id : {Id}\nName : {Name}\nAddress : {Address}\nDOB : {DateOfBirth}\nBranch : {Branch}\n-----------";
        }
    }
}
