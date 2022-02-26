using JakubTadeuszLab6ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab6ZadDom.Services
{
    public interface IAnnouncementService
    {
        /// <summary>
        /// Return all announcements
        /// </summary>
        /// <returns></returns>
        List<Announcement> Get();

        /// <summary>
        /// Return announcement with given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Announcement GetAnnouncement(int id);

        /// <summary>
        /// Add new announcement and returns its id
        /// </summary>
        /// <param name="announcement"></param>
        /// <returns></returns>
        int Post(Announcement announcement);

        /// <summary>
        /// Edits announcement with given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="announcement"></param>
        /// <returns></returns>
        bool Put(int id, Announcement announcement);

        /// <summary>
        /// Delete announcement with given id, returns info if removed correctly
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
