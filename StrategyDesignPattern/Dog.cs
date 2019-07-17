namespace StrategyDesignPattern
{
    public class Dog :Animal
    {
        public Dog()
        {
            Weight = 10;
            FlyingType = new CanNotFly();
        }
    }
}