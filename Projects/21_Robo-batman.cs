/* Robot-barman 
У вас есть робот-бармен, и его цель - аккуратно расставлять 
напитки на полках бара. Он очень умен и берет столько напитков, 
сколько необходимо, чтобы равномерно распределить их по полкам, 
но у него все еще есть проблемы с разделением.

Программа, установленная в роботе, принимает количество напитков и 
количество полок в качестве входных данных.
Выполните программу для равномерного распределения напитков по 
полкам: разделите количество напитков на количество полок и 
выведите результат.
Программа также должна справиться с этими двумя возможными 
проблемами:
1. разделитель (количество полок) никогда не должен быть равен нулю
2. оба входных параметра должны быть целыми числами.
Для первого исключения программа должна вывести "At least 1 shelf", а для второго -  "Please insert an integer"..

Sample Input
6
two

Sample Output
Please insert an integer

Используйте DivideByZeroException для первого исключения и 
FormatException для второго.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            try {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());
                int x = drinks / shelves;
                Console.WriteLine(x);
            }
            
            catch (DivideByZeroException) {
                Console.WriteLine("At least 1 shelf");
            }
            catch (FormatException) {
                Console.WriteLine("Please insert an integer");

            }
        }
    }
}