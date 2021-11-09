using GenericCollections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.Repository.IRepository
{
    public interface IDepartmentService
    {
        Department Create(Department employee);
        Department Update(int id, Department employee);
        bool Delete(int id);
        Department[] Read();
        Department Find(int id);
    }
}
