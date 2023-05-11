using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }
        
        [StringLength(50)]
        public string Role_Name { get; set; }


        //Link

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<RolePrivileges>RolePrivileges  { get; set; }
    }
}