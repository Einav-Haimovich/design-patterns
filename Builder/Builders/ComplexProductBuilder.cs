using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    public class ComplexProductBuilder : IBuilder
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public Product Build()
        {
            return new Product(
                Name: _name,
                Description: _description
            );
        }

        public void WithDescription()
        {
            _description = "This is a complex product with many features.";
        }

        public void WithdName()
        {
            _name = "This is a complex product.";
        }
    }
}
