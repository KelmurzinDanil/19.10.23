using System;
using static _19._10._23.Class1;

namespace _19._10._23
{
    internal class Bank_7_3
    {
        static decimal EnterNumber() // Проверка на число
        {
            bool flag = true;
            decimal number;
            do
            {
                Console.WriteLine("Введите число:");
                bool isNumber = decimal.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести число");
                }
            }
            while (flag);

            return number;
        }
        public Bank_7_3(decimal balans, typeOfBankAccount2 type)
        {
            Balans = balans;
            Type = type;
        }
        public static int RandomAccountNumber
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }
        public static void WindrawAndDeposit() // Снять или положить на счет 
        {
            Console.WriteLine("Вы хотите снять или положить на счет(введите 'снять' или 'положить'");
            string w_And_d = Console.ReadLine();
            if (w_And_d == "снять")
            {
                Console.WriteLine("Какую сумму вы хотите снять?");
                decimal sum = EnterNumber();
                if (sum > Bank_7_3.Balans)
                {
                    Console.WriteLine($"У вас на счете только {Bank_7_3.Balans}, вы не можете снять {sum}.");
                }
                else
                {
                    Console.WriteLine($"AccountNumber - {Bank_7_3.AccountNumber}, Balans - {Bank_7_3.Balans - sum}, Type - {Bank_7_3.Type}");
                }
            }
            else if (w_And_d == "положить")
            {
                Console.WriteLine("Какую сумму вы хотите положить?");
                decimal sum = EnterNumber();
                Console.WriteLine($"AccountNumber - {Bank_7_3.AccountNumber}, Balans - {Bank_7_3.Balans + sum}, Type - {Bank_7_3.Type}");
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }

        }
        private static int AccountNumber { get; set; }
        private static decimal Balans { get; set; }
        private static typeOfBankAccount2 Type { get; set; }
        public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {Balans}, Type - {Type}";
    }
}
