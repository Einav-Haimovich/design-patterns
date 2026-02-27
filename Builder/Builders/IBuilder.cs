using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void WithdName();
        void WithDescription();
        Product Build();
    }
}
