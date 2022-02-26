using Microsoft.AspNetCore.Mvc;
using SlideYourRideServer.Models;
using SlideYourRideServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Controllers
{
    [Route("api/Stop/{stopId}/[controller]")]
    [ApiController]
    public class PathsController: ControllerBase
    {
        readonly IPathsService _pathsService;

        public PathsController(IPathsService pathsService)
        {
            _pathsService = pathsService;
        }

        /// <summary>
        /// Zwraca wszystkie policzone ścieżki wychodzące z wybranego punktu
        /// </summary>
        /// <param name="stopId"></param>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(Paths))]
        public IActionResult Get(int stopId)
        {
            var stops = _pathsService.Get(stopId);
            if (stops == null)
                return NoContent();
            return Ok(stops);
        }
    }
}
