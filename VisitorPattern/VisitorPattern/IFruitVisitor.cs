using VisitorPattern.Apples;
using VisitorPattern.Bananas;
using VisitorPattern.Strawberries;

namespace VisitorPattern
{
    public interface IFruitVisitor
    {
        void Visit(IApple apple);

        void Visit(IBanana banana);

        void Visit(IStrawberry strawberry);
    }
}