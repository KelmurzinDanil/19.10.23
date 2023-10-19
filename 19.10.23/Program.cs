using System;
using static _19._10._23.Class1;

namespace _19._10._23
{
    internal class Program
    {
        static uint NaturalNumber() // Проверка на натуральность
        {
            bool flag = true;
            uint number;
            do
            {
                Console.WriteLine("Введите натуральное целое число:");
                bool isNumber = uint.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести натуральное целое число");
                }
            }
            while (flag);

            return number;
        }
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
        static void Main(string[] args)
        {
            Console.WriteLine("7.1");
            Console.WriteLine("Введите номер счета:");
            uint number = NaturalNumber();
            Console.WriteLine("Введите баланс:");
            decimal balance = NaturalNumber();
            Console.WriteLine("Введите тип счета(current или saving):");
            string type = Console.ReadLine();
            if (type == "current")
            {
                BankAccount bankAccount = new BankAccount(number, balance, typeOfBankAccount.current);
                Console.WriteLine(bankAccount);
            }
            else if (type == "saving")
            {
                BankAccount bankAccount = new BankAccount(number, balance, typeOfBankAccount.saving);
                Console.WriteLine(bankAccount);
            }
            else { Console.WriteLine("Неверный ввод"); }

            Console.WriteLine("7.2");
            Random rnd = new Random();
            int randomValue = rnd.Next(10000, 99999);
            BankAccount_7_2.RandomAccountNumber = randomValue;
            Console.WriteLine("Введите баланс:");
            decimal balance2 = EnterNumber();
            Console.WriteLine("Введите тип счета(current или saving):");
            string type2 = Console.ReadLine();
            if (type2 == "current")
            {
                BankAccount_7_2 bankAccount2 = new BankAccount_7_2(balance2, typeOfBankAccount2.current);
                Console.WriteLine(bankAccount2);
            }
            else if (type2 == "saving")
            {
                BankAccount_7_2 bankAccount2 = new BankAccount_7_2(balance2, typeOfBankAccount2.saving);
                Console.WriteLine(bankAccount2);
            }
            else { Console.WriteLine("Неверный ввод"); }

            Console.WriteLine("7.3");
            Random rnd2 = new Random();
            int randomValue2 = rnd2.Next(10000, 99999);
            Bank_7_3.RandomAccountNumber = randomValue2;
            Random rnd3 = new Random();
            int balance3 = rnd3.Next(10000, 99999);
            Console.WriteLine("Введите тип счета(current или saving):");
            string type3 = Console.ReadLine();
            if (type3 == "current")
            {
                Bank_7_3 bankAccount3 = new Bank_7_3(balance3, typeOfBankAccount2.current);
                Console.WriteLine(bankAccount3);
            }
            else if (type3 == "saving")
            {
                Bank_7_3 bankAccount3 = new Bank_7_3(balance3, typeOfBankAccount2.saving);
                Console.WriteLine(bankAccount3);
            }
            else { Console.WriteLine("Неверный ввод"); }

            Bank_7_3.WindrawAndDeposit();

            Console.WriteLine("7.4");
            Console.WriteLine("Высота здания:");
            Building.GetHigh = NaturalNumber();
            Console.WriteLine("Этажность:");
            Building.GetLevel = NaturalNumber();
            Console.WriteLine("Количество квартир:");
            Building.GetNumberOfApartament = NaturalNumber();
            Console.WriteLine("Количество подъездов:");
            Building.GetEntrance = NaturalNumber();

            Building.WriteInfoBuilding();
            Console.WriteLine();
            Building building = new Building();
            Console.WriteLine(building.ToString());





            Console.ReadKey();
        }


    }
}
