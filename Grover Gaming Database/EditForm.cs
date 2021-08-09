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

            //populates the text boxes with the name and job title of the employee that is being edited
            employeeToEdit = employee;
            editNameBox.Text = employee.name;
            editJobBox.Text = employee.jobTitle;
            EditJobWarning.Hide();
            EditNameWarning.Hide();
            

        }
        /*
         * if both text boxes are filled, triggers the EditEmployee function
         * if either are empty, displays the relevant error label
         */
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
        //closes the edit form
        private void editCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
