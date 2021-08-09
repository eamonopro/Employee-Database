using System;
using System.Windows.Forms;

namespace Grover_Gaming_Database
{
    public partial class AddForm : Form
    {
        private homePage _form1;
        public AddForm(homePage form1)
        {
            _form1 = form1;
            InitializeComponent();   
            //the 2 warning labels, must be hidden on start
            addNameWarning.Hide();
            addJobWarning.Hide();
        }
        /*
         * if both text boxes are filled, triggers the AddEmployee function
         * if either text box is empty, displays the relevant error label
         */
        private void button1_Click(object sender, EventArgs e)
        {
            addNameWarning.Hide();
            addJobWarning.Hide();
           


            if (addNameBox.TextLength > 0 && addJobBox.TextLength > 0)
            {
                _form1.AddEmployee(new Employee(addNameBox.Text, addJobBox.Text));
                this.Close();
            }
            if (addNameBox.TextLength == 0)
                addNameWarning.Show();

            if (addJobBox.TextLength == 0)
                addJobWarning.Show();
        }
        //closes the addform
        private void addCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
