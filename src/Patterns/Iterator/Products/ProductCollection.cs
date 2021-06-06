using System;
using System.Collections.Generic;

namespace Patterns.Iterator.Products
{
    public class ProductCollection
    {
        private List<Product> products = new();

        public void Add(Product product)
        {
            products.Add(product);
        }

        public IITerator<Product> CreateIterator()
        {
            return new ProductListIterator(this);
        }
        public class ProductListIterator : IITerator<Product>
        {
            private readonly ProductCollection productCollection;

            private int index = 0;
            public ProductListIterator(ProductCollection productCollection)
            {
                this.productCollection = productCollection;
            }

            public Product Current()
            {
                return productCollection.products[index];
            }

            public bool HasNext()
            {
                return (index < productCollection.products.Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}