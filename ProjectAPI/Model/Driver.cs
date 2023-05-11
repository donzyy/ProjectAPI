using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Driver
    {
        [Key]
        public int Driver_ID { get; set; }
        public string Driver_FirstName { get; set; }
        public string Driver_LastName { get; set; }
        public string  Driver_Phone_Number { get; set; }
        public int Driver_License_Number { get; set; }
        public string Driver_Status { get; set; }
        public int Truck_ID { get; set; }

        //Foreign
        [ForeignKey("Truck_ID")]
        public Truck Truck { get; set; }

        //Link
        public ICollection<Sales> Sales { get; set; }
    }
}
