/* Гоночная видеоигра имеет 3 уровня сложности: легкий, средний и жесткий.
Каждому уровню сложности присваивается максимальное время для прохождения 
трассы: чем выше сложность, тем меньше время.
Программа, которую вам дают, определяет класс игрока и перечисление сложности 
и создает 3 объекта игрока с разными трудностями в качестве параметра для 
конструктора.
Завершите конструктор игрока, который принимает перечисление в качестве параметра 
для проверки времени для каждого варианта сложности и выводит соответствующее 
сообщение:

Easy => "You have 3 minutes 45 seconds"
Medium = > "You have 3 minutes 20 seconds"
Hard => "You have 3 minutes"

Используйте оператор switch для проверки каждого параметра перечисления и 
выполнения выходных данных.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }
    }
    class Player {
        public Player(Difficulty x) {
           switch (x) {
               case Difficulty.Easy:
                    Console.WriteLine("You have 3 minutes 45 seconds");
                    break;
                case Difficulty.Medium :
                    Console.WriteLine("You have 3 minutes 20 seconds");
                    break;
                case Difficulty.Hard:
                    Console.WriteLine("You have 3 minutes");
                    break;
            }            
        }
    }
    enum Difficulty {Easy, Medium, Hard};
}