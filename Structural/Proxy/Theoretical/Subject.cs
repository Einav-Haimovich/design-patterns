using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Theoretical
{
    public class Subject : ISubject
    {
        public Subject()
        {
            Console.WriteLine("Instatiating a real Subject !");
        }

        public void Operation()
        {
            Console.WriteLine("Executing operation in Subject.");
        }
    }
}
