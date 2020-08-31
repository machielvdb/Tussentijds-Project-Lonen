using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            DateTime birthdate = new DateTime(1995, 12, 02);
            DateTime joindate = new DateTime(2020, 09, 01);
            Programmer newProgrammer = new Programmer("Machiel Vandenbussche", true, birthdate, joindate, true, 3, true);
            empoyeeList.Add(newProgrammer);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees f = new Employees();
            f.Show();
        }
    }
}
