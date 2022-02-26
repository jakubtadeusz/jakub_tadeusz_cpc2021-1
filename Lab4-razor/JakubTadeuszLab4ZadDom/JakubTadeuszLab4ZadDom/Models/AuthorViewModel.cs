using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab4ZadDom.Models
{
    public class AuthorViewModel
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string AuthorImage { get; set; }
        public string MainRole { get; set; }

        public AuthorViewModel(string authorName, string authorSurname, string mainRole)
        {
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            AuthorImage = "~/" + authorName.Replace(" ", "-").ToLower() + ".jpg";
            MainRole = mainRole;
        }
    }
}
