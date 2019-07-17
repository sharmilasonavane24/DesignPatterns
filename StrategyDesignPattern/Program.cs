using System;

namespace StrategyDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal d=new Dog();
            Animal b=new Bird();
            Console.WriteLine("Dog: {0} {1}", d.TryToFly(), d.Weight);
            Console.WriteLine("Cat: {0} {1}", b.TryToFly(), b.Weight);

            d.SetFlyingAbility(new ItFly());
            Console.WriteLine("Dog: {0} {1}", d.TryToFly(), d.Weight);
        }
    }
}
