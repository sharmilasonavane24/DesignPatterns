namespace StrategyDesignPattern
{
    public class Animal
    {
        public string Name { get; set; }
        private int _weight;
        public int Weight 
        {
            get { return _weight; }
            set
            {
                _weight = value > 0 ? _weight = value :1;
            }
        }


        public IFly FlyingType;

        public string TryToFly()
        {
            return FlyingType.Flying();
        }

        public void SetFlyingAbility(IFly newFlyType)
        {
            FlyingType = newFlyType;
        }


    }
}