using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Theoretical
{
    public class MyAdapter(Adaptee adaptee) : ITarget
    {

        public void Reuest()
        {
            adaptee.SendSpeceficRequest();
        }

    }
}
