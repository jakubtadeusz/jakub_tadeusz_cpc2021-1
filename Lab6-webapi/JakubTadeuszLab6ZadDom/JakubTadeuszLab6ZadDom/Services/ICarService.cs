using JakubTadeuszLab6ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab6ZadDom.Services
{
    public interface ICarService
    {
        /// <summary>
        /// Return all cars
        /// </summary>
        /// <returns></returns>
        List<Car> Get();

        /// <summary>
        /// Add new car and return its id
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        int Post(Car car);

        /// <summary>
        /// Edit car with given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        bool Put(int id, Car car);

        /// <summary>
        /// Delete car with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        Car GetCar(int id);
    }
}
