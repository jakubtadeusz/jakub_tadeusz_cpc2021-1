using SlideYourRideServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Services
{
    public interface IStopService
    {
        /// <summary>
        /// Zwraca wszystkie przystanki
        /// </summary>
        /// <returns></returns>
        List<Stop> Get();

        /// <summary>
        /// Zwraca wybrany przystanek
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Stop GetStop(int id);

        /// <summary>
        /// Dodaje nowy przystanek i zwraca jego id
        /// </summary>
        /// <param name="stop"></param>
        /// <returns></returns>
        int Post(Stop stop);

        /// <summary>
        /// Edytuje przystanek o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stop"></param>
        /// <returns></returns>
        bool Put(int id, Stop stop);

        /// <summary>
        /// Usuwa wskazany przystanek
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
