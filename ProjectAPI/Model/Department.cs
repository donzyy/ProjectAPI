using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Department_Description { get; set; }

        // Linking Property to Employee
        public ICollection<Employee> Employees { get; set; }
    }
}