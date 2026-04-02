using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters
{
    public class Adaptee
    {
        public void SendSpeceficRequest()
        {
            Console.WriteLine("Adaptee: Specific request.");
        }
    }
}
