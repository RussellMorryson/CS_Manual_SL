/* На сайте автосалона вы можете предварительно заказать автомобиль, указав 
его цвет и комплектацию.
Данная вам программа принимает цвет и тип оборудования в качестве входных
 данных и передает их конструктору уже объявленного класса автомобиля.
Реализуйте интерфейсы iColor и IEquipment для класса Car и переопределите 
их методы getColor и GetEquipment внутри него. Каждый из них должен вывести 
соответствующее сообщение о цвете/оборудовании (см. Пример вывода).

Sample Input
Blue
Standard

Sample Output
Color: Blue
Equipment: Standard

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();
        }
    }

    public interface IColor {
        void GetColor();        
    }

    public interface IEquipment {
        void GetEquipment();
    }
    public class Car {
        public string color;
        public string equipment;

        public Car(string color, string equipment) {
            this.color = color;
            this.equipment = equipment;
        }
        public void GetColor() {
            Console.WriteLine($"Color: {color}");
        }
        public void GetEquipment() {
            Console.WriteLine($"Equipment: {equipment}" );
        }
    }
}