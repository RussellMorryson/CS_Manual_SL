/* Мы набираем программистов в нашу команду. Есть 10 кандидатов, 
и нам нужно выбрать 3 из них.
В предоставленной вам программе у вас есть 10 кандидатов в 
хэш-наборе. Вам нужно взять 3 имени в качестве входных данных, 
добавить их в новый набор хэшей найма и проверить, 
присутствуют ли они в нашем наборе кандидатов.
Если это так, программа должна выдать "Starting hiring process"
("Запуск процесса найма"),в противном случае 
"Something is wrong". ("Что-то не так").

Sample Input
John
Susan
Daniel

Sample Output
Starting hiring process

IsSubsetOf() возвращает значение true, если набор хэшей 
является подмножеством указанной коллекции.
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
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            while (hiring.Count<3)
            {
                string hire = Console.ReadLine();
                hiring.Add(hire);
            }
            if (hiring.IsSubsetOf(candidates)){
                Console.WriteLine("Starting hiring process");
            }
            else {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}