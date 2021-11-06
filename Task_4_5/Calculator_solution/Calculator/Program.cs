using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var plus = new PlusHandler();
            var minus = new MinusHandler();
            var multiply = new MultiplyHandler();
            var divide = new DivideHandler();

            plus.SetNext(minus).SetNext(multiply).SetNext(divide);

            Console.WriteLine("Chain: Plus > Minus > Multiply > Divide");
            Client.ClientCode(plus);
        }
    }
}
