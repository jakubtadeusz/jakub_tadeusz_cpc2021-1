using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakubTadeuszLab6ZadDom.Models
{
    public enum AnnouncementType
    {
        SALE,
        RENT
    }
    public class Announcement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Required]
        public AnnouncementType Type { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }
    }
}