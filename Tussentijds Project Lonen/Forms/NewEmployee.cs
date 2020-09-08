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
    public partial class NewEmployee : Form
    {
        Employee selEmployee;
        public NewEmployee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public NewEmployee(Employee selectedEmployee)
        {
            // For "edit" employee, receive employee to fill boxes with.
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            selEmployee = selectedEmployee;
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            cbCompanycar.Enabled = false;
            cbFunction.Items.Add("Standard employee");
            cbFunction.Items.Add("Programmer");
            cbFunction.Items.Add("IT Support");
            cbFunction.Items.Add("CS Support");
            cbFunction.SelectedIndex = 0;

            if (selEmployee != null)
            {
                tbName.Text = selEmployee.Name;
                cbFunction.Text = selEmployee.Title;
                dtpBirthdate.Value = selEmployee.Birthdate;

                if (selEmployee.Sex)
                    rbMale.Checked = true;
                else rbFemale.Checked = true;

                if (selEmployee.CompanyCar)
                    cbCompanycar.Checked = true;
                else cbCompanycar.Checked = false;

                tbSalary.Text = selEmployee.Print(selEmployee.StartingSalary);
            }
        }

        private void cbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When selected employee is programmer, check for company car.
            if (cbFunction.SelectedIndex == 1)
                cbCompanycar.Enabled = true;
            else
            {
                cbCompanycar.Enabled = false;
                cbCompanycar.Checked = false;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
