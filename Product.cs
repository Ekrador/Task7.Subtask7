using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{
    internal class Product 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0) { Console.WriteLine("Цена не может быть отрицательной"); }
                else { price = value; }
            }
        }
        public string Description { get; set; }
        private int stock;
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0) { Console.WriteLine("Количество не может быть отрицательным"); }
                else { stock = value; }
            }
        }
        public Product(int id, string name, string description, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Stock = stock;
        }



        public override string ToString()
        {
            return "ID: " + this.Id + "   Name: " + this.Name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Product product)
            {
                return Equals(product);
            }
            else return false;
        }
        public override int GetHashCode()
        {
            return this.Id;
        }
        public bool Equals(Product other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }

}
