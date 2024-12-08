using System;


public class BankAccount
{
    // Private fields
    private string _accountHolderName;
    private decimal _balance;

    // Constructor to initialize the account
    public BankAccount(string accountHolderName, decimal balance)
    {
        _accountHolderName = accountHolderName;
        _balance = balance;
    }

    // Public property to get and set the account holder's name
    public string AccountHolderName
    {
        get { return _accountHolderName; }
        set {
            if (!string.IsNullOrEmpty(value))
            {
                _accountHolderName = value;
            }
            else
            {
                throw new ArgumentException("Account holdername cannot be empty");
            }
        }
    }

    // Public method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited:{amount:C}. New balance{_balance:C}");
        }
    }

    // Public method to withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. Remaining Balance: {_balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount.");
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }

}

