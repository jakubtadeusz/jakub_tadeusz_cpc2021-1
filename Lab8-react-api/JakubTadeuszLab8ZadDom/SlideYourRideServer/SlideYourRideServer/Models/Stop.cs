using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Models
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string StopName { get; set; }

        public string StopDescription { get; set; }

    }
}
