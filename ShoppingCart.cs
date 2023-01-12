using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{
    internal class ShoppingCart
    {
        internal List<Product> products;

        public void AddToCart(Product product)
        {
            products.Add(product);
        }

        public void RemoveFromCart(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] == product) { }
            }
            products.Remove(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product product in products)
            {
                sb.Append(product.ToString() + Environment.NewLine);
            }
            return sb.ToString();
        }

        public static ShoppingCart operator +(ShoppingCart shoppingCart, Product product)
        {
            shoppingCart.AddToCart(product);
            return shoppingCart;
        }

        public static ShoppingCart operator -(ShoppingCart shoppingCart, Product product)
        {
            shoppingCart.RemoveFromCart(product);
            return shoppingCart;
        }

        public bool HasProducts()
        {
            if (products.Count > 0) { return true; }
            else return false;
        }
        public Product this[int id]
        {
            get
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id == id) { return products[i]; }
                }
                Console.WriteLine("Этого товара нет в корзине");
                return null;
            }
        }

        public Product this[string name]
        {
            get
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name.Equals(name)) { return products[i]; }
                }
                Console.WriteLine("Этого товара нет в корзине");
                return null;
            }
        }
    }
}
