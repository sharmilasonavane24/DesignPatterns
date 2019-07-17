using System;

namespace VisitorPattern
{
    public abstract class Fruit : IFruit
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Accept(IFruitVisitor visitor)
        {
            AcceptInternal(visitor);
        }

        protected abstract void AcceptInternal(IFruitVisitor visitor);

    }
}