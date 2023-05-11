using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class ProductType
    {
        [Key]
        public int  ProductType_ID { get; set; }
        public int ProductType_Name { get; set; }

        //Link
        public ICollection<Product> Products { get; set; }
    }
}