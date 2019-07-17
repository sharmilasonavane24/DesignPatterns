using System;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton _firstInstance = null;
        private static readonly object SyncObj=new object();
        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            lock (SyncObj) //Thread Safe singleton
            {
                return _firstInstance ?? (_firstInstance = new Singleton());
            }
           
        }

        public void WriteLine(string dataLine)
        {
            Console.WriteLine("This is data line {0}", dataLine);
        }
    }
}