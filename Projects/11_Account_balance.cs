/* Предоставленная вам программа принимает в качестве входных данных номер счета и его баланс.
Он определяет класс учетной записи с балансом 1 участника и выводит из него 
класс пользователя с 1 дополнительным участником - номером учетной записи, 
затем создает объект user и пытается сохранить в нем баланс и номер учетной 
записи и показывает детали. Но что-то здесь не так.
Исправьте программу так, чтобы она завершала конструктор User(), который 
должен присваивать параметры соответствующим членам класса User.
Также проверьте модификатор доступа члена баланса класса Account.
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
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();

        }
    }

    class Account {
        protected double Balance {get; set;}
        protected string AccNumber {get; set;}
    }
    class User : Account {     
        public User(string accNumber, double balance) {
            AccNumber = accNumber;
            Balance = balance;
        }
        public void ShowDetails() {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}