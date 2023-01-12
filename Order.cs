using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{   
    class Order<TDelivery> where TDelivery : Delivery
    {
        static int OrdersIds = 0;
        public TDelivery Delivery;

        private int number;

        internal bool Delivered = false;

        public int Number
        {
            get { return number; }
        }

        public string Description;
        string CustomerName;
        int CustomerPhone;
        string DeliveryAddress;
        string ShopAddress = "Адрес магазина";
        ShoppingCart cart;

        public Order(string description, string customername, int customerPhone, Customer customer, ShoppingCart cart) {
            Description = description;
            CustomerName = customername;
            CustomerPhone = customerPhone;
            DeliveryAddress = ShopAddress;
            OrderCreate(customer);
            this.cart = cart;
        }
        public Order(string description, string customername, int customerPhone, string address, Customer customer, ShoppingCart cart) 
            : this(description, customername, customerPhone, customer, cart)
        {
            DeliveryAddress = address;
            OrderCreate(customer);
        }

        public override string ToString()
        {
            return number.ToString() + " " + CustomerName + " " + CustomerPhone + " " + Description;
        }
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        private void OrderCreate(Customer customer)
        {
            number = ++OrdersIds;
            customer.AddToOrders(number);
            Program.Base.OrdersBase.Add(String.Format(number.ToString() +", " + customer.Name));
        }

        internal decimal OrderCost()
        {
            decimal cost = 0;
            for (int i = 0; i < cart.products.Count; i++) {
                cost += cart.products[i].Price;
            }
            return cost;    
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Order<TDelivery> order)
            {
                return Equals(order);
            }   
            else return false;
        
        }
        public override int GetHashCode()
        {
            return this.number;
        }
        public bool Equals(Order<TDelivery> other)
        {
            if (other == null) return false;
            return (this.number.Equals(other.number));
        }
    }
}