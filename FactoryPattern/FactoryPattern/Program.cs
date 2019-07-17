using System;

namespace FactoryPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter which library you wanna use to do operation {1,2}");
            var x = Console.Read();

            var factory=new Factory();
           
            var data= factory.GetPosition(x);
            Console.WriteLine(data.Titile);
            Console.ReadLine();
        }
    }

    public abstract class Position
    {
        public abstract string Titile { get; }
    }

    public class Factory
    {
        public Position GetPosition(int id)
        {
            switch (id)
            {
                case '1':
                    return new Manager();
                case '2':
                    return new Developer();
                case '3':
                    return new HumanResource();
                default:
                    return new Developer();
            }
        }
    }
}
