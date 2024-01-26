namespace Ex15.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }


        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 10.0;
        }


        public void Loan(double amount)
        {
            if (amount < LoanLimit)
            {
                Balance += amount - 10;
            }
        }
    }
}
