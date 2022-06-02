using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamzaTestAPP.Data;
using HamzaTestAPP.IRepository;
using MongoDB.Driver;

namespace HamzaTestAPP.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private MongoClient mongoclient = null;

        private IMongoDatabase  database = null;

        private IMongoCollection<Customer> customer = null;

        public CustomerRepository()
        {
            mongoclient = new MongoClient("mongodb://127.0.0.1:27017/");
            database = mongoclient.GetDatabase("HamzaDB");
            customer = database.GetCollection<Customer>("Customers");

        }

        public string Delete(string customerId)
        {
            customer.DeleteOne(x => x.CustomerId == customerId);
            return "Deleted";
        }

        public Customer GetCustomer(string customerId)
        {
            return customer.Find(x => x.CustomerId == customerId).FirstOrDefault();
        }

        public List<Customer> GetsCustomers()
        {
            return customer.Find(FilterDefinition<Customer>.Empty).ToList();
        }

        public Customer Save(Customer customers)
        {
            var obj = customer.Find(x => x.CustomerId == customers.CustomerId).FirstOrDefault();
            if (obj == null)
            {
                customer.InsertOne(customers);
            }
            else
            {
                customer.ReplaceOne(x => x.CustomerId == customers.CustomerId, customers);
            }

            return customers;
        }

        public Customer Update(Customer customers)
        {
            var obj = customer.Find(x => x.CustomerId == customers.CustomerId).FirstOrDefault();
            if (obj != null)
            {
                customer.ReplaceOne(x => x.CustomerId == customers.CustomerId, customers);
            }

            return customers;
        }
    }
}
