namespace DoFactorySingeltonPro
{
    public class Singleton
    {
        private static Singleton _instance;

        // Constructor is 'protected' so you cannot create instance directly but through static field
        protected Singleton(){}

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
