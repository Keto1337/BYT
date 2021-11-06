using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Factory : BaseComponent
    {
        public void CompleteOrder()
        {
            Console.WriteLine("Factory: The order is completed");
            this._mediator.Notify(this, "Order completed");
        }

        public void ConfirmOrder()
        {
            Console.WriteLine("Factory: product was received by the client");
            this._mediator.Notify(this, "Order confirmed");
        }
    }
}
