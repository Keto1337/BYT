using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var expression in new List<string> { "29-3", "2*10", "63/9", "18^3", "5+39"})
            {
                Console.WriteLine($"Client: Who can calculate {expression} ?");

                var result = handler.Handle(expression);

                if (result != null)
                {
                    Console.WriteLine($"\t{result}");
                }
                else
                {
                    Console.WriteLine($"\tNobody could solve it: {expression}");
                }
            }
        }
    }
}
