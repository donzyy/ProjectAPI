using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Truck
    {
        [Key]
      public int Truck_ID { get; set; }
      public int Truck_Plate_Number { get; set; }
      public string Truck_Capacity { get; set; }
      public string Truck_Status { get; set; }

      //Link
      public ICollection<Sales> Sales { get; set; }
      public ICollection<Driver> Drivers { get; set; }
    }
}
