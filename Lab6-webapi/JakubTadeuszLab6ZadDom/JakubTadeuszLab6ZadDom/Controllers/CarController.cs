using JakubTadeuszLab6ZadDom.Models;
using JakubTadeuszLab6ZadDom.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab6ZadDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        /// <summary>
        /// Return all the cars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Car>))]
        public IActionResult GetAllCars()
        {
            var cars = _carService.Get();
            return Ok(cars);
        }

        /// <summary>
        /// Return car with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [Produces(typeof(Car))]
        public IActionResult GetCar([FromRoute] int id)
        {
            var car = _carService.GetCar(id);
            if (car == null)
                return NotFound("Samochód o podanym Id nie istnieje");
            return Ok(car);
        }

        /// <summary>
        /// Adds new car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody]Car car)
        {
            int id = _carService.Post(car);
            return Ok(id);
        }

        /// <summary>
        /// Edit car with given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Car car)
        {
            if(id != car.Id)
            {
                return Conflict("Id edytowanego samochodu różni się");
            }
            else
            {
                var isUpdateSuccessful = _carService.Put(id, car);
                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Delete car with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _carService.Delete(id);
            if (isDeleteSuccessful)
                return NoContent();
            else
                return NotFound();
        }
    }
}
