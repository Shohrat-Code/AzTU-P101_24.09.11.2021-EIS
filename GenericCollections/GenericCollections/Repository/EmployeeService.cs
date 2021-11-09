using GenericCollections.Models;
using GenericCollections.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.Repository
{
    public class EmployeeService : IEmployeeService
    {
        private Employee[] Employees = new Employee[0];
        public Employee Create(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
            return employee;
        }

        public bool Delete(int id)
        {
            Employees = Array.FindAll(Employees, e => e.Id != id);
            return true;
        }

        public Employee Find(int id)
        {
            Employee foundEmployee = Array.Find(Employees, e => e.Id == id);
            return foundEmployee;
        }

        public int FindId()
        {
            if (Employees.Length==0)
            {
                return 1;
            }

            return Employees[Employees.Length - 1].Id + 1;
        }

        public Employee[] Read()
        {
            return this.Employees;
        }

        public Employee Update(int id, Employee employee)
        {
            Employee updatedEmployee = Array.Find(Employees, e => e.Id == id);
            updatedEmployee = employee;
            return employee;
        }
    }
}
