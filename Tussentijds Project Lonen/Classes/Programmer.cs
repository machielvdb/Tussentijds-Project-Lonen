using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijds_Project_Lonen.Classes
{
    public class Programmer : Employee
    {
        public double WithholdingTax { get; set; }
        public Programmer(string name, bool sex, DateTime birthdate, DateTime joindate,
            int hours, int seniority, bool companycar, double startingsalary):base(name, sex, birthdate, joindate, hours, seniority, startingsalary)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            Hours = hours;
            JoinDate = joindate;
            GenerateSocialSec();
            StartingSalary = startingsalary;
            Seniority = seniority;
            CompanyCar = companycar;
            WithholdingTax = CompanyCar ? WithholdingTax = 17.30 : WithholdingTax = 13.68;
            Title = "Programmer";
        }
    }
}