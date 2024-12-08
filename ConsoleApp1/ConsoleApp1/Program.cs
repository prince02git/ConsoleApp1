using System;

class Constructor
{
    static void Main()
    {
        //constructor
        //Person person = new Person();
        //person.DisplayInfo();

        //Person person1 = new Person(28, "prince");
        //person1.DisplayInfo();

        ////chaining
        //Chaining chaining1 = new Chaining();
        //chaining1.DisplayInfo();

        //Chaining chaining2 = new Chaining("John", 83);
        //chaining2.DisplayInfo();

        //Access Specifier
        //SportsCar car = new SportsCar("Ferrari", 200, "Red");
        //car.DisplayInfo();
        //car.IncreaseSpeed();

        var account = new BankAccount("Prince", 500m);
        Console.WriteLine($"Account Holder: {account.AccountHolderName}");
        account.Deposit(200m);
        account.Withdraw(100m);
        account.Withdraw(700m);

        // Check balance
        Console.WriteLine($"Final Balance: {account.GetBalance():C}");

    }
}