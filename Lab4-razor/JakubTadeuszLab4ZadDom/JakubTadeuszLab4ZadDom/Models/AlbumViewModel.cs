using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab4ZadDom.Models
{
    public class AlbumViewModel
    {
        public string AlbumName { get; set; }
        public string Author { get; set; }
        public DateTime AlbumReleaseDate { get; set; }
        public string AlbumImage { get; set; } 
        public Decimal Price { get; set; }

    }
}
