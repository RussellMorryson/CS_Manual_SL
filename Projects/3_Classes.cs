/* В компании есть 2 отдела, и она растет, поэтому требуется больше отделов.
Данная вам программа принимает количество отделов, которые будут открыты, 
в качестве входных данных, затем принимает их имена и создает объекты отдела, 
передавая их имена в качестве конструктора.
Завершите класс Department, чтобы иметь 1 статический элемент depCount с начальным 
значением 2 для количества отделов и конструктора, который будет его подсчитывать 
и выводить соответствующее сообщение

Sample Input
2
Finance
Marketing

Sample Output
Department opened: Finance
Department opened: Marketing
Number of departments: 4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        class Code_program{
            static void Main(string[] args) {
                int numOfDeps = Convert.ToInt32(Console.ReadLine()); //ввод количества отделов
                int count = 0;
                while (count < numOfDeps) {
                    string depName = Console.ReadLine(); // Ввод наименования отдела
                    Department dep = new Department(depName); // ссылка на вывод на экран наименования
                    count++;
                }
                Console.WriteLine($"Number of departments: {Department.depCount+count}");
            }
        }
        class Department {
            public static int depCount = 2;
            public Department(string name) {
                Console.WriteLine("Department opened: " + name);            
            }
        }
    }
}