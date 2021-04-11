using Section05SecFactoryBuilder.Interfaces;
using Section05SecFactoryBuilder.Models;

namespace Section05SecFactoryBuilder.Builder
{
    class CarBuilder : IBuilder
    {
        public Vehicle Vehicle { get; set; }

        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public  void BuildEngine()
        {
            Vehicle["engine"] = "2500 cc";
        }

        public void BuildWheels()
        {
            Vehicle["wheels"] = "4";
        }

        public void BuildDoors()
        {
            Vehicle["doors"] = "4";
        }
    }
}
