using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Work
{
    class Administrator : Employee
    {
        List<Employee> employeeList;
        public int Bonus { get; set; }
        public Administrator(
            string name, string phone,
            string adress, int salery,
            string department, int bonus,
            List<Employee> emplist) :base(name, phone, adress, salery, department)
        {
            this.employeeList = emplist;
            this.Bonus = bonus;
        }

        public new string Info()
        {
            return base.Info() + $"\nBonus: {Bonus}";
        }

        public override List<string> TaskToDo()
        {
            List<string> allTasks = tasks;
            foreach(Employee emp in employeeList)
            {
                allTasks.Add(emp.Name + ":");
                allTasks.AddRange(emp.tasks);
            }

            return allTasks;
        }
    }
}
