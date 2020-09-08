using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tussentijds_Project_Lonen.Classes;
using Tussentijds_Project_Lonen.Forms;

namespace Tussentijds_Project_Lonen
{
    public partial class Hoofdmenu : Form
    {
        public static List<Employee> empoyeeList = new List<Employee>();
        public Hoofdmenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Hoofdmenu_Load(object sender, EventArgs e)
        {
            // Generate first employee and add it to list "Database" initiated above.
            DateTime birthdate = new DateTime(1995, 12, 02);
            DateTime joindate = new DateTime(2020, 09, 01);
            Programmer newProgrammer = new Programmer("Machiel Vandenbussche", true, birthdate, joindate, 38, 2, true, 2200);
            empoyeeList.Add(newProgrammer);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees f = new Employees();
            f.Show();
        }

        private void btnEndMonth_Click(object sender, EventArgs e)
        {
            string root = $@"C:\Users\Machiel\source\repos\Tussentijds Project Lonen\Tussentijds Project Lonen\bin\Debug\PAYSLIPS{DateTime.Today.ToString(" MM yyyy")}\";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);

                foreach (var item in Hoofdmenu.empoyeeList)
                {
                    item.GeneratePayslip(root);
                }
            }
            else MessageBox.Show("Directory already exists.");
        }
    }
}
