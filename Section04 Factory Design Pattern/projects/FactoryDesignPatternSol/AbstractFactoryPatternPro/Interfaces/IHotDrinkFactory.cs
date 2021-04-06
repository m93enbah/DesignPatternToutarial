namespace AbstractFactoryPatternPro.Interfaces
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
