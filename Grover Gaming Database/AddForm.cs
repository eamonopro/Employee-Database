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
            addNameWarning.Hide();
            addJobWarning.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void AddNameWarning_Click(object sender, EventArgs e)
        {

        }

        private void addJobWarning_Click(object sender, EventArgs e)
        {

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
