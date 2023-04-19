using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int MyProperty { get; set; }
    }
}