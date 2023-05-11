using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class SalesDetails
    {
        [Key]
        public int SalesDetails_ID { get; set; }
        public int Sales_ID { get; set; }
        public int Product_ID { get; set; }
        public int SalesDetails_Quantity { get; set; }
        public int SalesDetails_Price { get; set; }
        public int SalesDetails_Tax { get; set; }
        public int SalesDetails_Total { get; set; }       


        //Foreign keys
        [ForeignKey("Sales_ID")]
        public Sales Sales { get; set; }

        [ForeignKey("Product_ID")]
        public Product Product { get; set; }
    }
}