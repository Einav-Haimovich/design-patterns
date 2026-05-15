using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Theoretical
{
    public interface IBuilder
    {
        void WithdName();
        void WithDescription();
        Product Build();
    }
}
