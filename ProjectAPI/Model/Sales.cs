using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Sales
    {
        [Key]
        public int Sales_ID { get; set; }
        public int Customer_ID { get; set; }
        public DateTime Sales_Date { get; set; }
        public decimal Sales_Amount { get; set; }
        public int Payment_Type_ID { get; set; }
        public int SalesMan_ID { get; set; }
        public int Truck_ID { get; set; }
        public int Driver_ID { get; set; }

        //Foreign Keys
        [ForeignKey("Customer_ID")]
        public Customer Customer { get; set; }

        [ForeignKey("Payment_Type_ID")]
        public PaymentType PaymentType { get; set; }
        
        [ForeignKey("SalesMan_ID")]
        public SalesMan SalesMan { get; set; }

        [ForeignKey("Driver_ID")]
        public Driver Driver { get; set; }

        [ForeignKey("Truck_ID")]
        public Truck Truck { get; set; }

        // Linking Property
        public ICollection<SalesDetails> SalesDetails { get; set; }

    }
}