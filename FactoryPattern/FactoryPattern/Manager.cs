namespace FactoryPattern
{
    public class Manager : Position
    {
        public override string Titile => "Manager";
    }

    public class HumanResource : Position
    {
        public override string Titile => "HumanResource";
    }

    public class Developer : Position
    {
        public override string Titile => "Developer";
    }
}