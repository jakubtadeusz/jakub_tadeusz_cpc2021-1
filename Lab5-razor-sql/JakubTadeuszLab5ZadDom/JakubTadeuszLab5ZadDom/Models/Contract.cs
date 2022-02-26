using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab5ZadDom.Models
{
    public enum ContractStatus
    {
        New,
        InProgress,
        Completed,
        Failed
    }
    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateAdded { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContractorName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Region { get; set; }

        [Required]
        public string Description { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        public ContractStatus Status { get; set; } = ContractStatus.New;

        [Column(TypeName = "money")]
        public decimal? Prize { get; set; } = 0;

        public int? WitcherId { get; set; }

        [ForeignKey("WitcherId")]
        public Witcher Witcher { get; set; }
    }
}
