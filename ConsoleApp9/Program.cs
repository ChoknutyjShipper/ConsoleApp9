using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");

            double depositAmount;
            while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount < 0)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное число.");
                Console.WriteLine("Введите сумму вклада:");
            }

            double interestRate;
            if (depositAmount < 100)
            {
                interestRate = 0.05; // 5%
            }
            else if (depositAmount >= 100 && depositAmount <= 200)
            {
                interestRate = 0.07; // 7%
            }
            else
            {
                interestRate = 0.10; // 10%
            }

            double interestAmount = depositAmount * interestRate;
            double totalAmount = depositAmount + interestAmount;

            Console.WriteLine($"Сумма вклада: {depositAmount:C}");
            Console.WriteLine($"Начисленные проценты: {interestAmount:C}");
            Console.WriteLine($"Итоговая сумма: {totalAmount:C}");
            Console.ReadLine();
        }
    }
}

