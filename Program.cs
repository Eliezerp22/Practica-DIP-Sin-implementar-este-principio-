using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DIP_Sin_implementar_este_principio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CustomerRepository
    {
        public Customer GetCustomerById(int id)
        {
            return new Customer { Id = id, Name = "Cliente de ejemplo" };
        }
    }

    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }

}


