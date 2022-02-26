using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, Int64.MaxValue)]
        public int Length { get; set; }

        public int Elevation { get; set; } = 0;
        public string TrackDescription { get; set; }

        [Required]
        public int StartStopId { get; set; }
        [Required]
        public int EndStopId { get; set; }

    }
}
