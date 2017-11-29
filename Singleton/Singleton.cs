using System;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private volatile static Singleton _instance;
        private static object _locker = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            //Double checked locking to make sure the 
            //lazy loading and thread safe, without the overhead 
            //of method synchronization
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}