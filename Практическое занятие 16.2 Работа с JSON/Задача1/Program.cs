using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Goods[] goods = new Goods[n];

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Введите идентификатор товара");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());
                goods[i] = new Goods() { Id = id, Name = name, Price = price };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string JsonString = JsonSerializer.Serialize(goods, options);

            StreamWriter sw = new StreamWriter("../../../Goods.json");
            sw.WriteLine(JsonString);
            sw.Close();
        }
    }
}
