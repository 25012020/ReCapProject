//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;

////Id, BrandId, ColorId, ModelYear, DailyPrice, Description
//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car> {
//                new Car { CarId = 1 , BrandId = 1 ,ColorId = 3,CarModelYear = 2013, CarDailyPrice = 80  , CarDescription = "BMW e92" },
//                new Car { CarId = 2 , BrandId = 1 ,ColorId = 2 ,CarModelYear = 1999, CarDailyPrice = 50  , CarDescription = "BMW e46" },
//                new Car { CarId = 3 , BrandId = 2, ColorId = 4, CarModelYear = 2020, CarDailyPrice = 150 , CarDescription = "Mercedes e250"  },
//                new Car { CarId = 4 , BrandId = 2, ColorId = 1, CarModelYear = 2018, CarDailyPrice = 100 , CarDescription = "Mercedes a180"  },
//                new Car { CarId = 5 , BrandId = 3, ColorId = 3, CarModelYear = 2008, CarDailyPrice = 90  , CarDescription = "Audi s3" },
//                new Car { CarId = 6 , BrandId = 3, ColorId = 2, CarModelYear = 2011, CarDailyPrice = 120 , CarDescription = "Audi rs7"  }



//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete =  _cars.SingleOrDefault(c=>c.CarId == car.CarId);
//            _cars.Remove(carToDelete);

//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int Id)
//        {
//            return _cars.Where(c=> c.CarId == Id).ToList();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

//            carToUpdate.Id = car.Id;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;




//        }
//    }
//}
