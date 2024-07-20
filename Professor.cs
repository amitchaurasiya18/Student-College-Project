using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeProject
{
    class Professor : Person
    {
        public double BasicPay { get; set; }

        public const double HOUSE_RENTAL_ALLOWANCE = 0.3;
        public const double DEARNESS_ALLOWANCE = 0.5;

        public Professor(int id, string name, string address, DateTime dateOfBirth, double basicPay) : base(id, name, address, dateOfBirth)
        {
            BasicPay = basicPay;
        }

        public double CalculateSalary()
        {
            double salary = this.BasicPay + (HOUSE_RENTAL_ALLOWANCE * this.BasicPay) + (DEARNESS_ALLOWANCE * this.BasicPay);
            return salary;
        }

        public override string PrintPersonDetails()
        {
            return $"Id : {Id}\nName : {Name}\nAddress : {Address}\nDOB : {DateOfBirth}\nSalary : {CalculateSalary()}\n-----------";
        }
    }
}
