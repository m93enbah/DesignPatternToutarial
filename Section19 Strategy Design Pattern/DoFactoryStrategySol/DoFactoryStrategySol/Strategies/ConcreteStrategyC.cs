using System;

namespace DoFactoryStrategyPro.Strategies
{
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
