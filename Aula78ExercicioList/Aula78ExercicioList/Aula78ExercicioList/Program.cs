using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace Aula78ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int empQuantity = int.Parse(Console.ReadLine());
            List<Employee> employee = new List<Employee>();
            for (int i = 0; i < empQuantity; i++)
            {
                Console.WriteLine("Enter the employee #" + (i + 1) + " Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee #" + (i + 1) + " Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the employee #" + (i + 1) + " Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int IdIncrease = int.Parse(Console.ReadLine());
            //int findId = employee.FindAll(x => x.Id == IdIncrease);


           bool employeeNotExists = false;

            //for (int i = 0; i < employee.Count; i++)
            //{
            //    if (employee[i].Id == IdIncrease)
            //    {
            //        Console.WriteLine("Enter the percentage: ");
            //        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        employee[i].IncreaseSalary(percentage);
            //        employeeNotExists = false;
            //        break;
            //    }
            //    else
            //    {
            //        employeeNotExists = true;
            //    }

            //}

            foreach (var item in employee)
            {
                if (item.Id == IdIncrease)
                {
                    Console.WriteLine("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    item.IncreaseSalary(percentage);
                    employeeNotExists = false;
                    break;
                }
                else
                {
                    employeeNotExists = true;
                }
            }

            if (employeeNotExists)
            Console.Write("This id does not exist!");

            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee list in employee)
            {
                Console.WriteLine(list);
            }
            

        }
    }
}
