using VisitorPattern.Apples;
using VisitorPattern.Bananas;
using VisitorPattern.Strawberries;

namespace VisitorPattern
{
    public class Snacker : IFruitVisitor
    {
        //public void Snack(IFruit fruit)
        //{
            
        //    //if (fruit is IApple)
        //    //{
        //    //    var apple = fruit as IApple;

        //    //    apple.Skin();
        //    //    apple.Eat();
        //    //}
        //    //else if (fruit is IBanana)
        //    //{
        //    //    var banana = fruit as IBanana;

        //    //    banana.Peel();
        //    //    banana.Eat();
        //    //}
        //}

        public void Visit(IApple apple)
        {
            apple.Skin();
            apple.Eat();
        }

        public void Visit(IBanana banana)
        {
            banana.Peel();
            banana.Eat();
        }

        public void Visit(IStrawberry strawberry)
        {
            strawberry.Eat();
        }
    }
}