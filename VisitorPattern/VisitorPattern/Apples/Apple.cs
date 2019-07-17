using System;

namespace VisitorPattern.Apples
{
    public class Apple : Fruit, IApple
    {
        public void Skin()
        {
            Console.WriteLine("Skinning...");
        }

        protected override void AcceptInternal(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}