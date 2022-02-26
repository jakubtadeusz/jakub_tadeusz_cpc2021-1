using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab4ZadDom.Models
{
    public class BandViewModel
    {
        public string BandName { get; set; }
        public int FormedYear { get; set; }
        public string BandImage { get; set; }

        public BandViewModel(string bandName, int formedYear)
        {
            BandName = bandName;
            FormedYear = formedYear;
            BandImage = "~/" + bandName.Replace(" ", "-").ToLower() + ".jpg";
        }
    }   
}
