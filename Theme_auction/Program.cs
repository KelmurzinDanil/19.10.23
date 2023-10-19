using System;

namespace Theme_auction
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Какой аукцион вы выберете: открытый или закрытый?");
            Console.WriteLine("Введите в консоль открытый или закрытый");
            string typeAuction = (Console.ReadLine());
            typeAuction.ToLower();
            if (typeAuction == "открытый")
            {
                OpenAuction openAuction = new OpenAuction();
                openAuction.CountPrice();
            }
            else if(typeAuction == "закрытый")
            {
                Console.WriteLine("Вы не знаете ставки ваших конкурентов, получает розыгрыш аукциона тот, у кого самая большая ставка");
                Console.WriteLine("Разыгрываем " + Auction.CastThingsAuction());
                CloseAuction closeAuction = new CloseAuction();
                closeAuction.CountPrice();                
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
            
        }
    }
}
