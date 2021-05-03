using System;

namespace DoFactoryTemplateDesignPro.Templates
{
    abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        // The Template method group call all the functions implementations
        public void TemplateMethod()
        {
            Console.WriteLine("The Template Calling Start Here");
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("The Template Calling End Here");
        }
    }
}
