/* Класс Elems создает массив целых чисел размером 3, определяет 
методы Add() и Show() для хранения элементов в массиве и 
показывает их через пробел.
Измените класс, чтобы сделать его универсальным для выполнения 
тех же действий со строковым типом, заданным в основной функции.

Вам нужно заменить тип int на общий тип <T>.
Каждый вывод должен заканчиваться пробелом (включая последний).
*/

using System;
using System.Collections.Generic;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            Elems<string> elems1 = new Elems<string>();
            elems1.Add("John", "Tamara", "David");
            elems1.Show();

            Console.WriteLine();

            Elems<int> elems2 = new Elems<int>();
            elems2.Add(5, 14, 13);
            elems2.Show();

        }
    }
    class Elems<T> {
        T[] elements = new T[3];
        public void Add(T elem1, T elem2, T elem3) {
            elements[0] = elem1;
            elements[1] = elem2;
            elements[2] = elem3;
        }
        public void Show() {
            foreach (T item in elements) {
                Console.Write(item + " ");
            }
        }
    }
}