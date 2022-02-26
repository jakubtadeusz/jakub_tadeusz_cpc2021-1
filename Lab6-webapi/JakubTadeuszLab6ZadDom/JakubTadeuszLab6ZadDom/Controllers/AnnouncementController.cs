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
    public class AnnouncementController : ControllerBase
    {
        private IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        /// <summary>
        /// Return all the announcements
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Announcement>))]
        public IActionResult GetAllAnnouncements()
        {
            var announcements = _announcementService.Get();
            return Ok(announcements);
        }

        /// <summary>
        /// Return announcement with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [Produces(typeof(Announcement))]
        public IActionResult GetAnnouncement([FromRoute] int id)
        {
            var announcement = _announcementService.GetAnnouncement(id);
            if (announcement == null)
                return NotFound("Ogłoszenie o podanym Id nie istnieje");
            return Ok(announcement);
        }

        /// <summary>
        /// Add the new announcement
        /// </summary>
        /// <param name="announcement"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Announcement announcement)
        {
            int id = _announcementService.Post(announcement);
            if (id == -1)
                return Conflict("Samochód wybrany w ogłoszeniu nie istnieje");
            else
                return Ok(id);
        }

        /// <summary>
        /// Edit the existing announcement with given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="announcement"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Announcement announcement)
        {
            if(id != announcement.Id)
            {
                return Conflict("Identyfikatory nie zgadzają się");
            }
            else
            {
                var isUpdateSuccesful = _announcementService.Put(id, announcement);
                if (isUpdateSuccesful)
                    return NoContent();
                else
                    return NotFound();
            }

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _announcementService.Delete(id);
            if (isDeleteSuccessful)
                return NoContent();
            else
                return NotFound();
        }
    }
}
