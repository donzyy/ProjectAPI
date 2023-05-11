using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrder_ID { get; set; }
        public string PurchaseOrder_Description { get; set; }
        public int Supplier_ID { get; set; }
        public decimal PurchaseOrder_Total { get; set; }
        public DateTime PurchaseOrder_Date { get; set; }
        public string PurchaseOrder_Status { get; set; }

        //Foreign Key
        [ForeignKey("Supplier_ID")]
        public Supplier Supplier { get; set; }

        
        //Link
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}