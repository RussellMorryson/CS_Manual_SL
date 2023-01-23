/* В пошаговой стратегической игре каждый юнит может атаковать.
Стандартный юнит атакует мечом. Но есть еще два типа юнитов - мушкетеры и маги,
 которые атакуют по-своему.
Программа, которую вам дают, объявляет класс Unit, который имеет метод Attack(). 
Он выводит "Using sword!".
Извлеките классы Musketeer и Magician из класса Unit и переопределите его метод 
Attack() для вывода соответствующих сообщений во время атаки:

Musketeer => "Using musket!"
Magician =>"Using magic!"

Не забывайте о ключевом слове virtual, которое позволяет переопределять метод в 
производных классах.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit {
        public virtual void Attack() {
            Console.WriteLine("Using sword!");
        }
    }
    class Musketeer : Unit {
        public override void Attack() {
            Console.WriteLine("Using musket!");
        }
    }
    /*derive the class from Unit class
    and override Attack() method*/
    class Magician : Unit {
        public override void Attack() {
            Console.WriteLine("Using magic!");
        }
    }
}