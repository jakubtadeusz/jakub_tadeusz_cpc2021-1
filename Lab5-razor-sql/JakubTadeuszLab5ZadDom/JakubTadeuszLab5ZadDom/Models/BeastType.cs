using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JakubTadeuszLab5ZadDom.Models
{
    public class BeastType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Beast> Beasts { get; set; }
    }
}