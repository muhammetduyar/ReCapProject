﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarServices
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal=carDal;

        }
        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        void Add(Car car)
        {
            _carDal.Add(car);
        }
    }
}
