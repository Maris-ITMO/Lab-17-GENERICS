using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_17_СамРабота_Обобщенные_типы_GENERICS
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> account1 = new BankAccount<int>(12345, 1000, "Иван Иванов");
            BankAccount<string> account2 = new BankAccount<string>("A56789", 2000, "Содр Сидоров");
            BankAccount<string> account3 = new BankAccount<string>("A56789", 2000, "Петр Петров");


            Console.WriteLine("Account 1");
            Console.WriteLine("Account Number: " + account1.AccountNumber);
            Console.WriteLine("Balance: " + account1.Balance);
            Console.WriteLine("Owner Name: " + account1.OwnerName);

            Console.WriteLine("Account 2");
            Console.WriteLine("Account Number: " + account2.AccountNumber);
            Console.WriteLine("Balance: " + account2.Balance);
            Console.WriteLine("Owner Name: " + account2.OwnerName);

            Console.WriteLine("Account 3");
            Console.WriteLine("Account Number: " + account3.AccountNumber);
            Console.WriteLine("Balance: " + account3.Balance);
            Console.WriteLine("Owner Name: " + account3.OwnerName);
                       
            Console.ReadKey();
        }
    }
}

