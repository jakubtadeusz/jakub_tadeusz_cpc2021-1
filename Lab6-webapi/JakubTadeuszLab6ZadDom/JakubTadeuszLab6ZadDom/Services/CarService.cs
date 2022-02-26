using JakubTadeuszLab6ZadDom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab6ZadDom.Services
{
    public class CarService : ICarService
    {
        private readonly DatabaseContext _context;

        public CarService(DatabaseContext context)
        {
            _context = context;
        }


        public List<Car> Get()
        {
            return _context.Cars.ToList();
        }

        public Car GetCar(int id)
        {
            return _context.Cars.FirstOrDefault(c => c.Id.Equals(id));
        }

        public int Post(Car car)
        {
            car.Id = 0;
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car.Id;
        }

        public bool Put(int id, Car car)
        {
            var carToUpdate = _context.Cars.FirstOrDefault(c => c.Id.Equals(id));
            if (carToUpdate == null)
            {
                return false;
            }
            carToUpdate.Brand = car.Brand;
            carToUpdate.Color = car.Color;
            carToUpdate.Model = car.Model;
            carToUpdate.ImageLink = car.ImageLink;
            carToUpdate.Horsepower = car.Horsepower;
            _context.Cars.Update(carToUpdate);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var carToDelete = _context.Cars.FirstOrDefault(c => c.Id.Equals(id));
            if (carToDelete == null)
            {
                return false;
            }
            _context.Cars.Remove(carToDelete);
            _context.SaveChanges();
            return true;
        }

    }
}
