using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modellli
{
    internal interface IOrderRepository
    {
        //получить список заказов для конкретного клиента
        Task<List<Order>> GetOrdersByAsync(Guid customerId);
        //получить список всех заказов
        Task <List<Order>> GetOrdersByAsync();
        //добваиьт заказ
        Task<Order>AddOrderAsync(Order order);
        //редактироать заказ
        Task<Order>UpdateOrderAsync(Order order);
        //stудалить заказ
        Task DeleteOrderAsync(long Id);
        //получить список всех продуктов в заказе
        Task<List<Product>> GetAllProductsAsync();
        //список всех ингридиентов
        Task<List<ProductOption>> GetAllProductOptionsAsync();
        //получить список размеров и объемов
        Task<List<ProductSize>> GetAllProductSizesAsync();
        //получить список статусов заказов
        Task<List<OrderStatus>> GetAllOrderStatusesAsync();
    }
}
