using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Privilege
    {
        [Key]
        public int Privileges_ID { get; set; }

        [StringLength(50)]
        public string Privileges_Name { get; set; }
        [StringLength(100)]
        public string Privileges_Description { get; set; }


        //Link
        // public ICollection<Role> Roles  { get; set; }
    }
}