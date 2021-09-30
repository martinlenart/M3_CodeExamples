using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    public enum CarColor
    {
        Brown, Red, Green, Burgundy
    }
    public enum CarBrand
    {
        Boxcar, Ford, Jaguar, Honda
    }
    public enum CarModel
    {
        Boxmodel, Mustang_GT, XF, Civic
    }
    class Car
    {
        public CarColor Color { get; set; }
        public CarBrand Brand { get; set; }
        public CarModel Model { get; set; }

        public int KW { get; set; } = 2000;
        public int Year { get; }

        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Color: {Color}, KW: {KW}, Year: {Year}";
        }

        public Car ()
        {
            Color = CarColor.Burgundy;
            Brand = CarBrand.Honda;
            Model = CarModel.Civic;
            Year = 2021;
        }
        public Car (bool Favorite) : this()
        {
            if (Favorite)
            {
                Color = CarColor.Red;
                Brand = CarBrand.Ford;
                Model = CarModel.Mustang_GT;
                Year = 1978;
                KW = 4000;
            }
        }
    }
}
