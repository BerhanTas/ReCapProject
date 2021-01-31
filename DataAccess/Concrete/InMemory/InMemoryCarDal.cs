using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
        public class InMemoryCarDal : ICarDal
        {
            List<Car> _cars;
            public InMemoryCarDal()
            {
                _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = 1999,DailyPrice = 250, Description = "auto"},
                new Car{CarId = 2,BrandId = 2,ColorId = 2,ModelYear = 1998,DailyPrice = 240, Description = "auto"},
                new Car{CarId = 3,BrandId = 3,ColorId = 3,ModelYear = 1997,DailyPrice = 230, Description = "auto"},
                new Car{CarId = 4,BrandId = 4,ColorId = 4,ModelYear = 1996,DailyPrice = 220, Description = "manuel"},
                new Car{CarId = 5,BrandId = 5,ColorId = 5,ModelYear = 1995,DailyPrice = 210, Description = "auto"},
                new Car{CarId = 6,BrandId = 6,ColorId = 6,ModelYear = 1994,DailyPrice = 200, Description = "manuel"},
                new Car{CarId = 7,BrandId = 7,ColorId = 7,ModelYear = 1993,DailyPrice = 190, Description = "manuel"}
            };
            }
            public void Add(Car car)
            {
                _cars.Add(car);
            }
            public void Delete(Car car)
            {
                Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
                _cars.Remove(carToDelete);
            }

            public List<Car> GetAll()
            {
                return _cars;
            }

            public List<Car> GetAllByCategory(int categoryId)
            {
                throw new NotImplementedException();
            }

            public void Update(Car car)
            {
                Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
                carToUpdate.ModelYear = car.ModelYear;
            }
        }
    }