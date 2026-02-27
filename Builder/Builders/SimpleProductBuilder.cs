using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    internal class SimpleProductBuilder : IBuilder
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
            _description = "This is a simple product.";
        }

        public void WithdName()
        {
            _name = "Simple Product";
        }
    }
}
