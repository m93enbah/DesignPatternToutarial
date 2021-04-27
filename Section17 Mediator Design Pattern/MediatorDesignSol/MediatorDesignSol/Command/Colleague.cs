using DoFactoryMediatorPro.Mediator;

namespace DoFactoryMediatorPro.Command
{
    public abstract class Colleague
    {
        protected MediatorProvider mediator;

        public Colleague(MediatorProvider mediator)
        {
            this.mediator = mediator;
        }
    }
}
