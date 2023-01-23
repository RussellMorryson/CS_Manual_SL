/* Вам нужно написать программу для игры, чтобы сортировать оценки игроков.
Данная вам программа принимает в качестве входных данных число N, которое 
представляет количество игроков, и определяет список результатов.
Завершите программу, чтобы принять N чисел (баллов) в качестве входных 
данных, сохранить их в списке баллов, отсортировать и вывести их, разделив 
каждое пробелом.

Sample Input
3
12
4
5

Sample Output
4 5 12

Вам нужно выполнить метод Add() внутри цикла while.
*/

using System;
using System.Collections.Generic;

namespace SoloLearn {
    class Program {
        static void Main(string[] args) {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());
            List<int> scores = new List<int>();
            int count = 0;
            while (count<numOfPlayers) {
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score); 
                count++;
            }
            scores.Sort();
            for (int i = 0; i < count; i++) {
                Console.WriteLine(scores[i] + " ");
            }
        }
    }
}