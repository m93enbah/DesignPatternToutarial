using Section05SecFactoryBuilder.Interfaces;
using Section05SecFactoryBuilder.Models;

namespace Section05SecFactoryBuilder.Builder
{
    class ScooterBuilder : IBuilder
    {
        public Vehicle Vehicle { get; set; }

        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "Scooter Frame";
        }

        public void BuildEngine()
        {
            Vehicle["engine"] = "50 cc";
        }

        public void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }
    }
}
