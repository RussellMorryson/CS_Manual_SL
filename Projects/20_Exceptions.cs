/* Туроператор предлагает пакетный отдых в Англии, Испании, Италии, 
Португалии и Франции.
Данная вам программа определяет массив с этими параметрами и 
принимает число N в качестве входных данных.
Напишите программу для вывода опции пакета с индексом N. 
Если номер находится вне диапазона, программа должна вывести 
"Неправильный номер". Независимо от результатов выбора, 
программа должна вывести "Goodbye" в конце.

Sample Input
2

Sample Output
Italy
Goodbye

Указывать тип исключения не обязательно.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            string[] tours = {"England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());
            
            //your code goes here
            try {
                Console.WriteLine(tours[choice]);
            }
            catch {
                Console.WriteLine("Wrong number");
            }
            finally {
                Console.WriteLine("Goodbye");
            }
        }
    }
}