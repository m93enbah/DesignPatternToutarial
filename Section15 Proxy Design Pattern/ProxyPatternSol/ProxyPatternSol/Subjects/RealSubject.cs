using System;

namespace DoFactoryProxyPatternPro.Subjects
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
