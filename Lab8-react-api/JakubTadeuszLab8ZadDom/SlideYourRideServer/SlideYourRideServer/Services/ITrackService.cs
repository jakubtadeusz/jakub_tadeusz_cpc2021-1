using SlideYourRideServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Services
{
    public interface ITrackService
    {
        /// <summary>
        /// Zwraca wszystkie ścieżki
        /// </summary>
        /// <returns></returns>
        List<Track> Get(int stopId);

        /// <summary>
        /// Dodaje nową ścieżkę i zwraca jej id
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        int Post(Track track);

        /// <summary>
        /// Edytuje ścieżkę o wybranym id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="track"></param>
        /// <returns></returns>
        bool Put(int id, Track track);

        /// <summary>
        /// Usuwa wskazaną ścieżkę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
