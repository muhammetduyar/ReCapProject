using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCardDal : ICarDal
    {
        List<Car> car;
        public EfCardDal()
        {
            car = new List<Car> {
                new Car {CarId=15,ColorId=25,BrandId=35,DailyPrice=5000,Description="Bu Yeni sınıfın yeni Modelidir.",ModelYear="2022" },
                new Car {CarId=25,ColorId=88,BrandId=1085,DailyPrice=15000,Description="Lamburgini 2035 model olacak kısım",ModelYear="2035" },

            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return car;
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
