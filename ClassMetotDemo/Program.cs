using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 10000;
            customer1.TCNo = "12345678901";
            customer1.Name = "Abdülkadir Bayraktar";
            customer1.DateOfBirth = "07.12.2001";

            CustomerManager.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Id = 10001;
            customer2.TCNo = "12345678902";
            customer2.Name = "Selahaddin Bayraktar";
            customer2.DateOfBirth = "21.05.2004";

            CustomerManager.Add(customer2);

            Customer customer3 = new Customer();
            customer3.Id = 10003;
            customer3.TCNo = "12345678903";
            customer3.Name = "Hava Bayraktar";
            customer3.DateOfBirth = "10.03.1977";

            CustomerManager.Add(customer3);

            Customer[] customers = new Customer[] {customer1, customer2, customer3};

            foreach (Customer customer in customers)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Customer TC Number: " + customer.TCNo);
                Console.WriteLine("Customer Id: " + customer.Id);
                Console.WriteLine("Customer Name: " + customer.Name);
                Console.WriteLine("Customer Date Of Birth: " + customer.DateOfBirth);
                
            }

            CustomerManager.Delete(customer2);

        }
    }
}