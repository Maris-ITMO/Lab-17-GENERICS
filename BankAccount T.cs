using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_СамРабота_Обобщенные_типы_GENERICS
{
    public class BankAccount<T>
    {
        private T accountNumber;
        private decimal balance;
        private string ownerName;

        public T AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public BankAccount(T accountNumber, decimal balance, string ownerName)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            OwnerName = ownerName;
        }
    }
}