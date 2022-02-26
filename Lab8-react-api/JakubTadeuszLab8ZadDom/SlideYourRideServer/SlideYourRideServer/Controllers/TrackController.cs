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
    public class TrackController : ControllerBase
    {
        private ITrackService _trackService;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        /// <summary>
        /// Zwraca listę tras wychodzących z wybranego przystanku
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Track>))]
        public IActionResult GetAllTracks(int stopId)
        {
            var tracks = _trackService.Get(stopId);
            return Ok(tracks);
        }

        /// <summary>
        /// Dodaje nową trasę
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Track track, int stopId)
        {
            track.StartStopId = stopId;
            int id = _trackService.Post(track);
            return Ok(id);
        }

        /// <summary>
        /// Edytuje istniejącą trasę
        /// </summary>
        /// <param name="id"></param>
        /// <param name="track"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Track track)
        {
            if (id != track.Id)
            {
                return Conflict("Id edytowanego samochodu różni się");
            }
            else
            {
                var isUpdateSuccessful = _trackService.Put(id, track);
                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa istniejącą trasę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _trackService.Delete(id);
            if (isDeleteSuccessful)
                return NoContent();
            else
                return NotFound();
        }

    }
}
