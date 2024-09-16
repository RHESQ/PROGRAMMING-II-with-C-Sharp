using System;

class BankAccount
{
    private string accountNumber;
    private double balance;

    public BankAccount (string accountNumber)
    {
        this.accountNumber = accountNumber;
        balance = 0.00;

    }

    public void Deposit(double amount)
    {
        while (amount == 0)
        {
            Console.WriteLine("Failed Transaction. Deposit amount more than zero(0)");
        return;
        }

        balance += amount;
        Console.WriteLine("An amount of GHC {0}.has been deposited successfully. You have a current balance of GHC {1}.", amount, balance);

    }

    public void Withdraw (double amount)
    {
        while(amount == 0)
        {
            Console.WriteLine("You can't withdraw {0}.", amount);
            return;
        }

        while (amount > balance)
        {
            Console.WriteLine("Your balance is {0} you can't redraw an an amount more than {0}.", balance);
        }

        balance -= amount;
        Console.WriteLine("Withdrawal of GHC {0} has been made. New balance is {1}.", amount, balance);
    }

    public double GetBalance()
    {
        return balance;
    }

    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("1234567890");
        Console.WriteLine("Initial balance: GHC" + account.GetBalance());

        account.Deposit(100);
        account.Withdraw(0);
        Console.WriteLine("Current balance: GHC {0}", account.GetBalance());

    }
}

