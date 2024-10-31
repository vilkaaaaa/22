using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unithardTest
{
    public class CatShop
    {
        public List <string> Products { get;private set; } = new List <string> ();
        public bool OrderProcessed { get; private set; } = false;
        public bool PaymentSuccess { get; private set; } = false;

        public void AddItem(string item)
        {
            Products.Add(item);
            Console.WriteLine($"Товар '{item}' добавлен в корзину");
        }
        public void ProcessOrder()
        {
            if (Products.Count == 0)
            {
                throw new InvalidCastException("Корзина пуста. Невыбрано ни одного товара");
            }

            PaymentSuccess = ProcessPayment();
            if (PaymentSuccess)
            {
                OrderProcessed = true;
                Console.WriteLine("заказ обработан");
            }
            else
            {
                Console.WriteLine("не удалось провести оплату");
            }
        }
        public bool ProcessPayment()
        {
            Console.WriteLine("Процесс оплаты");
            return true;
        }
    }
}
