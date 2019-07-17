namespace VisitorPattern
{
    public interface IFruit
    {
        void Eat();

        void Accept(IFruitVisitor visitor);
    }
}