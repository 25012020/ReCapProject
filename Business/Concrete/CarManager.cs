using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car entity)
        {

            using (ReCapDbContext context = new ReCapDbContext())
            {
                var addedCar = context.Entry(entity);
                if (entity.CarDescription.Length >= 2 && entity.CarDailyPrice > 0)
                {
                    addedCar.State = EntityState.Added;
                    context.SaveChanges();
                }
                else
                { Console.WriteLine("Invalid Entry"); }

            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails(); ;
        }
    }
}
