using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grover_Gaming_Database
{
    public partial class homePage : Form
    {
         
        LiteDatabase db = new LiteDatabase("EmployeeData.db");
        BindingSource bindingSource1 = new BindingSource();
        int currentSort = 1;
        public homePage()
        {
            InitializeComponent();






            ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");
            
            
            UpdateList();



        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddForm addform = new AddForm(this))
            {
                addform.ShowDialog();
            }

        }


        public void UpdateList()
        {
            List<Employee> employees = new List<Employee>();
            ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");

            switch (currentSort)
            {
                case 1:
                    dataGridView1.DataSource = (List<Employee>)col.Query().OrderBy(x => x.name).ToList();
                    dataGridView1.Columns[0].HeaderText = "Name ↓";
                    dataGridView1.Columns[1].HeaderText = "Job Title";
                    break;
                case 2:
                    dataGridView1.DataSource = (List<Employee>)col.Query().OrderByDescending(x => x.name).ToList();
                    dataGridView1.Columns[0].HeaderText = "Name ↑";
                    dataGridView1.Columns[1].HeaderText = "Job Title";
                    break;
                case 3:
                    dataGridView1.DataSource = (List<Employee>)col.Query().OrderBy(x => x.jobTitle).ToList();
                    dataGridView1.Columns[0].HeaderText = "Name";
                    dataGridView1.Columns[1].HeaderText = "Job Title ↓";
                    break;
                case 4:
                    dataGridView1.DataSource = (List<Employee>)col.Query().OrderByDescending(x => x.jobTitle).ToList();
                    dataGridView1.Columns[0].HeaderText = "Name";
                    dataGridView1.Columns[1].HeaderText = "Job Title ↑";
                    break;
                default:
                    MessageBox.Show("An error has occured, please restart the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                    



            }
        }

        public void AddEmployee(Employee newEmployee)
        {
            ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");

            DialogResult result = DialogResult.Yes;



            
            if (col.FindOne(x => x.name == newEmployee.name) != null)
            {
                result = MessageBox.Show("An employee by the name " + newEmployee.name + " already exists, would you like to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            
            if (result == DialogResult.Yes)
            {
                col.Insert(newEmployee);
                MessageBox.Show("New employee \"" + newEmployee.toString() + "\" sucessfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateList();
            }
            
        }

        public void RemoveEmployee(Employee employee)
        {
            ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");
            col.Delete(employee.Id);
            UpdateList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            { 
            var index = dataGridView1.SelectedRows[0];


            Employee employeeToDelete = (Employee)index.DataBoundItem;
            //Employee employeeToDelete = employees[employeeList.SelectedIndices[0]];

            Console.WriteLine("hello");
                DialogResult result = MessageBox.Show("Are you sure you want to delete the entry for " + employeeToDelete.toString(), "Delete Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) ;
                if (result == DialogResult.OK)
                {
                    RemoveEmployee(employeeToDelete);
                    MessageBox.Show("Entry \"" + employeeToDelete.toString() + "\" successfully deleted", "Delete Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
        }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (true)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    Employee employeeToEdit = (Employee)selectedRow.DataBoundItem;
                    using (EditForm editform = new EditForm(this, employeeToEdit))
                    {
                        editform.ShowDialog();
                    }
                }
            }
        }

        public void EditEmployee(Employee newEmployee, Employee oldEmployee) {


            String editsMade = "";
            if (!oldEmployee.name.Equals(newEmployee.name))
                editsMade += "\nName: " + oldEmployee.name + " -> " + newEmployee.name;
            if (!oldEmployee.jobTitle.Equals(newEmployee.jobTitle))
                editsMade += "\nJob Title: " + oldEmployee.jobTitle + " -> " + newEmployee.jobTitle;


            if (!(editsMade == ""))
            {
                ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");
                col.Update(newEmployee);
                MessageBox.Show("The following edits have been made successfully:" + editsMade, "Edit Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateList();
            }
        }

 

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 )
            {
                if (currentSort == 1)
                    currentSort++;
                else
                    currentSort = 1;
            }
            else if  (e.ColumnIndex == 1)
            {
                if (currentSort == 3)
                    currentSort++;
                else
                    currentSort = 3;
            }
            else
                MessageBox.Show("An error has occured, please restart the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateList();

        }
    }
}
