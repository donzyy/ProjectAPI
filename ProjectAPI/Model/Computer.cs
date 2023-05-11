using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAPI.Model
{
    public class Computer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, JsonIgnore]
        public Guid Id { get; set; }
        [Required]
        public int ComputerNumber { get; set; }
        [Required]
        public string ComputerLocation { get; set; }
    }
}
