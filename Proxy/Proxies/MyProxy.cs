using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Proxies
{
    public class MyProxy : ISubject
    {
        private Subject? _realSubject;

        public MyProxy()
        {
            Console.WriteLine("Instantiating a Proxy instance.");
        }

        public void Operation()
        {
            Console.WriteLine("Proxy: Checking access before executing operation.");

            if (_realSubject is null)
            {
                _realSubject = new Subject();
            }

            _realSubject.Operation();
        }
    }
}
