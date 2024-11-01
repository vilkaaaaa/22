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
        [Fact]
        public void ProcessOrderTest()
        {
            var catsh = new CatShop();
            var exception = Assert.Throws<InvalidCastException>(() => catsh.ProcessOrder());
            Assert.Equal("Корзина пуста. Невыбрано ни одного товара", exception.Message);
        }
        [Fact]
        public void RemoveItemTest()
        { 
            var catsh = new CatShop();
            catsh.RemoveItem("кот");
            Assert.DoesNotContain("кот", catsh.Products);
        }
    }
}