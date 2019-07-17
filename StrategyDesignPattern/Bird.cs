namespace StrategyDesignPattern
{
    public class Bird :Animal
    {
        public Bird()
        {
            Weight = 0;
            FlyingType=new ItFly();
        }

    }
}