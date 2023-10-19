using System;
using System.Reflection.Emit;

namespace Theme_auction
{
    internal class CloseAuction : Auction
    {
        private static int Tom;
        private static int Bob;
        private static int Den;
        private static uint Your;
        public CloseAuction()
        {
            Tom = PlayersTom();
            Bob = PlayersBob();
            Den = PlayersDen();
            Your = YourPrice();
        }
        public static uint YourPrice()
        {
            uint yourPrice = NaturalNumber();
            return yourPrice;
        }
        public void CountPrice()
        {
            int t = InitialPrice() + Tom;
            int b = InitialPrice() + Bob;
            int d = InitialPrice() + Den;          
            if (Your > t && Your > b && Your > d)
            {
                Console.WriteLine($"Продано вам за {Your}");
            }
            else
            {
                Console.WriteLine($"Продано за {Math.Max(Math.Max(t, b), d)}$");
            }
            Console.ReadKey();
        }
        static uint NaturalNumber() // Проверка на натуральность
        {
            bool flag = true;
            uint number;
            do
            {
                Console.WriteLine("Введите вашу ставку:");
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
    }
}
