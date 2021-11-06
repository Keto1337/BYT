using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator : IMediator
    {
        private Factory _factory;
        private Client _client;

        public ConcreteMediator(Factory factory, Client client)
        {
            this._factory = factory;
            this._factory.SetMediator(this);
            this._client = client;
            this._client.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "Product Ordered")
            {
                Console.WriteLine("Mediator: Client made the order.");

                this._factory.CompleteOrder();
            }

            if (ev == "Order completed")
            {
                Console.WriteLine("Mediator: Factory completed the order.");

                this._client.ReceiveProduct();
            }

            if (ev == "Product received")
            {
                Console.WriteLine("Mediator: Client received the ordered product.");

                this._factory.ConfirmOrder();
            }
        }
    }
}
