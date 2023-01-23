using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program  {
        static void Main(string[] args)  {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };
            int winner = Convert.ToInt32(Console.ReadLine());
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }
    class FinalRound    {
        public FinalRound(string[] finalists, int winner) {       // сформирован конструктор  
            //complete the constructor
            Console.WriteLine($"Winner is {finalists[winner]}");
        }
        ~FinalRound() { // сформирован деструктор закрывающий класс после вывода сообщения      
            Console.WriteLine("Game Over");
        }
    }
}