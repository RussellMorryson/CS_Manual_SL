/* Вы создаете приложение для рисования, и в настоящее время у вас 
есть только 1 инструмент - карандаш. Вы хотите добавить кисть и 
спрей на панель инструментов рисования.

Данная вам программа объявляет интерфейс iDraw с помощью метода 
StartDraw() и класса Draw, который выполняет рисование карандашом, 
реализуя интерфейс iDraw. Он выводит "С помощью карандаша".
Завершите данные классы кистей и распылителей, выполнив
- наследование их от класса Draw
- реализация метода StartDraw() для каждого инструмента, чтобы вывести

"Using brush" for Brush, or
"Using spray" for Spray.

Объекты рисования и вызовы их методов предоставляются в Main().
Не забывайте о ключевом слове override.
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge {
    class Program {
        static void Main(string[] args) {
            IDraw pencil = new Draw();
            IDraw brush = new Brush();
            IDraw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();
        }
        public interface IDraw {
            void StartDraw();
        }
        class Draw : IDraw {
            public void StartDraw() {
                Console.WriteLine("Using pencil");
            }
        }    
        class Brush : IDraw {
            public void StartDraw() {
                Console.WriteLine("Using brush");
            }
        }
        class Spray : IDraw {
            public void StartDraw() {
                Console.WriteLine("Using spray");
            }   
        }
    }    
}