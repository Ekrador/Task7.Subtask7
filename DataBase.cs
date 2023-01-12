using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{

    internal class DataBase 
    {
        internal List<Customer> CustomersBase;
        internal List<string> OrdersBase;

        public DataBase() {
            CustomersBase = new List<Customer>();
            OrdersBase = new List<string>();
        }
        
        public Customer this[string name]
        {
            get
            {
                for (int i = 0; i < CustomersBase.Count; i++)
                {
                    if (CustomersBase[i].Name.Equals(name)) { return CustomersBase[i]; }
                }
                Console.WriteLine("Нет покупателя с таким именем в базе.");
                return null;
            }
        }

        public string this[int id]
        {
            get
            {
                for (int i = 0; i < OrdersBase.Count; i++)
                {
                    if (OrdersBase[i].Contains(id.ToString())) {
                        string info = String.Format($"Заказ №{id} создан покупателем " + OrdersBase[i].ToString().Replace(id.ToString(), ""));
                        
                        return info; }
                }
                Console.WriteLine("Нет заказа с таким номером в базе.");
                return null;
            }
        }
    }
}
