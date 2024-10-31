using Xunit;
using unithardTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unithardTest.Tests
{
    public class CatShopTests
    {
        [Fact()]
        public void AddItemTest()
        {
          var catsh = new CatShop();
            catsh.AddItem("кот");
            catsh.AddItem("попугайчик");
            catsh.ProcessOrder();
            Assert.Contains("кот", catsh.Products);
            Assert.Contains("попугайчик", catsh.Products);
            Assert.True(catsh.OrderProcessed, "Заказ должен быть обработан.");
            Assert.True(catsh.OrderProcessed, "Оплата прошла успешно");
        }

        public void ProcessOrderTest()
        {
            var catsh = new CatShop();
            var exception = Assert.Throws<InvalidOperationException>(() => catsh.ProcessOrder());
            Assert.Equal("Корзина пустая", exception.Message);
        }
    }
}