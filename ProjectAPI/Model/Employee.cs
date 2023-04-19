using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }
        public string Employee_First_Name { get; set; }
        public string Employee_Last_Name { get; set; }
        public string Employee_Address { get; set; }
        public int Employee_Phone_Number { get; set; }
        public string Employee_Email { get; set; }
        public int Department_ID { get; set; }
        public int Position_ID { get; set; }
        public Double Employee_Salary { get; set; }
        public DateTime Employee_Hire_Date { get; set; }
        public DateTime Employee_Termination_Date { get; set; }
        public DateTime Employee_Birth_Date { get; set; }
        public DateTime Employee_Status { get; set; }
    }
}