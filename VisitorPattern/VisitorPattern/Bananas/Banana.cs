using System;

namespace VisitorPattern.Bananas
{
    public class Banana : Fruit, IBanana
    {
        public void Peel()
        {
            Console.WriteLine("Peeling...");
        }

        protected override void AcceptInternal(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}