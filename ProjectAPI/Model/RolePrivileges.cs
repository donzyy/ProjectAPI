using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class RolePrivileges
    {
        [Key]
        public int Role_Privileges_ID { get; set; }

       /*  //Foreign key to Privileges Table
        public int Privileges_ID { get; set; }

        //Foreign key to Role Table
        public int Role_ID { get; set; } */


        //Foreign Keys
        [ForeignKey("Privileges_ID")]
        public Privilege Privilege { get; set; }

        [ForeignKey("Role_ID")]
        public Role Role { get; set; }
    }
}