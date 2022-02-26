using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Models
{
    
    /// <summary>
    /// Klasa przechowująca dane dotyczące ścieżek, będące danymi wyjściowymi z algorytmu szukania ścieżki
    /// </summary>
    public class Paths
    {
        public int StartId { get; set; }
        /// <summary>
        /// Tablica z długością drogi z punktu początkowego
        /// </summary>
        public int[] Distance { get; set; }
        /// <summary>
        /// Tablica z poprzednikami
        /// </summary>
        public int [] Previous { get; set; }
        /// <summary>
        /// Tablica zawierająca klucze główne przystanków w bazie danych
        /// </summary>
        public int[] DbId { get; set; }
    }
}
