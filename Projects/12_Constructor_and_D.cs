/* Вы являетесь администратором аэропорта, ответственным за установку статусов 
рейсов.
Сначала программа полета показывала только статусы "Регистрация" и "Закрыто", 
но нам нужно расширить ее, чтобы предоставить более подробную информацию.
Извлеките класс WayStatus из класса полета и завершите его
1. конструктор, для вывода "В пути"
2. деструктор, для вывода "Приземлился"

чтобы программа корректно выводила все статусы полета.
Помните, что при создании объекта производного класса также вызываются 
конструктор и деструктор базового класса - конструктор вызывается в начале, 
а деструктор в самом конце.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            WayStatus status = new WayStatus();
        }
    }
    class Flight {
        public Flight() {
            Console.WriteLine("Registration");
        }
        ~Flight() {
            Console.WriteLine("Closed");
        }
    }
    /*выведите этот класс из класса Flight,
определите для него конструктор и деструктор*/
    class WayStatus : Flight {
        public WayStatus() {
            Console.WriteLine("On the way");
        }
        ~WayStatus() {
            Console.WriteLine("Landed");
        }
    }
}