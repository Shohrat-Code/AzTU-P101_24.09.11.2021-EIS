using GenericCollections.Models;
using GenericCollections.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.Repository
{
    public class DepartmentService : IDepartmentService
    {
        private Department[] Departments = new Department[3];
        Department department1 = new Department()
        {
            Id = 1,
            Name = "IT",
            EmployeeCount = 24
        };
        Department department2 = new Department()
        {
            Id = 2,
            Name = "Finance",
            EmployeeCount = 15
        };
        Department department3 = new Department()
        {
            Id = 3,
            Name = "Law",
            EmployeeCount = 7
        };

        public DepartmentService()
        {
            Departments[0] = department1;
            Departments[1] = department2;
            Departments[2] = department3;
        }

        public Department Create(Department employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Find(int id)
        {
            return Array.Find(Departments, d => d.Id == id);
        }

        public Department[] Read()
        {
            return this.Departments;
        }

        public Department Update(int id, Department employee)
        {
            throw new NotImplementedException();
        }
    }
}
