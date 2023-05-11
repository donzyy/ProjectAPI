using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Product
{
    [Key]
    public int Product_ID { get; set; }
    public string Product_Name { get; set; }
    public string Product_Description { get; set; }
    public decimal Product_Price { get; set; }
    public int Product_Quantity { get; set; }
    public int Product_Batch_ID { get; set; }
    public int Product_Type_ID { get; set; }

    //Foreign Key
    [ForeignKey("Product_Batch_ID")]
    public ProductBatch ProductBatch { get; set; }

    [ForeignKey("Product_Type_ID")]
    public ProductType ProductType { get; set; }

    //Link
    public ICollection<SalesDetails> SalesDetails { get; set; }
    public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    //Navigation property
    
    [InverseProperty("Product")]
    public ICollection<ProductBatch> ProductBatches { get; set; }
}

}