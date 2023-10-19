using System;

namespace Theme_auction
{
    internal class OpenAuction : Auction
    {
        public OpenAuction() { }
        public void CountPrice() // Аукцион
        {
            Console.WriteLine("Начальная цена:" + InitialPrice() + "$ за " + CastThingsAuction());
            int t = InitialPrice() + PlayersTom();
            int b = InitialPrice() + PlayersBob();
            int d = InitialPrice() + PlayersDen();
            Console.WriteLine($"Ставки игрков: Tom - {t}, Bob - {b}, Den - {d}");
            Console.WriteLine("Ведущий: Кто даст больше?");
            Console.WriteLine("Напишите вашу цену или, если ничего не хотите ставить,\n то напишите '0'");
            int yourPrice = EnterNumber();
            if (yourPrice > t && yourPrice > b && yourPrice > d)
            {
                Console.WriteLine($"Ведущий: Новая ставка {yourPrice}! Кто даст больше?");
                int randomAddBet = yourPrice + RandomAddBet();
                Console.WriteLine("Игрок Bob: " + (randomAddBet) + "$");
                Console.WriteLine($"Ведущий: Новая ставка {randomAddBet}! Кто даст больше?");
                Console.WriteLine("Напишите вашу цену или, если ничего не хотите ставить,\n то напишите '0'");
                int yourPrice2 = EnterNumber();
                int i = 5;
                if (yourPrice2 > randomAddBet)
                {
                    while (i > 0)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine($" Ставка {yourPrice2}$ {i}");
                        i--;
                    }
                    Console.WriteLine("Продано за " + yourPrice2);

                }
                else
                {
                    Console.WriteLine($"Продано Bob за {randomAddBet}$");
                }
            }
            else
            {
                Console.WriteLine($"Продано за {Math.Max(Math.Max(t, b), d)}$");
            }
            

            int EnterNumber() // Проверка на число
            {
                bool flag = true;
                int number;
                do
                {
                    Console.WriteLine("Введите натуральное целое число:");
                    bool isNumber = int.TryParse(Console.ReadLine(), out number);
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

            Console.ReadKey();
        }
    }
}
