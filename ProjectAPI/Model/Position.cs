using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Position
    {
        [Key]
        public int Position_ID { get; set; }
        public string Position_Name { get; set; }
        public string Position_Description { get; set; }

        // Linking Property to Employee
        public ICollection<Employee> Employees { get; set; }
    }
}