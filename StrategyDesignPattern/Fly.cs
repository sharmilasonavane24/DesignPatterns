namespace StrategyDesignPattern
{
    public class ItFly: IFly
    {
        public string Flying()
        {
            return "It can fly";
        }
    }


    public class CanNotFly : IFly
    {
        public string Flying()
        {
            return "It can not fly";
        }
    }
}