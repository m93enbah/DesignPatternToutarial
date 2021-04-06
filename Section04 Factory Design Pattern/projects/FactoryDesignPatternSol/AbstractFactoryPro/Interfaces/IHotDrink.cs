namespace AbstractFactoryPro.Interfaces
{
    public interface IHotDrink
    {
        void Consume();
        IHotDrink Prepare(int amount);
    }
}
