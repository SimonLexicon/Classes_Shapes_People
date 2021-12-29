using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Work
{   //   Employee = Child, Person = Parent
    class Employee : Person
    {
        private int salery;
        public int Salery { get { return salery; } set { salery = value; } }
        public string Department { get; set; }
        public List<string> tasks;

        public Employee(string name,
            string phone, string adress, 
            int salery, string department) : base(name, phone, adress)
        {
            this.Salery = salery;
            this.Department = department;
            this.tasks = new List<string>();
        }

        public void AddTask(string newTask)
        {
            tasks.Add(newTask);
        }

        public virtual List<string> TaskToDo()
        {
            return tasks;
        }

        public new string Info()
        {
            return base.Info() + $"\nSalery: {Salery}";
        }
    }
}
