using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(customer.Name + " named customer added succesfully!");
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(customer.Name + " named customer deleted succesfully!");
        }
    }
}
