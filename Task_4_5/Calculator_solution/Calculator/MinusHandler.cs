using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MinusHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string).Contains('-'))
            {
                int number1 = Int32.Parse(request.ToString().Split('-')[0]);
                int number2 = Int32.Parse(request.ToString().Split('-')[1]);

                return $"Minus: {request.ToString()} = {number1 - number2}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
