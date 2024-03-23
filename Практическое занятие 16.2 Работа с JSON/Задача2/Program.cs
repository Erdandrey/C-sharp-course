using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Задача2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string JsonString = String.Empty;
            StreamReader sr = new StreamReader("../../../Goods.json");
            JsonString = sr.ReadToEnd();
            sr.Close();
            Goods[] goods = JsonSerializer.Deserialize < Goods[]>(JsonString);
            Goods MaxPrice = goods[0];
            foreach (Goods good in goods) 
            { 
                if (good.Price > MaxPrice.Price)
                {
                    MaxPrice = good;
                }
            }
            Console.WriteLine($"{MaxPrice.Id} {MaxPrice.Name} {MaxPrice.Price}");
            Console.ReadKey();
        }
    }
}
