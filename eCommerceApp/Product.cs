using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp
{
    internal class Product
    {
        // Attributes
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; private set; }

        // Constructor
        public Product(int productId, string productName, decimal price, int stock)
        {
            if (productId < 1 || productId > 10000) throw new ArgumentOutOfRangeException(nameof(productId));
            if (price < 1 || price > 5000) throw new ArgumentOutOfRangeException(nameof(price));
            if (stock < 1 || stock > 100000) throw new ArgumentOutOfRangeException(nameof(stock));

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // Methods
        public void IncreaseStock(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            if (Stock - amount < 0) throw new InvalidOperationException("Insufficient stock");
            Stock -= amount;
        }

    }
}
