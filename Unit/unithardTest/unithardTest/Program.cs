using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unithardTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catsh = new CatShop();
            var availableProducts = new List<string> { "кот", "попугайчик", "наушники" };
            Console.WriteLine("Добро пожаловать в магазин\n доступные товары:");
            while (true)
            {

                for (int i = 0; i < availableProducts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableProducts[i]}");
                }

                Console.Write("Выберите номер товара или введите «5» для сборки заказа:\n");

                var input = Console.ReadLine();

                if (input?.ToLower() =="5")
                {
                    try
                    {
                        catsh.ProcessOrder();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                    
                }

                if (int.TryParse(input, out int itemNumber) && itemNumber > 0 && itemNumber <= availableProducts.Count)
                {
                    string selectedItem = availableProducts[itemNumber - 1];
                    catsh.AddItem(selectedItem);
                }
                else
                {
                    Console.WriteLine("Неверный ввод, выберите из имеющихся товаров");
                }
            }

        }
    }
    
}
