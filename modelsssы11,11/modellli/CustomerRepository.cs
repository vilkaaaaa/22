using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modellli
{
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly PizzaDbKozlovtsevContext _context = new PizzaDbKozlovtsevContext();
        public async Task<Customer> CreateCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task DeletecustomerAsync(Guid customerId)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
            await _context.SaveChangesAsync();
        }

        public Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            return _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Customer>> GetCustomersAsync()
        {
        return _context.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
           if(!_context.Customers.Local.Any(x =>x.Id==customer.Id))
            {
            _context.Customers.Attach(customer);
            }
           _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer;
        }
    }
}
