using Section05SecFactoryBuilder.Interfaces;
using Section05SecFactoryBuilder.Models;

namespace Section05SecFactoryBuilder.Builder
{
    class MotorCycleBuilder : IBuilder
    {
        public Vehicle Vehicle { get; set; }

        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "MotorCycle Frame";
        }

        public void BuildEngine()
        {
            Vehicle["engine"] = "500 cc";
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
