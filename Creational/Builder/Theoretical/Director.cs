using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Theoretical
{
    public class ProductDirector(IBuilder builder)
    {
        public void Construct()
        {
            builder.WithdName();
            builder.WithDescription();
        }
    }
}
