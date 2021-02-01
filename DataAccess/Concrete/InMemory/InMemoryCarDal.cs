using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Id, BrandId, ColorId, ModelYear, DailyPrice, Description
namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1 , BrandId = 1 ,ColorId = 3 ,ModelYear = 2013, DailyPrice = 80  , Description = "BMW e92" },
                new Car { Id = 2 , BrandId = 1 ,ColorId = 2 ,ModelYear = 1999, DailyPrice = 50  , Description = "BMW e46" },
                new Car { Id = 3 , BrandId = 2, ColorId = 4, ModelYear = 2020, DailyPrice = 150 , Description = "Mercedes e250"  },
                new Car { Id = 4 , BrandId = 2, ColorId = 1, ModelYear = 2018, DailyPrice = 100 , Description = "Mercedes a180"  },
                new Car { Id = 5 , BrandId = 3, ColorId = 3, ModelYear = 2008, DailyPrice = 90  , Description = "Audi s3" },
                new Car { Id = 6 , BrandId = 3, ColorId = 2, ModelYear = 2011, DailyPrice = 120 , Description = "Audi rs7"  }



            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=> c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;




        }
    }
}
