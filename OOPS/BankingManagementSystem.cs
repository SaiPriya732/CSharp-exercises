// using System;

// abstract class Account
// {
//     public int AccountNumber { get; set; }
//     public string CustomerName { get; set; }

//     protected double Balance;

//     public Account(int accountNumber, string customerName, double balance)
//     {
//         AccountNumber = accountNumber;
//         CustomerName = customerName;
//         Balance = balance;
//     }

//     public void Deposit(double amount)
//     {
//         Balance += amount;
//     }

//     public virtual void Withdraw(double amount)
//     {
//         if (amount <= Balance)
//         {
//             Balance -= amount;
//         }
//         else
//         {
//             Console.WriteLine("Insufficient Balance");
//         }
//     }

//     public abstract void CalculateInterest();

//     public virtual void DisplayDetails()
//     {
//         Console.WriteLine($"Account: {AccountNumber}");
//         Console.WriteLine($"Customer: {CustomerName}");
//         Console.WriteLine($"Balance: {Balance}");
//     }
// }

// class SavingsAccount : Account
// {
//     public SavingsAccount(int accountNumber, string customerName, double balance)
//         : base(accountNumber, customerName, balance)
//     {
//     }

//     public override void Withdraw(double amount)
//     {
//         if (amount <= Balance)
//         {
//             Balance -= amount;
//         }
//         else
//         {
//             Console.WriteLine("Insufficient Balance");
//         }
//     }

//     public override void CalculateInterest()
//     {
//         double interest = Balance * 0.05;
//         Balance += interest;

//         Console.WriteLine($"Interest Added: {interest}");
//     }
// }

// class CurrentAccount : Account
// {
//     public CurrentAccount(int accountNumber, string customerName, double balance)
//         : base(accountNumber, customerName, balance)
//     {
//     }

//     public override void Withdraw(double amount)
//     {
//         if (Balance - amount >= 1000)
//         {
//             Balance -= amount;
//         }
//         else
//         {
//             Console.WriteLine("Minimum balance of 1000 must be maintained");
//         }
//     }

//     public override void CalculateInterest()
//     {
//         Console.WriteLine("No Interest for Current Account");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Account account = new SavingsAccount(
//             1001,
//             "Sai",
//             50000);

//         account.DisplayDetails();

//         account.CalculateInterest();

//         Console.WriteLine($"Updated Balance: 52500");
//     }
// }