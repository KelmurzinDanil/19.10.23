namespace _19._10._23
{
    internal class Class1
    {
        public enum typeOfBankAccount2 { saving = 1, current = 2 }
        internal class BankAccount_7_2
        {
            public BankAccount_7_2(decimal balans, typeOfBankAccount2 type)
            {
                Balans = balans;
                Type = type;
            }
            public static int RandomAccountNumber
            {
                get { return AccountNumber; }
                set { AccountNumber = value; }
            }
            private static int AccountNumber { get; set; }
            private decimal Balans { get; set; }
            private typeOfBankAccount2 Type { get; set; }
            public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {Balans}, Type - {Type}"; // Переопрделение класса


        }
    }
}
