using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            Factory factory = new Factory();
            Client client = new Client();
            new ConcreteMediator(factory, client);

            client.Order();

        }
    }
}
