using Microsoft.EntityFrameworkCore;
using SlideYourRideServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Services
{
    public class StopService : IStopService
    {
        private readonly DatabaseContext _context;

        public StopService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Stop> Get()
        {
            return _context.Stops.ToList();
        }

        public Stop GetStop(int id)
        {
            return _context.Stops.FirstOrDefault(s => s.Id.Equals(id));
        }

        public int Post(Stop stop)
        {
            stop.Id = 0;
            _context.Stops.Add(stop);
            _context.SaveChanges();
            return stop.Id;
        }

        public bool Put(int id, Stop stop)
        {
            var stopToUpdate = _context.Stops.FirstOrDefault(s => s.Id.Equals(id));
            if (stopToUpdate == null) return false;
            stopToUpdate.StopName = stop.StopName;
            stopToUpdate.StopDescription = stop.StopDescription;
            _context.Stops.Update(stopToUpdate);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var stopToDelete = _context.Stops.FirstOrDefault(s => s.Id.Equals(id));
            if (stopToDelete == null) return false;
            var tracksToDelete = _context.Tracks.Where(t => t.StartStopId.Equals(id) || t.EndStopId.Equals(id));
            if (tracksToDelete != null)
                _context.Tracks.RemoveRange(tracksToDelete);
            _context.Stops.Remove(stopToDelete);
            _context.SaveChanges();
            return true;
        }

    }
}
