using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class SalesMan
    {
        [Key]
        public int SalesMan_ID { get; set; }
        public string SalesMan_FirstName { get; set; }
        public string SalesMan_LastName { get; set; }
        public string SalesMan_Email { get; set; }
        public int SalesMan_Phone_Number { get; set; }
        public string SalesMan_Address { get; set; }
        public int SalesMan_GhanaPostAddress { get; set; }

        //Link
        public ICollection<Sales> Sales { get; set; }
    }
}