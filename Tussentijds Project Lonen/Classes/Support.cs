using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijds_Project_Lonen.Classes
{
    public class Support : Employee
    {
        public bool ITSupport { get; set; }
        public double RemoteBonus = 50;
        public double CourseRefund = 19.50;

        public Support(string name, bool sex, DateTime birthdate, DateTime joindate, double salary, bool fulltime, int seniority, bool itsupport)
            :base(name, sex, birthdate, joindate, fulltime, seniority)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            JoinDate = joindate;
            GenerateSocialSec();
            Fulltime = fulltime;
            StartingSalary = Fulltime ? StartingSalary = 2050 : StartingSalary = 1348.68;
            Salary = salary;
            Seniority = seniority;
            ITSupport = itsupport;
        }

        public override string ToString()
        {
            if (ITSupport) return "IT Support";
            else return "Custumer Support";
        }
    }
}
