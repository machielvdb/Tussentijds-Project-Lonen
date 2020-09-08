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

        public Support(string name, bool sex, DateTime birthdate, DateTime joindate, double salary, int hours, int seniority, bool itsupport, double startingsalary, string title)
            :base(name, sex, birthdate, joindate, hours, seniority, startingsalary)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            JoinDate = joindate;
            GenerateSocialSec();
            Hours = hours;
            StartingSalary = salary;
            Salary = salary;
            Seniority = seniority;
            ITSupport = itsupport;
            Title = ITSupport ? Title = "IT Support" : Title = "CS Support";
        }

        public override string ToString()
        {
            if (ITSupport) return "IT Support";
            else return "Custumer Support";
        }
    }
}
