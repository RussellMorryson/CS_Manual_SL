using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        class Main_program {
            static void Main(string[] args) {
                double num1 = Convert.ToDouble(Console.ReadLine());
                double num2 = Convert.ToDouble(Console.ReadLine());
                Avg a1 = new Avg(num1, num2);     
                Console.WriteLine(Avg.srednee);       
            }
        }
        class Avg {        
            public static double srednee = 0;
            public Avg(double num_1, double num_2) {
                srednee = (num_1 + num_2)/2;                
            }
        }
    }
}