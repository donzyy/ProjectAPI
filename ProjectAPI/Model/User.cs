using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        [StringLength(50)]
        public string User_First_Name { get; set; }

        [StringLength(50)]
        public string User_Last_Name { get; set; }

        [StringLength(70)]
        public string User_Email { get; set; }

         [StringLength(15)]
        public string User_Phone_Number { get; set; }

         [StringLength(50)]
        public string User_Address { get; set; }

         [StringLength(50)]
        public string User_City { get; set; }

         [StringLength(50)]
        public string User_State { get; set; }

         [StringLength(50)]
        public string User_Country { get; set; }

         [StringLength(50)]
        public string User_Digital_Address { get; set; }

         [StringLength(80)]
        public string User_Password { get; set; }

         [StringLength(80)]
        public string User_Password_Salt { get; set; }

        public DateTime User_Date_Of_Birth { get; set; }

        public char User_Gender { get; set; }

         [StringLength(50)]
        public string User_Profile_Image { get; set; }

         [StringLength(50)]
        public string User_UserName { get; set; }

        public bool User_Inactive { get; set; }

        //Link

        public ICollection<UserRole> UserRoles { get; set; }

    }
}