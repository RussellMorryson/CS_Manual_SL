/* Вы пишете программу, которая может выводить значение 
переменной любого типа. Он принимает строку, целое число 
и двойное значение в качестве входных данных, а затем 
должен вывести их.
Создайте универсальный метод Print для класса Printer для 
правильного выполнения заданных вызовов.

Sample Input
Hello
14
7.6

Sample Output

Showing Hello
Showing 14
Showing 7.6

Обратите внимание, что объекта класса Printer нет, 
поэтому универсальный метод должен быть static (ститическим).

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());

            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer {
        public static void Print <T> (T x) {          
            Console.WriteLine($"Showing {x}");            
        }        
    }
}