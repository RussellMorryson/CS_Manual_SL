//Это пример того, как наследуются классы:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
    class Program {
        class Animal {
            public int Legs {get; set;}
            public int Age {get; set;}
            public string Name {get; set;}
        }
        class Dog : Animal {
            public Dog() {
                Legs = 4;
            }
            public void Bark() {
                Console.WriteLine("Woof");
            }
        }
        class Elefant : Animal {
            public Elefant() {
                Name = "Gigant";
                Legs = 4;
                Age = 10;
            }            
            public void Bark() {
                Console.WriteLine("Tooooooo");                
            }            
        }

        static void Main(string[] args) {
            Dog d = new Dog();
            Console.WriteLine(d.Legs);            
            d.Bark();

            Elefant e = new Elefant();
            Console.WriteLine(e.Age);
            Console.WriteLine(e.Legs);
            Console.WriteLine(e.Name);
            e.Bark();
        }
    }
}