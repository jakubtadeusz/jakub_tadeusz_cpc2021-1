
using Microsoft.AspNetCore.Mvc;
using SlideYourRideServer.Models;
using SlideYourRideServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StopController : ControllerBase
    {
        private IStopService _stopService;
        public StopController(IStopService stopService)
        {
            _stopService = stopService;
        }

        /// <summary>
        /// Zwraca listę przystanków
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Stop>))]
        public IActionResult GetAllStops()
        {
            var stops = _stopService.Get();
            return Ok(stops);
        }

        /// <summary>
        /// Zwraca przystanek o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStop([FromRoute] int id)
        {
            var stop = _stopService.GetStop(id);
            if (stop == null)
                return NotFound("Przystanek o podanym Id nie istnieje");
            return Ok(stop);
        }

        /// <summary>
        /// Dodaje nowy przystanek
        /// </summary>
        /// <param name="stop"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Stop stop)
        {
            int id = _stopService.Post(stop);
            return Ok(id);
        }

        /// <summary>
        /// Edytuje przystanek
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stop"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Stop stop)
        {
            if (id != stop.Id)
            {
                return Conflict("Id edytowanego przystanku różni się");
            }
            else
            {
                var isUpdateSuccessful = _stopService.Put(id, stop);
                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa przystanek i podległe mu trasy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _stopService.Delete(id);
            if (isDeleteSuccessful)
                return NoContent();
            else
                return NotFound();
        }
    }
}
