using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections.Models
{
    public class Employee
    {
        //private string _address = "No address";
        //public string Address
        //{
        //    get
        //    {
        //        return this._address;
        //    }
        //    set
        //    {
        //        if (value.Length > 10)
        //        {
        //            this._address = value;
        //        }
        //    }
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public Department Department { get; set; }
    }
}
