using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 1,
                FirstName = "Furkan",
                LastName = "Ogutcu",
            };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine(customerManager.FullName(customer1));
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);           
        }
    }
}
