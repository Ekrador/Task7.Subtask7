using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        Courier Courier;

        public HomeDelivery(int OrderId, string address)
        {
            Courier = CallCourier(address, OrderId);
            Address = address;
        }

        private Courier CallCourier(string address, int id)
        {
            string name;
            int phone;
            int orderId;
            /* Логика поиска курьера для адреса */
            name = "";
            phone = 0;
            orderId = id;
            return new Courier(name, phone, orderId, address);
        }
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string address)
        {
            Address = address;
        }
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

}