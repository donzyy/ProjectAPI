using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class ProductBatch
    {
        [Key]
        public int ProductBatch_ID { get; set; }
        public int Product_ID { get; set; }
        public int ProductBatch_Number { get; set; }
        public double ProductBatch_Quantity { get; set; }
        public DateTime ProductionBatch_Date { get; set; }

        //Foreign
        [ForeignKey("Product_ID")]

        [InverseProperty("ProductBatches")]
        public Product Product { get; set; }

    }
}