namespace _19._10._23
{
    public enum typeOfBankAccount { saving = 1, current = 2 }
    internal class BankAccount
    {
        public BankAccount(uint accountNumber, decimal balans, typeOfBankAccount type)
        {
            AccountNumber = accountNumber;
            Balans = balans;
            Type = type;
        }
        private uint AccountNumber { get; set; }
        private decimal Balans { get; set; }
        private typeOfBankAccount Type { get; set; }
        public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {Balans}, Type - {Type}"; // Переопрделение класса


    }
}
