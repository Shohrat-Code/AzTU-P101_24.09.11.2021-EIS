using GenericCollections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.Repository.IRepository
{
    public interface IEmployeeService
    {
        Employee Create(Employee employee);
        Employee Update(int id, Employee employee);
        bool Delete(int id);
        Employee[] Read();
        Employee Find(int id);
        int FindId();
    }
}
