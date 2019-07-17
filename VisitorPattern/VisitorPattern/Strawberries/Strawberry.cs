namespace VisitorPattern.Strawberries
{
    public class Strawberry : Fruit, IStrawberry
    {
        protected override void AcceptInternal(IFruitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}