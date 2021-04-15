namespace doFactoryBridge
{
    //we inject the Implementor as property on the Abstraction class to access to any class that inherit from the Iplementor
    class Abstraction
    {
        protected Implementor implementor;

        // Property

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
