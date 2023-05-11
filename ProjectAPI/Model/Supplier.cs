using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Supplier
    {
        [Key]
        public int Supplier_ID { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Phone_Number { get; set; }
        public string Supplier_Email { get; set; }
        public string Supplier_Status { get; set; }

        //Link
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}