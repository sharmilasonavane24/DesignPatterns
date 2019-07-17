using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapter adapter = null;

            Console.WriteLine("Enter which library you wanna use to do operation {1,2}");
            var x = Console.Read();

            switch (x)
            {
                case '1':
                    //Let us choose to use Library one to do something
                    adapter = new FirstClassAdapter();
                    break;
                case '2':
                    //Let us choose to use Library two to do something
                    adapter = new SecondClassAdapter();
                    break;
            }

            //Just do the operation now
            adapter?.Do();

            Console.ReadLine();
        }
    }

    public class FirstClass
    {
        public void PrintMessage()
        {
            Console.Write("This is First Class");
            Console.ReadLine();
        }
    }

    public class SecondClass
    {
        public string PrintMessage()
        {
            return "This is Second Class";
        }
    }

    interface IAdapter
    {
        void Do();
    }

    public class FirstClassAdapter: IAdapter
    {
        private readonly FirstClass _firstClass;
        public FirstClassAdapter()
        {
            _firstClass=new FirstClass();
        }

        public void Do()
        {
        _firstClass.PrintMessage();
        }
    }

    public class SecondClassAdapter : IAdapter
    {
        private readonly SecondClass _secondClass;

        public SecondClassAdapter()
        {
            _secondClass=new SecondClass();
        }
        public void Do()
        {
           Console.WriteLine( _secondClass.PrintMessage());
            Console.ReadLine();
        }
    }

}
