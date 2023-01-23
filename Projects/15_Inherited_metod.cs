/* Данная вам программа определяет абстрактный класс Figure и выводит 
из него классы Rectangle и Triangle.
Добавьте абстрактный метод Perimeter к классу Figure, а затем переопределите 
его в производных классах для вычисления периметров уже созданных объектов 
Rectangle и Triangle.

Подсказка:
Периметр прямоугольника с шириной w и высотой h => 2*w+2*h.
Периметр треугольника со сторонами s1, s2, s3 => s1+s2+s3.

Абстрактный метод периметра внутри абстрактного класса Figure не должен иметь тела.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
      abstract class Figure {
        public abstract void Perimeter();
      }
      class Rectangle : Figure {
        public int width;
        public int height;
        public Rectangle(int width, int height) {
            this.width = width;
            this.height = height;
        }
        public override void Perimeter() {
            int P_rect = 2 * width + 2 * height;
            Console.WriteLine(P_rect);
        }
      }
      class Triangle : Figure {
        public int side1;
        public int side2;
        public int side3;
        public Triangle(int s1, int s2, int s3) {
            this.side1 = s1;
            this.side2 = s2;
            this.side3 = s3;
        }
        public override void Perimeter() {
            int P_tri = side1 + side2 + side3;
            Console.WriteLine(P_tri);
        }
      }
      static void Main(string[] args) {
        Figure rectangle = new Rectangle(5, 6);
        Figure triangle = new Triangle(4, 8, 3);
        rectangle.Perimeter();
        triangle.Perimeter();
      }
    }
}