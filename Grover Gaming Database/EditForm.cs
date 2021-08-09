using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grover_Gaming_Database
{
    public partial class EditForm : Form
    {
        
        private homePage _form1;
        private Employee employeeToEdit;
        public EditForm(homePage form1, Employee employee)
        {
            
            InitializeComponent();           
            _form1 = form1;
            employeeToEdit = employee;
            editNameBox.Text = employee.name;
            editJobBox.Text = employee.jobTitle;
            EditJobWarning.Hide();
            EditNameWarning.Hide();
            

        }

        private void editOkayButton_Click(object sender, EventArgs e)
        {
            EditNameWarning.Hide();
            EditJobWarning.Hide();
            if (editNameBox.TextLength > 0 && editJobBox.TextLength > 0) 
            {
                 Employee editedEmployee = new Employee(editNameBox.Text, editJobBox.Text);
                editedEmployee.Id = employeeToEdit.Id;

                 _form1.EditEmployee( editedEmployee, employeeToEdit);
                this.Close();
            }
            if (editNameBox.TextLength == 0)
                EditNameWarning.Show();

            if (editJobBox.TextLength == 0)
                EditJobWarning.Show();
        }

        private void editCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
