using System;

namespace SingletonDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var writeLine = Singleton.GetInstance();
            writeLine.WriteLine("My data line");

            Console.ReadLine();
        }
    }
}
