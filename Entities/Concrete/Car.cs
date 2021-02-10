using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    //Id, BrandId, ColorId, ModelYear, DailyPrice, Description
    public class Car:IEntity
    {
        public int CarId { get; set; }
       
        public int CarModelYear { get; set; }
        public int CarDailyPrice { get; set; }
        public string CarDescription { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
    }
}
