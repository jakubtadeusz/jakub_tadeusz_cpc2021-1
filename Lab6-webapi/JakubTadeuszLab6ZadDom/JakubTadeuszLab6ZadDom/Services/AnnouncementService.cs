using JakubTadeuszLab6ZadDom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab6ZadDom.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly DatabaseContext _context;

        public AnnouncementService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Announcement> Get()
        {
            return _context.Announcements.ToList();
        }

        public Announcement GetAnnouncement(int id)
        {
            return _context.Announcements.FirstOrDefault(a => a.Id.Equals(id));
        }

        public int Post(Announcement announcement)
        {
            announcement.Id = 0;
            var car = _context.Cars.FirstOrDefault(c => c.Id.Equals(announcement.CarId));
            if(car == null)
            {
                return -1;
            }
            _context.Announcements.Add(announcement);
            _context.SaveChanges();
            return announcement.Id;
        }

        public bool Put(int id, Announcement announcement)
        {
            var announcementToUpdate = _context.Announcements.FirstOrDefault(a => a.Id.Equals(id));
            if (announcement == null)
            {
                return false;
            }
            announcementToUpdate.CarId = announcement.CarId;
            announcementToUpdate.Description = announcement.Description;
            announcementToUpdate.PhoneNumber = announcement.PhoneNumber;
            announcementToUpdate.Price = announcement.Price;
            announcementToUpdate.Type = announcement.Type;
            _context.Announcements.Update(announcementToUpdate);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var announcementToDelete = _context.Announcements.FirstOrDefault(a => a.Id.Equals(id));
            if (announcementToDelete == null)
            {
                return false;
            }
            _context.Announcements.Remove(announcementToDelete);
            _context.SaveChanges();
            return true;
        }

    }
}
