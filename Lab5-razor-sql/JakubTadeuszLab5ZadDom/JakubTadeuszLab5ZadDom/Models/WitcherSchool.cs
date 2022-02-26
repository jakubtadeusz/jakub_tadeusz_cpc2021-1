using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab5ZadDom.Models
{
    public class WitcherSchool
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Headquarters { get; set; }

        public ICollection<Witcher> Witchers { get; set; }
    }
}
