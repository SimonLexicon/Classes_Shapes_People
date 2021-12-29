using System;
using System.Collections.Generic;
using Classes_Shapes_People.Models.Shapes;
using Classes_Shapes_People.Models.Work;

namespace Classes_Shapes_People
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WorkplaceExample();

        }

        public static void WorkplaceExample()
        {
            List<Employee> empList = new List<Employee>();

            Person newPerson = new Person("Olof", "+651234567890", "bogatan 11");
            Console.WriteLine(newPerson.Info());

            Employee newEmployee = new Employee("Olof", "+651234567890", "bogatan 11", 10000, "IT");
            Employee newEmployee2 = new Employee("Karl", "+44444444", "StorGatan 11", 10000, "IT");
            Employee newEmployee3 = new Employee("Johan", "+32123333", "LillGatan 21", 10000, "IT");
            newEmployee.AddTask("Clean Code base");
            newEmployee2.AddTask("Refactor CSS");
            newEmployee3.AddTask("Fetch Coffee");
            newEmployee3.AddTask("Migrate Database");

            empList.Add(newEmployee);
            empList.Add(newEmployee2);
            empList.Add(newEmployee3);

            Console.WriteLine(newEmployee.Info());

            Customer newCustomer = new Customer("Olof", "+651234567890", "bogatan 11", "HamnGatan 23");
            Console.WriteLine(newCustomer.Info());

            Administrator newAdministrator = new Administrator("Bert", "+123456789", "Hemgatan", 20000, "Manager", 100, empList);
            newAdministrator.AddTask("Administrate stuff");
            foreach (Employee emp in empList)
            {
                List<string> newList = emp.TaskToDo();
                foreach (string line in newList)
                {
                    Console.WriteLine(line);
                }

            }
            Console.WriteLine("\n");
            List<string> newListAdministrator = newAdministrator.TaskToDo();
            foreach (string line in newListAdministrator)
            {
                Console.WriteLine(line);
            }
            List<Person> listOfPersons = new List<Person>() {
                newPerson, newEmployee, newEmployee2, newEmployee3, newCustomer, newAdministrator};
            foreach (Person per in listOfPersons)
            {
                Console.WriteLine(per.Name);
                if (per is Administrator)
                {
                    Console.WriteLine((per as Administrator).Info());
                }
                else if (per is Customer)
                {
                    Console.WriteLine((per as Customer).Info());
                }
                else if (per is Employee)
                {
                    Console.WriteLine((per as Employee).Info());
                }
                else if (per is Person)
                {
                    Console.WriteLine((per as Person).Info());
                }
            }
        }

        public static void ShapeExample()
        {
            Circle myCirle = new Circle(10, Colors.Purple);
            Circle myCirleBlue = new Circle(100, Colors.Blue);

            Console.WriteLine(myCirle.Area);
            Console.WriteLine(myCirle.Color);

            Console.WriteLine(myCirleBlue.Area);
            Console.WriteLine(myCirleBlue.Color);

            Console.Clear();

            Square mySquare = new Square(4, Colors.Red);

            Console.WriteLine(mySquare.Information());
        }
    }
}
