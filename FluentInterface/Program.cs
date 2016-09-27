using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new CustomerBuilder().Id("001").Name("Tom").Email("Tom@gmail.com").Cellphone("092222221212").build();
        }
    }

    public class Customer
    {
        private string id;
        private string name;
        private string email;
        private string cellphone;

        public Customer(string id, string name, string email, string cellphone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.cellphone = cellphone;
        }
    }

    public class CustomerBuilder
    {
        private Customer customer;
        private string id;
        private string name;
        private string email;
        private string cellphone;

        public CustomerBuilder Id(string id)
        {
            this.id = id;
            return (this);
        }

        public CustomerBuilder Name(string name)
        {
            this.name = name;
            return (this);
        }

        public CustomerBuilder Email(string email)
        {
            this.email = email;
            return (this);
        }

        public CustomerBuilder Cellphone(string cellphone)
        {
            this.cellphone = cellphone;
            return (this);
        }

        public Customer build()
        {
            this.customer = new Customer(id, name, email, cellphone);
            return (customer);
        }

    }
}
