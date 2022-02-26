using Microsoft.EntityFrameworkCore;
using SlideYourRideServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Services
{
    public class TrackService : ITrackService
    {
        private readonly DatabaseContext _context;

        public TrackService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Track> Get(int stopId)
        {
            return _context.Tracks.Where(t=>t.StartStopId.Equals(stopId)).ToList();
        }

        public int Post(Track track)
        {
            track.Id = 0;
            _context.Tracks.Add(track);
            _context.SaveChanges();
            int id = track.Id;
            track.Id = 0;
            int startId = track.StartStopId;
            track.StartStopId = track.EndStopId;
            track.EndStopId = startId;
            track.Elevation = (-track.Elevation);
            _context.Tracks.Add(track);
            _context.SaveChanges();
            return id;
        }

        public bool Put(int id, Track track)
        {
            var trackToUpdate = _context.Tracks.FirstOrDefault(t => t.Id.Equals(id));
            if (trackToUpdate == null)
            {
                return false;
            }
            trackToUpdate.Elevation = track.Elevation;
            trackToUpdate.Length = track.Length;
            trackToUpdate.StartStopId = track.StartStopId;
            trackToUpdate.EndStopId = track.EndStopId;
            trackToUpdate.TrackDescription = track.TrackDescription;
            _context.Tracks.Update(trackToUpdate);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var trackToDelete = _context.Tracks.FirstOrDefault(t => t.Id.Equals(id));
            if (trackToDelete == null)
            {
                return false;
            }
            _context.Tracks.Remove(trackToDelete);
            _context.SaveChanges();
            return true;
        }
    }
}
