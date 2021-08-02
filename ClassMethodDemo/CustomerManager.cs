using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(FullName(customer) + ": Customer added"); //Simulated
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(FullName(customer) + ": Customer updated"); //Simulated
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(FullName(customer) + ": Customer deleted"); //Simulated
        }

        public string FullName(Customer customer)
        {
            return (customer.FirstName + " " +customer.LastName);
        }
    }
}
