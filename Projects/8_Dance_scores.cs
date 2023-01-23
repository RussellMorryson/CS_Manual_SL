/* В соревнованиях по бальным танцам каждый танцор из пары оценивается 
отдельно, а затем их баллы суммируются, чтобы получить общий балл пары.
Данная вам программа принимает имена и баллы каждого танцора в качестве 
входных данных и создает объекты DancerPoints для каждого танцора, 
используя принятые значения имени и баллов в качестве параметров для 
конструкторов.
Завершите данный класс, используя оператор overload +, чтобы вернуть 
новый объект, в котором имена танцоров находятся в одной строке 
(см. Пример вывода), а оценка равна сумме их баллов.
Объявление этого объекта и вывод его точек уже записаны в Main().

*/

using System;
using System.Collections.Generic;
namespace Code_Coach_Challenge {
    class Program {
        static void Main(string[] args) {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }
    class DancerPoints {
        public string name { get; set; }
        public int points { get; set; }
        public DancerPoints(string n, int p) {
            name = n;
            points = p;            
        }
        public static DancerPoints operator+ (DancerPoints a, DancerPoints b) {
            string n = a.name + " & " + b.name;
            int p = a.points + b.points;
            DancerPoints res = new DancerPoints (n, p);
            return res;
        }
    }
}