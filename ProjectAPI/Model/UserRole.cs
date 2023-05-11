using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class UserRole
    {
        [Key]
        public int User_Role_ID { get; set; }

        /* //Foreign key to User Table
        public int User_ID { get; set; } */

        /* //Foreign key to Role Table
        public int Role_ID { get; set; } */


        //Foreign Key
        [ForeignKey("User_ID")]
        public User User { get; set; }

        [ForeignKey("Role_ID")]
        public Role Role { get; set; }
    }
}