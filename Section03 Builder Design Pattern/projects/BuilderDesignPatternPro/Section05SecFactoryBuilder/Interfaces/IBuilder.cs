using Section05SecFactoryBuilder.Models;

namespace Section05SecFactoryBuilder.Interfaces
{
    public interface IBuilder
    {
        Vehicle Vehicle { get; set; }
        void BuildFrame();
        void BuildEngine();
        void BuildWheels();
        void BuildDoors();
    }
}
