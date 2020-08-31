using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijds_Project_Lonen
{
    public class Employee
    {
        public string Name { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string SocialSecNr { get; set; }
        public DateTime JoinDate { get; set; }
        public bool Fulltime { get; set; }
        public string Bankaccount { get; set; }
        public double StartingSalary { get; set; }
        public double Salary { get; set; }
        public int Seniority { get; set; }
        public Employee(string name, bool sex, DateTime birthdate, DateTime joindate, bool fulltime, int seniority)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            JoinDate = joindate;
            GenerateSocialSec();
            Fulltime = fulltime;
            StartingSalary = Fulltime ? StartingSalary = 1900 : StartingSalary = 1250;
            Seniority = seniority;
        }
        // Generate new social security number based on birthdate.
        public void GenerateSocialSec()
        {
            Random rng = new Random();

            SocialSecNr = Birthdate.ToString() + rng.Next(99).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(9999);
                SocialSecNr += " " + randomnr.ToString().PadLeft(4, '0');
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public double AddSeniority()
        {
            for (int i = Seniority; i > 0; i--)
            {
                Salary = StartingSalary * 1.01;
            }

            return Salary;
        }

        public double DeductSocialSecurity()
        {
            return Salary -= 200;
        }

        public double DeductWitholdingTax()
        {
            return Salary -= (Salary * 0.1368);
        }
    }
}