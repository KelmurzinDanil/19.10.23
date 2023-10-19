using System;

namespace _19._10._23
{
    internal class Building
    {
        private static uint id; // Хранит последний использованный номер здания
        public uint Id
        {
            get { return id; }
        }
        public Building()
        {
            id++;
        }
        private static uint High { get; set; }
        private static uint Level { get; set; }
        private static uint NumberOfApartament { get; set; }
        private static uint Entrance { get; set; }
        public static uint GetHigh
        {
            get { return High; }
            set { High = value; }
        }
        public static uint GetLevel
        {
            get { return Level; }
            set { Level = value; }
        }
        public static uint GetNumberOfApartament
        {
            get { return NumberOfApartament; }
            set { NumberOfApartament = value; }
        }
        public static uint GetEntrance
        {
            get { return Entrance; }
            set { Entrance = value; }
        }
        public Building(uint high, uint level, uint numberOfApartament, uint entrance)
        {
            High = high;
            Level = level;
            NumberOfApartament = numberOfApartament;
            Entrance = entrance;
        }
        public uint CalculateHighLevel() // Высота этажа
        {
            return High / Level;
        }
        public uint NumberOfApartamentsInEnrtance() // Количество квартир в подъезде
        {
            return NumberOfApartament / Entrance;
        }
        public uint NumberOfApartamentsInLevel() // Количество квартир на этаже
        {
            return (NumberOfApartament / Level) / Entrance;
        }
        public static void WriteInfoBuilding()
        {
            Console.WriteLine($"Номер здания - {id},\n Высота здания - {High},\n Этажность - {Level},\n Количество квартир - {NumberOfApartament},\n Количество подъездов - {Entrance}. ");
        }
        public override string ToString() => $" Высота этажа - {CalculateHighLevel()}, " +
                                             $" Количество квартир в подъезде - {NumberOfApartamentsInEnrtance()}" +
                                             $" Количество квартир на этаже - {NumberOfApartamentsInLevel()} ";


    }
}
