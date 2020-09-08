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
            lblJoindate.Text = "Joined: " + selectedEmployee.JoinDate.ToShortDateString();
            if (selectedEmployee.Sex)
                lblSex.Text = "Male";
            else lblSex.Text = "Female";

            lbltest.Text = selectedEmployee.SocialSecNr;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewEmployee f = new NewEmployee();
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = lbEmployees.SelectedItem as Employee;
            NewEmployee f = new NewEmployee(selectedEmployee);
            f.Show();
        }
    }
}
