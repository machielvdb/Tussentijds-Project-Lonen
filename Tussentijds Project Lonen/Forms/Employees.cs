using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tussentijds_Project_Lonen.Forms
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            lbEmployees.DataSource = Hoofdmenu.empoyeeList;

            lbEmployees.SelectedItem = 0;
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = lbEmployees.SelectedItem as Employee;
            lblName.Text = selectedEmployee.Name;
            lblJoindate.Text = "Joined: " + selectedEmployee.JoinDate.ToShortDateString();
            if (selectedEmployee.Sex)
            {
                lblSex.Text = "Male";
            }

            else lblSex.Text = "Female";
        }
    }
}
