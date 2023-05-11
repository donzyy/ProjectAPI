using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class PaymentType
    {
        [Key]
        public int PaymentType_ID { get; set; }
        public string PaymentType_Description { get; set; }
        
        // Linking Property to Sakes
        public ICollection<Sales> Sales { get; set; }
    }
}