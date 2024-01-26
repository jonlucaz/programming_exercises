using Ex15.Entities;

BusinessAccount account = new BusinessAccount(8010, "Alex", 100.0, 500.0);

account.WithDraw(20.0);

Console.WriteLine(account.Balance);