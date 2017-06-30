using System;

namespace BasketTest
{
    public class Product
    {
        public readonly decimal Value;
        public readonly ProductCategory? Category;

        private const int _minValue = 0;

        public Product(decimal value, ProductCategory? category = null)
        {
            if (value < _minValue) throw new ArgumentOutOfRangeException($"Value must be greater than {_minValue}.");

            Value = value;
            Category = category;
        }
    }
}
