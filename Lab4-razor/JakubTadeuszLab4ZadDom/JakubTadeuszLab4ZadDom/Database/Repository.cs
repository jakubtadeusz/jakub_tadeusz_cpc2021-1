using JakubTadeuszLab4ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab4ZadDom.Database
{
    public class Repository
    {
        //List of the bands
        public List<BandViewModel> Bands { get; set; }
        // List of the authors
        public List<AuthorViewModel> Authors { get; set; }
        // List of the albums
        public List<AlbumViewModel> Albums { get; set; }
        // List of the songs
        public List<SongViewModel> Songs { get; set; }

        public Repository()
        {
            Albums = new List<AlbumViewModel>()
            {
                GetAlbum("Rammstein", "Rammstein", new DateTime(2019, 5, 17), new decimal(88.99)),
                GetAlbum("Meteora", "Linkin Park", new DateTime(2003, 3, 24), new decimal(39.99)),
                GetAlbum("Hybrid Theory", "Linkin Park", new DateTime(2000, 10, 24), new decimal(40.99)),
                GetAlbum("Yeezus", "Kanye West", new DateTime(2013, 6, 18), new decimal(37.99))
            };

            Bands = new List<BandViewModel>()
            {
                new BandViewModel("Rammstein", 1994),
                new BandViewModel("Linkin Park", 1996),
                new BandViewModel("Kanye West", 2004)
            };

            Songs = new List<SongViewModel>()
            {
                Repository.GetSong("Linkin Park", "Foreword", "Meteora", 0.17 ),
                Repository.GetSong("Linkin Park", "Don't Stay", "Meteora", 3.078),
                Repository.GetSong("Linkin Park", "Somewhere I Belong", "Meteora", 3.33),
                Repository.GetSong("Linkin Park", "Lying from You", "Meteora", 2.55),
                Repository.GetSong("Linkin Park", "Numb", "Meteora", 3.05),

                Repository.GetSong("Linkin Park", "Papercut", "Hybrid Theory", 3.05),
                Repository.GetSong("Linkin Park", "One Step Closer", "Hybrid Theory", 2.35),
                Repository.GetSong("Linkin Park", "Crawling", "Hybrid Theory", 3.28),
                Repository.GetSong("Linkin Park", "In the End", "Hybrid Theory", 3.36),

                Repository.GetSong("Rammstein",  "Deutschland", "Rammstein", 5.23),
                Repository.GetSong("Rammstein",  "Radio", "Rammstein", 4.37),
                Repository.GetSong("Rammstein",  "Zeig dich", "Rammstein", 4.15),
                Repository.GetSong("Rammstein",  "Diamant", "Rammstein", 2.34),
                Repository.GetSong("Rammstein",  "Ausländer", "Rammstein", 3.51),


                Repository.GetSong("Kanye West",  "On Sight", "Yeezus", 2.36),
                Repository.GetSong("Kanye West",  "Black Skinhead", "Yeezus", 3.08),
                Repository.GetSong("Kanye West",  "I Am a God", "Yeezus", 3.51),
                Repository.GetSong("Kanye West",  "New Slaves", "Yeezus", 4.16),
                Repository.GetSong("Kanye West",  "Blood on the Leaves", "Yeezus", 6.00),
            };

        }

        internal dynamic GetAlbums(string bandName)
        {
            return (from album in Albums where album.Author == bandName select album).ToList();
        }

        internal object GetBand(string bandName)
        {
            return (from band in Bands where band.BandName == bandName select band).ToList().First();
        }

        internal object GetAlbum(string albumName)
        {
            return (from album in Albums where album.AlbumName == albumName select album).ToList().First();
        }

        internal object GetSongs(string albumName)
        {
            return (from song in Songs where song.AlbumName == albumName select song).ToList();
        }

        // Return latest n albums
        public List<AlbumViewModel> GetLatestAlbums(int amount)
        {
            return Albums.OrderByDescending(album => album.AlbumReleaseDate).Take(amount).ToList();
        }

        public static SongViewModel GetSong(string author, string songName, string albumName, double songLength)
        {
            return new SongViewModel { AlbumName = albumName, Author = author, SongLength = songLength, SongName = songName };
        }

        public AlbumViewModel GetAlbum(string albumName, string albumBandName, DateTime albumReleaseDate, Decimal price)
        {
            return new AlbumViewModel
            {
                AlbumName = albumName,
                Author = albumBandName,
                AlbumReleaseDate = albumReleaseDate,
                AlbumImage = "~/" + albumBandName.Replace(" ", "-").ToLower() + "_" + albumName.Replace(" ", "-").ToLower() + ".jpg",
                Price = price
            };
        }
    }
}
