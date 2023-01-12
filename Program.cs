using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Subtask7
{   static class DataBaseExtensions
    {
        public static void AddCustomerToBase(this DataBase data, Customer customer)
        {
            data.CustomersBase.Add(customer);
        }

    }

 
    public class Program
    {
        internal static DataBase Base = new DataBase();
        internal void CreateCustomer()
        {
            
            Console.WriteLine("Введите имя покупателя.");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Введите номер телефона покупателя");
            int CustomerPhone;
            bool intparse = int.TryParse(Console.ReadLine(), out CustomerPhone);
            Customer customer = new Customer(CustomerName, CustomerPhone);
            Base.AddCustomerToBase(customer);

        }    
    }
}