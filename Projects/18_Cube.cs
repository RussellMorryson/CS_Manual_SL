/* Кубоид - это трехмерная фигура, имеющая длину, ширину и высоту.
Программа, которую вам дают, принимает эти измерения в качестве входных данных, 
определяет кубовидную структуру и создает ее объект.
Завершите программу, создав конструктор, который примет длину, ширину и высоту в 
качестве параметров и назначит их своим элементам структуры.
Также заполните методы Volume() и Perimeter() внутри структуры, чтобы вычислить и 
вернуть их, чтобы вызовы данных методов работали корректно.

Sample Input
5
4
5

Sample Output
Volume: 100
Perimeter: 56

Cuboid volume: length * width * height.
Cuboid perimeter: 4 * (length + width + height).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Cuboid c;
            c.length = length;
            c.width = width;
            c. height = height;  
            Console.WriteLine("Volume: " + c.Volume());
            Console.WriteLine("Perimeter: " + c.Perimeter());
        }    
        struct Cuboid {
            public int length;
            public int width;
            public int height;
            public void cuboid(int length, int width, int height) {
                this.length = length;
                this.width = width;
                this.height = height;                
            }
            public int Volume() {
                int vol = length * width * height;
                return vol;
            }        
            public int Perimeter() {
                int per = 4 * (length + width + height);
                return per;
            }
        }
    }
}