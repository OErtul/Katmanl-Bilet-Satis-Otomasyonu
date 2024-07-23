using BiletSatisKatmanli.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.BLL.CustomerService
{
    internal class CustomerService : ICustomerService
    {
        public bool AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                var result = UnitOfWork.Instance.CustomerRepository.Add(customer);
                if(result != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool DeleteCustomer(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                return false;
            }
        }

        public List<Customer> GetAllCustomer()
        {
            throw rw
        }

        public Customer GetByCustomerId(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public bool HasCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
