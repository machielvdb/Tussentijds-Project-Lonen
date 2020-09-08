using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tussentijds_Project_Lonen
{
    public class Employee
    {
        public string Name { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string SocialSecNr { get; set; }
        public DateTime JoinDate { get; set; }
        public int Hours { get; set; }
        public string Bankaccount { get; set; }
        public double StartingSalary { get; set; }
        public double Salary { get; set; }
        public int Seniority { get; set; }
        public string Title { get; set; }
        public bool CompanyCar = false;

        public Employee(string name, bool sex, DateTime birthdate, DateTime joindate, int hours, int seniority, double startingsalary)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            JoinDate = joindate;
            GenerateSocialSec();
            Hours = hours;
            StartingSalary = startingsalary;
            Seniority = seniority;
            GenerateBankAccount();
            Title = "Employee";
        }
        // Generate new social security number based on birthdate.
        public void GenerateSocialSec()
        {
            Random rng = new Random();

            SocialSecNr = Birthdate.ToString("yyMMdd") + rng.Next(99).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 2; i++)
            {
                int randomnr = rng.Next(9999);
                SocialSecNr += " " + randomnr.ToString().PadLeft(4, '0');
            }
        }
        public void GenerateBankAccount()
        {
            Random rng = new Random();

            Bankaccount = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(9999);
                Bankaccount += " " + randomnr.ToString().PadLeft(4, '0');
            }
        }
        public override string ToString()
        {
            return Name;
        }

        public double AddSeniority()
        {
            double seniority = 0;
            Salary = StartingSalary;
            for (int i = Seniority; i > 1; i--)
            {
                Salary *= 1.01;
                seniority = Salary - StartingSalary;
            }
            return seniority;
        }

        public double DeductSocialSecurity()
        {
            double deducted = 200;
            Salary -= deducted;
            return deducted;
        }

        public double DeductWitholdingTax()
        {
            double deducted = Salary * 0.1368;
            Salary -= deducted;
            return deducted;
        }

        public void GeneratePayslip(string root)
        {
            string path = root + " " + $"{Name}.txt";
            using StreamWriter sw = File.CreateText(path);
            {
                sw.WriteLine("------------------------------------------------------");
                sw.WriteLine($"PAYSLIP {DateTime.Now.ToString("MMMM yyyy")}");
                sw.WriteLine("------------------------------------------------------");
                sw.WriteLine($"Name                        :   {Name}");
                sw.WriteLine($"Social Securty              :   {SocialSecNr}");
                sw.WriteLine($"Bank account                :   {Bankaccount}");
                sw.WriteLine($"Sex                         :   {(Sex ? "Male" : "Female")}");
                sw.WriteLine($"Birthdate                   :   {Birthdate.ToShortDateString()}");
                sw.WriteLine($"Join date                   :   {JoinDate.ToShortDateString()}");
                sw.WriteLine($"Function                    :   {Title}");
                sw.WriteLine($"Fulltime                    :   {Hours}");
                sw.WriteLine($"Company car                 :   {(CompanyCar ? "Yes" : "No")}");
                sw.WriteLine("------------------------------------------------------");
                sw.WriteLine($"Starting salary             :   €{Print(StartingSalary)}");
                sw.WriteLine($"Seniority                   : + €{Print(AddSeniority())}");
                sw.WriteLine($"                            :   €{Print(Salary)}");
                sw.WriteLine($"Social security             : - €{Print(DeductSocialSecurity())}");
                sw.WriteLine($"                            :   €{Print(Salary)}");
                sw.WriteLine($"Withholding tax             : - €{Print(DeductWitholdingTax())}");
                sw.WriteLine($"                            :   €{Print(Salary)}");
                sw.WriteLine($"Net salary                  :   €{Print(Salary)}");
            }
        }

        //Code from Benjamin
        public string Print(double numb)
        {
            string print = numb.ToString("0.00");
            print = string.Format("{0,8}", print);

            return print;
        }
    }
}