using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{
    internal abstract class Person
    {
        private string name;
        private int phone;

        public Person(string personName, int personPhone)
        {
            name = personName;
            phone = personPhone;
        }


        public string Name => name;
        public int Phone => phone;

        public void DisplayInfo()
        {
            Console.WriteLine(Name + ", " + Phone);
        }
    }

    internal class Courier : Person
    {
        int Order { get;}
        string DeliveryAddress { get; }

        
        public Courier(string name, int phone, int order, string address) : base(name, phone)
        {
            Order = order;
            DeliveryAddress = address;
        }

        public void Deliver(Order<HomeDelivery> order, string DeliveryAddress)
        {
            /* Доставка */
            order.Delivered = true;
        }
    }

    internal class Customer : Person 
    {
        ShoppingCart customersCart;
        Delivery deliveryType;
        internal List<int> customersOrders = new List<int>();

        public Customer(string name, int phone) : base(name, phone)
        {
            customersCart = new ShoppingCart();
        }

        public void CreateOrder<TDelivery>() where TDelivery : Delivery 
        {
            if (customersCart.HasProducts())
            {
                Console.WriteLine("Выберите тип доставки."+ Environment.NewLine +"\"Home\" для доставки на дом."
                    + Environment.NewLine + "\"Pick Point\" для выбора постамата."
                    + Environment.NewLine + "\"Shop\" для самовывоза из магазина.");
                string answer = Console.ReadLine();
                Order<TDelivery> order;
                switch (answer)
                {
                    case ("Home"):
                        Console.WriteLine("Введите адрес.");
                        string address = Console.ReadLine();
                        order = new Order<TDelivery>(customersCart.ToString(), this.Name, this.Phone, address, this, customersCart);
                        break;
                    case ("Pick Point"):
                        address = ChoosePickPoint();
                        order = new Order<TDelivery> (customersCart.ToString(), this.Name, this.Phone, address, this, customersCart);
                        break;
                    default:
                        order = new Order<TDelivery>(customersCart.ToString(), this.Name, this.Phone, this, customersCart);
                        break;
                }
            }
            else Console.WriteLine("Ваша корзина пуста, нечего оформлять.");
        }


        public void AddToOrders(int id)
        {
            customersOrders.Add(id);
        }

        public void RemoveFromOrders(int id)
        {
            for (int i = 0; i < customersOrders.Count; i++)
            {
                if (customersOrders[i] == id) 
                {
                    customersOrders.RemoveAt(i); 
                }
                else Console.WriteLine("В списке заказов нет заказа с таким Id.");
            }
            
        }


        public string ChoosePickPoint() {
            string address;
            address = "";
                /* Логика выбора постамата */
            return address;
        }
        

    }
}

