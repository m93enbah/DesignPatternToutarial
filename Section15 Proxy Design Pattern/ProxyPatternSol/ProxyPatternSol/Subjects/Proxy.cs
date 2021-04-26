namespace DoFactoryProxyPatternPro.Subjects
{
    //this class contain field that assign to another child class that inherit from Subject abstract class
    class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
