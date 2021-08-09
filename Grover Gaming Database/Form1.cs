using LiteDB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grover_Gaming_Database
{
    public partial class homePage : Form
    {

        LiteDatabase db = new LiteDatabase("EmployeeData.db");

        /*
         * integer determine how the datagrid will be sorted
         * 1 and 2 are alphabetically by name, 3 and 4 are alphabetically by job title
         */
        int currentSort = 1;
        public homePage()
        {
            InitializeComponent();
            ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");
            UpdateList();



        }

        //opens the AddForm when the addbutton is clicked
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddForm addform = new AddForm(this))
            {
                addform.ShowDialog();
            }

        }

        /// <summary>
        /// fetches the database, orders it according to the currently selected sort method, and displays it in the datagrid
        /// </summary>
        public void UpdateList()
        {
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
        /// <summary>
        /// Adds a new employee into the liteDB and updates the datagrid, requires user confirmation before adding an employee with the same name as an existing one
        /// </summary>
        /// <param name="newEmployee">the new employee to be added</param>
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
        /// <summary>
        /// removes an employee from the data base, and updates the datagrid
        /// </summary>
        /// <param name="employee">Employee to be removed</param>
        public void RemoveEmployee(Employee employee)
        {
            ILiteCollection<Employee> col = db.GetCollection<Employee>("employees");
            col.Delete(employee.Id);
            UpdateList();
        }
        /// <summary>
        /// requires user confirmation that the selected employee is to be deleted upon button click
        /// </summary>
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                var index = dataGridView1.SelectedRows[0];


                Employee employeeToDelete = (Employee)index.DataBoundItem;
                //Employee employeeToDelete = employees[employeeList.SelectedIndices[0]];

                Console.WriteLine("hello");
                DialogResult result = MessageBox.Show("Are you sure you want to delete the entry for " + employeeToDelete.toString(), "Delete Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    RemoveEmployee(employeeToDelete);
                    MessageBox.Show("Entry \"" + employeeToDelete.toString() + "\" successfully deleted", "Delete Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        /// <summary>
        /// confirms that an employee is selected in the datagrid, before launching an edit form
        /// </summary>
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
        /// <summary>
        /// updates an existing employee in the data base, and updates the datagrid. 
        /// displays the edits made to the user
        /// </summary>
        /// <param name="newEmployee">the updated version of the edited employee</param>
        /// <param name="oldEmployee">the original version of the edited employee</param>
        public void EditEmployee(Employee newEmployee, Employee oldEmployee)
        {


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


        /// <summary>
        /// Changes the selected sorting method and updates the datagrid
        /// </summary>
        
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (currentSort == 1)
                    currentSort++;
                else
                    currentSort = 1;
            }
            else if (e.ColumnIndex == 1)
            {
                if (currentSort == 3)
                    currentSort++;
                else
                    currentSort = 3;
            }
            // this should not occur
            else
                MessageBox.Show("An error has occured, please restart the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateList();

        }
    }
}
