using System.Threading;

namespace PreThreadPro
{
    public sealed class PerThreadSingleton
    {
        //we apply the singelton per thread so every thread has its own single instance
        private static ThreadLocal<PerThreadSingleton> threadInstance
          = new ThreadLocal<PerThreadSingleton>(
            () => new PerThreadSingleton());

        public int Id;

        private PerThreadSingleton()
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }

        public static PerThreadSingleton Instance => threadInstance.Value;
    }
}
