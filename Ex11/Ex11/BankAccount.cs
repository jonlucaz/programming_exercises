using System.Globalization;

namespace Ex11
{
    internal class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public BankAccount(int number, string holder, double balance) : this(number, holder)
        {
            Balance = balance;
        }

        public double Deposit (double amount)
        {
            return Balance += amount;
        }

        public double WithDraw (double amount)
        {
            return Balance -= amount + 5;
        }

        public override string ToString()
        {
            return "Account: "
                + Number
                + ", Holder: "
                + Holder
                + ", Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
