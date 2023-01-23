/* Менеджер кофейни проводит акцию и хочет предложить скидку на кофейные напитки.
Предоставленная вам программа принимает значение скидки в качестве входных 
данных и определяет словарь, где названия кофейных напитков задаются в 
качестве ключей, а их цены - в качестве значений.
Напишите программу для скидки на все цены и выведите новый прайс-лист в 
формате, показанном ниже.

Sample Input
10

Sample Output
Americano: 45
Latte: 63
Flat White: 54
Espresso: 54
Cappuccino: 72
Mocha: 81

Используйте coffee.Keys.ToArray() внутри цикла foreach.
Обратите внимание на пробел после ":" в выходных данных.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (string i in coffee.Keys)   
                Console.WriteLine(i + ": " + Convert.ToInt32(coffee[i] - (coffee[i] * discount / 100)));
        }
    }
}