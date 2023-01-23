/* Данная вам программа принимает марку и модель автомобиля в качестве входных 
данных и определяет класс транспортного средства с помощью свойства model 
и метода ShowModel().
Заполните класс Car, чтобы наследовать класс Vehicle, и добавьте свойство 
Model и метод ShowModel(), чтобы данный вызов метода объекта car работал 
правильно (см. Пример вывода).

Sample Input
BMW
5 Series

Sample Output
Brand: BMW
Model: 5 Series

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
        }
    }
    class Vehicle {
        public string Brand { get; set; }
        public void ShowBrand() {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    class Car : Vehicle {
        public string Model { get; set; }
        public void ShowModel() {
            Console.WriteLine("Model: " + Model);
        }
    }
}