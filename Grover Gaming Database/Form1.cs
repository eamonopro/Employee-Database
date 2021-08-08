using LiteDB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grover_Gaming_Database
{
    public partial class homePage : Form
    {
        List<Employee> employees = new List<Employee>();

        public homePage()
        {
            InitializeComponent();


            

            using (var db = new LiteDatabase(@"C:\users\eamon\games\EmployeeData.db"))
            {
                var col = db.GetCollection<Employee>("employees");

                employees = col.Query().ToList();
            }
            UpdateList();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddForm addform = new AddForm(this))
            {
                if (addform.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    employeeList.Items.Clear();
                }
            }

        }


        public void UpdateList()
        {
            employeeList.Items.Clear();
            using (var db = new LiteDatabase(@"C:\users\eamon\games\EmployeeData.db"))
            {

                var col = db.GetCollection<Employee>("employees");
                col.DeleteAll();

                foreach (Employee employee in employees)
                {
                    string[] employeeArray = employee.ToArray();
                    var listViewItem = new ListViewItem(employeeArray);
                    employeeList.Items.Add(listViewItem);
                    col.Insert(employee);
                }

                List<Employee> emp2 = col.Query().ToList();
                Console.WriteLine("hello world");
            }

        }

        public void AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
            UpdateList();
        }

        public void RemoveEmployee(int index)
        {
            employees.RemoveAt(index);
            UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selected = -1;
            if (employeeList.SelectedItems.Count > 0)
            {
                selected = employeeList.Items.IndexOf(employeeList.SelectedItems[0]);
                Employee employeeToDelete = employees[selected];
                DialogResult result = MessageBox.Show("Are you sure you want to delete the entry for " + employeeToDelete.name + ", " + employeeToDelete.jobTitle, "Delete Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                { RemoveEmployee(selected); }
                
            }
        }

        private void mainEditButton_Click(object sender, EventArgs e)
        {
            int selected = -1;
            if (employeeList.SelectedItems.Count > 0)
            {
                selected = employeeList.Items.IndexOf(employeeList.SelectedItems[0]);
                Employee employeeToEdit = employees[selected];
                using (EditForm editform = new EditForm(this, employeeToEdit, selected))
                {
                    editform.ShowDialog();
                }
            }
            
        }

        public void EditEmployee(int index, Employee employee) {
            employees[index] = employee;
            UpdateList();
        }

        private void employeeList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }
    }
}
