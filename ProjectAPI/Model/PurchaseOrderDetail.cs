using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class PurchaseOrderDetail
    {
        [Key]
        public int PurchaseOrderDetail_ID { get; set; }
        public int PurchaseOrder_ID { get; set; }
        public int Product_ID { get; set; }
        public float PurchaseOrderDetail_Quantity { get; set; }
        public decimal PurchaseOrderDetail_Unit_Price { get; set; }
        public decimal PurchaseOrderDetail_Subtotal { get; set; }
        public int PurchaseOrderDetail_Qty_Received { get; set; }

        //Foreign Key
        [ForeignKey("PurchaseOrder_ID")]
        public PurchaseOrder PurchaseOrder { get; set; }

        [ForeignKey("Product_ID")]
        public Product Product { get; set; }
    }
}