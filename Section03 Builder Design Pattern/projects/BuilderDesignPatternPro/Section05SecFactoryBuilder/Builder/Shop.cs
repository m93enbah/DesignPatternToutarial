using Section05SecFactoryBuilder.Interfaces;

namespace Section05SecFactoryBuilder.Builder
{
    public class Shop
    {
        //we see that we pass the Builder instance on the Shop instead of create them explicit
        public void Construct(IBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
