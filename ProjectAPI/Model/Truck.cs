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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, JsonIgnore]
        public Guid Id { get; set; }
        public string registrationNumber { get; set; }
        public string truckDriver { get; set; }
        public string truckSalesMan { get; set; }
        public int sachetBagsTaken { get; set; }
        public int dispenserBottlesTaken { get; set; }
        public int sachetBagsSold { get; set; }
        public int dispenserBottlesSold { get; set; }
        public int sachetRemaining { get; set; }
        public int dispenserBottlesRemaining { get; set; }
        public int sachetBagPrice { get; set; }
        public int dispenserBottlePrice { get; set; }
        public int dailySales { get; set; }
    }
}
