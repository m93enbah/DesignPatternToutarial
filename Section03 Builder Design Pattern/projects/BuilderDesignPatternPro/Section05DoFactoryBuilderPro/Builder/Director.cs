using Section05DoFactoryBuilderPro.Interfaces;

namespace Section05DoFactoryBuilderPro.Builder
{
    //the best way is to use facad builder with apply functions that prepare all configuration 
    //or methods with apply chain way reutrn the class itselft
    public class Director
    {
        public ConcreteBuilder1 builder1 = new ConcreteBuilder1();

        public ConcreteBuilder2 builder2 = new ConcreteBuilder2();

        // Builder uses a complex series of steps
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }

        public void CallBuilder1() 
        {
            builder1.BuildPartA().BuildPartB();
        }

        public void CallBuilder2() 
        {
            builder2.BuildPartA().BuildPartB();
        }
    }
}
