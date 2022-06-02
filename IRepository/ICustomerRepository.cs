using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamzaTestAPP.Data;

namespace HamzaTestAPP.IRepository
{
    public interface ICustomerRepository
    {
        Customer Save(Customer customer);
        Customer GetCustomer(string customerId);

        List<Customer> GetsCustomers();
        Customer Update(Customer customer);
        string Delete(string customerId);
    }
}
