using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters
{
    public class MyAdapter(Adaptee adaptee) : ITarget
    {

        public void Reuest()
        {
            adaptee.SendSpeceficRequest();
        }

    }
}
