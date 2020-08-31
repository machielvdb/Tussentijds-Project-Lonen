using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijds_Project_Lonen.Classes
{
    public class Programmer : Employee
    {
        public bool CompanyCar { get; set; }
        public double WithholdingTax { get; set; }
        public Programmer(string name, bool sex, DateTime birthdate, DateTime joindate,
            bool fulltime, int seniority, bool companycar):base(name, sex, birthdate, joindate, fulltime, seniority)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            Fulltime = fulltime;
            StartingSalary = Fulltime ? StartingSalary = 2200 : StartingSalary = 1447.36;
            JoinDate = joindate;
            GenerateSocialSec();
            Salary = StartingSalary;
            Seniority = seniority;
            CompanyCar = companycar;
            WithholdingTax = CompanyCar ? WithholdingTax = 17.30 : WithholdingTax = 13.68;
        }
        public void ProgrammerWitholdingTax()
        {
            if (CompanyCar) Salary -= (Salary * 0.1730);
            else DeductWitholdingTax();
        }
    }
}
