using BiletSatisKatmanli.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.BLL.CustomerService
{
    public interface ICustomerService
    {
        bool AddCustomer(Customer customer);

        bool UpdateCustomer(Customer customer); 

        bool DeleteCustomer(Guid customerId);

        Customer GetByCustomerId(Guid customerId);

        List<Customer> GetAllCustomer();

        bool HasCustomer(Customer customer);
    }
}
