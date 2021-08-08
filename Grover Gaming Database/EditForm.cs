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
        private int index;
        public EditForm(homePage form1, Employee employee, int empIndex)
        {
            
            InitializeComponent();
            index = empIndex;
            _form1 = form1;
            editNameBox.Text = employee.name;
            editJobBox.Text = employee.name;
            EditJobWarning.Hide();
            EditNameWarning.Hide();
            

        }

        private void editOkayButton_Click(object sender, EventArgs e)
        {
            EditNameWarning.Hide();
            EditJobWarning.Hide();
            if (editNameBox.TextLength > 0 && editJobBox.TextLength > 0) 
            {
                _form1.EditEmployee(index, new Employee(editNameBox.Text, editJobBox.Text));
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
