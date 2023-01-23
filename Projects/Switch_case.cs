using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num) {
                case 1: Console.WriteLine("Easy");
                    break;
                case 2: Console.WriteLine("Medium");
                    break;
                case 3: Console.WriteLine("Hard");
                    break;
                default: Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}