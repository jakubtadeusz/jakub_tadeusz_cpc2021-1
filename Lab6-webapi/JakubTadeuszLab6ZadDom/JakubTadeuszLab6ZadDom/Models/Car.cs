using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab6ZadDom.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }     
        
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }     
        
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        public int? Horsepower { get; set; }

        public string ImageLink { get; set; }

        public ICollection<Announcement> announcements { get; set; }

    }
}
