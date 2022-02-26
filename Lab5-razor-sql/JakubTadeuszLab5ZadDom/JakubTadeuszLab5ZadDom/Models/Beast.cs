using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab5ZadDom.Models
{
    public class Beast
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal MarketValue { get; set; }

        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public BeastType Type { get; set; }
    }
}
