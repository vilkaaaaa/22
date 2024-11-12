using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace modellli
{
    internal class OrderRepository : IOrderRepository
    {
        private readonly PizzaDbKozlovtsevContext _context = new PizzaDbKozlovtsevContext();

        public async Task<Order> AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task DeleteOrderAsync(long orderId)
        {
            using (TransactionScope scope = new TransactionScope()) 
            {
                var order = _context.Orders.Include("OrderItems")
                    .Include("OrderItems.OrderItemsOptions")
                    .FirstOrDefault(o => o.Id == orderId);
                if(order != null)
                {
                    foreach(OrderItem item in order.OrderItems)
                    {
                        foreach (var itemOut in item.OrderItemOptions)
                        {
                            _context.OrderItemOptions.Remove(itemOut);
                        }
                        _context.Orders.Remove(order);
                    }
                    await _context.SaveChangesAsync();
                    scope.Complete();
                }
            }
        }

        public Task<List<OrderStatus>> GetAllOrderStatusesAsync() =>_context.OrderStatuses.ToListAsync();

        public Task<List<Product>> GetAllProductsAsync()=>_context.Products.ToListAsync();

        public Task<List<ProductSize>> GetAllProductSizesAsync()=>_context.ProductSizes.ToListAsync();
      

        public Task<List<ProductOption>> GetAllProductOptionsAsync()=> _context.ProductOptions.ToListAsync();
        public Task<List<Order>> GetOrdersByAsync()=>_context.Orders.ToListAsync();

        public Task<List<Order>> GetOrdersByAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

 
        public async Task<Order> UpdateOrderAsync(Order order)
        {
            if(!_context.Orders.Local.Any(o=>o.Id == order.Id))
            {
                _context.Orders.Attach(order);
            }
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return order;
        }
    }
}
