using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modellli
{
    internal interface ICustomerRepository
    {
      
            //получать список всвех пользователей
            Task<List<Customer>> GetCustomersAsync();
            // получение пользователя по id
            Task<Customer> GetCustomerByIdAsync(Guid id);
            //обновление пользователя
            Task<Customer> UpdateCustomerAsync(Customer customer);
            //удаление пользователя
            Task DeletecustomerAsync(Guid customerId);
            //создание пользователя
            Task<Customer> CreateCustomerAsync(Customer customer);
      
    }
}
