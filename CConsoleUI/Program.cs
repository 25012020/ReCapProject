﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace CConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarList();
            Console.WriteLine("asd");
            Console.WriteLine("dsa");
            //ColorList();
            









            //            Araba Kiralama projemiz üzerinde çalışmaya devam edeceğiz.
            //Car nesnesine ek olarak;
            //            1) Brand ve Color nesneleri ekleyiniz(Entity)
            //Brand-- > Id,Name
            //  Color--> Id,Name
            //2) Sql Server tarafında yeni bir veritabanı kurunuz.Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)
            //3) Sisteme Generic IEntityRepository altyapısı yazınız.
            //4) Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.
            //5) GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
            //6) Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.
            //Araba ismi minimum 2 karakter olmalıdır
            //Araba günlük fiyatı 0'dan büyük olmalıdır.
        }

        private static void ColorList()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarList()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+"-"+car.BrandName+"-" +car.ColorName+"-" +car.DailyPrice);
            }
            
        }
    }
}
