using Ex11;

BankAccount acc;

Console.Write("Enter account number: ");
int accountNumber = int.Parse(Console.ReadLine());
Console.Write("Enter account holder: ");
string accountName = Console.ReadLine();
Console.Write("Is there init deposit? (s/n) ");
char answerDeposit = char.Parse(Console.ReadLine());

if(answerDeposit == 's')
{
    Console.Write("Enter value to deposit: ");
    double initialDeposit = double.Parse(Console.ReadLine());

    acc = new BankAccount(accountNumber, accountName, initialDeposit);
}
else
{
    acc = new BankAccount(accountNumber, accountName);
}
Console.WriteLine("Account data: ");
Console.WriteLine(acc);

Console.WriteLine();
Console.Write("Enter a value to deposit: ");
double deposit = double.Parse(Console.ReadLine());
acc.Deposit(deposit);

Console.WriteLine();
Console.WriteLine("Updated data: ");
Console.WriteLine(acc);


Console.WriteLine();
Console.Write("Enter a value to withdraw: ");
double withDraw = double.Parse(Console.ReadLine());
acc.WithDraw(withDraw);


Console.WriteLine();
Console.WriteLine("Updated data: ");
Console.WriteLine(acc);






























/*
 * Exercise description
In a bank, to register a bank account, you must provide the account number, the name of the
account holder, and the initial deposit amount that the holder deposited when opening the account.
This deposit amount initial deposit, however, is optional, that is: if the holder does not have money 
to deposit at the time of opening his account, the initial deposit will not be made and the initial 
account balance will naturally be zero.
Important: Once a bank account has been opened, the account number can never be changed. Already
the name of the holder can be changed (as a person can change their name upon marriage, for example).
Finally, the account balance cannot be changed freely. There needs to be a mechanism to protect that. 
The balance only increases through deposits, and only decreases through withdrawals. 
For each withdrawal carried out, the bank charges a fee of $5.00. 
Note: the account may have a negative balance if the balance is not enough to make the withdrawal and/or pay the fee.
You must create a program that registers an account, giving you the option to be registered or not.
informed of the initial deposit amount. Then, make a deposit and then a withdrawal, always showing account 
data after each operation.
*/