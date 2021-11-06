using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Client : BaseComponent
    {
        public void Order()
        {
            Console.WriteLine("Client made the order");
            this._mediator.Notify(this, "Product Ordered");
        }

        public void ReceiveProduct()
        {
            Console.WriteLine("Client: Product was received.");
            this._mediator.Notify(this, "Product received");
        }
    }
}
