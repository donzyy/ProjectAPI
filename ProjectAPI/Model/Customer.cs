using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string Customer_First_Name { get; set; }
        public string Customer_Last_Name { get; set; }
        public string Customer_Email { get; set; }
        public int Customer_Phone_Number { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_City { get; set; }
        public string Customer_Region { get; set; }
        public string Customer_Country { get; set; }
        public int Customer_Postal_Code { get; set; }

        // Linking Property to Sales
        public ICollection<Sales>  Sales { get; set; }
    }
}