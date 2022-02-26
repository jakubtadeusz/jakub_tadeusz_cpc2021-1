using SlideYourRideServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Services
{
    public interface IPathsService
    {
        /// <summary>
        /// Zwraca wszystkie drogi z przystanku o wybranym id
        /// </summary>
        /// <returns></returns>
        Paths Get(int stopId);
    }
}
