using System;

namespace Theme_auction
{
    abstract class Auction
    {
        public static int PlayersTom() // Игрок Tom
        {
            Random random = new Random();
            int rndTom = random.Next(100, 500);
            return rndTom;
        }
        public static int PlayersBob() // Игрок Bob
        {
            Random random = new Random();
            int rndBob = random.Next(70, 700);
            return rndBob;
        }
        public static int PlayersDen() // Игрок Den
        {
            Random random = new Random();
            int rndDen = random.Next(400, 870);
            return rndDen;
        }
        public static int InitialPrice() // Начальная цена
        {            
            Random rnd = new Random();
            int initialPrice = rnd.Next(1000, 2000);
            return initialPrice;
        }
        public static string CastThingsAuction() // Вещи аукциона
        {
            string[] things = new string[3];
            things[0] = "Сундук";
            things[1] = "Склад";
            things[2] = "Картину";
            Random rnd = new Random();
            return things[rnd.Next(0, 2)];
        }
        public static int RandomAddBet() // Добавление к ставке
        {
            Random rnd = new Random();
            int randomAddBet = rnd.Next(100, 300);
            return randomAddBet;
        }
    }
}
