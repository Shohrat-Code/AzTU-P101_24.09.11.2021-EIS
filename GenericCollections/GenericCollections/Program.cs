using GenericCollections.Models;
using GenericCollections.Repository;
using System;
using System.Text;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            //StringBuilder text = new StringBuilder();
            //text.Append("Rasim");
            //Console.WriteLine(text);

            //Employee employee = new Employee();
            //employee.Address = "Baku, Azerbaijan";
            //Console.WriteLine(employee.Address);

            //Employee employee2 = new Employee();
            //employee2.Address = "Ujar, Azerbaijan";
            //Console.WriteLine(employee2.Address);


            //Employee employee3 = new Employee();
            //employee3.Address = "Ganja, Azerbaijan";
            //Console.WriteLine(employee3.Address);

            #region Employee App
            byte choise = 255;
            DepartmentService departmentService = new DepartmentService();
            EmployeeService employeeService = new EmployeeService();

            Console.WriteLine("Welcome to Employee Information System!");
            Console.WriteLine();

            do
            {
                Console.WriteLine("You can choose following choises from following list:");
                Console.WriteLine();
                Console.WriteLine("1. Create employee");
                Console.WriteLine("2. Updeta employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("4. Find employee");
                Console.WriteLine("5. Read employees");
                Console.WriteLine("0. Exit");

                if (byte.TryParse(Console.ReadLine(), out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            Employee newEmployee = new Employee();

                            newEmployee.Id = employeeService.FindId();

                            Console.Write("Enter the name:");
                            newEmployee.Name = Console.ReadLine();

                            Console.Write("Enter the surname:");
                            newEmployee.Surname = Console.ReadLine();

                            Console.Write("Enter the age:");
                            newEmployee.Age = Convert.ToByte(Console.ReadLine());

                            Console.WriteLine("Select the department:");
                            foreach (var item in departmentService.Read())
                            {
                                Console.WriteLine($"{item.Id}. {item.Name}");
                            }

                            int depId = Convert.ToInt32(Console.ReadLine());
                            newEmployee.Department = departmentService.Find(depId);

                            employeeService.Create(newEmployee);
                            Console.WriteLine("New employee added successfully!");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Select Id of the employee for update:");

                            foreach (var item in employeeService.Read())
                            {
                                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Surname: {item.Surname}, Department: {item.Department.Name};");
                            }
                            int empId = Convert.ToInt32(Console.ReadLine());
                            Employee employee = employeeService.Find(empId);

                            Console.Write($"Ente new name({employee.Name}): ");
                            employee.Name = Console.ReadLine();

                            Console.Write($"Ente new surname({employee.Surname}): ");
                            employee.Surname = Console.ReadLine();

                            Console.Write($"Ente new age({employee.Age}): ");
                            employee.Age = Convert.ToByte(Console.ReadLine());

                            employeeService.Update(empId, employee);

                            Console.WriteLine("Employee updated successfully!");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Select Id of the employee for delete:");
                            Employee[] employees2 = employeeService.Read();
                            for (int i = 0; i < employees2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {employees2[i].Id}, Name: {employees2[i].Name}, Surname: {employees2[i].Surname}, Department: {employees2[i].Department.Name};");
                            }

                            int IdForDelete = Convert.ToInt32(Console.ReadLine());
                            employeeService.Delete(IdForDelete);
                            Console.WriteLine("Employee deleted successfully!");

                            Console.WriteLine();
                            break;
                        case 4:
                            Console.Write("Enter Id of the employee:");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            Employee employee1 = employeeService.Find(Id);
                            Console.WriteLine($"Id: {employee1.Id}, Name: {employee1.Name}, Surname: {employee1.Surname}, Age: {employee1.Age}, Department: {employee1.Department.Name};");

                            Console.WriteLine();
                            break;
                        case 5:
                            Employee[] employees = employeeService.Read();
                            for (int i = 0; i < employees.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {employees[i].Id}, Name: {employees[i].Name}, Surname: {employees[i].Surname}, Department: {employees[i].Department.Name};");
                            }
                            Console.WriteLine();
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("You can only select from list!");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You must enter the number from list!");
                    Console.WriteLine();
                    choise = 255;
                }

            } while (choise != 0);

            #endregion

        }
    }
}
