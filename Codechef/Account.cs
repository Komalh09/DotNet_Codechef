using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef
{
    class AccountBlockedException : Exception
    {
        public string TransactionType { get; }

        public AccountBlockedException(string name, string transactionType)
            : base(name)
        {
            TransactionType = transactionType;
        }
    }

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message)
            : base(message)
        {
        }
    }

    internal class Account
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool IsBlocked { get; set; }

        // Properties to store the last credited and debited amounts
        public int LastCreditedAmount { get; private set; }
        public int LastDebitedAmount { get; private set; }

        public Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
            IsBlocked = false;
            LastCreditedAmount = 200;
            LastDebitedAmount =200;
        }

        public void Credit(int amount)
        {
            if (IsBlocked)
            {
                throw new AccountBlockedException(Name, "Credit");
            }
            Balance += amount;
            LastCreditedAmount = amount;
        }

        public void Debit(int amount)
        {
            if (IsBlocked)
            {
                throw new AccountBlockedException(Name, "Debit");
            }
            if (Balance - amount < 1000)
            {
                throw new InsufficientBalanceException($"Insufficient balance after debit. Current balance: {Balance}");
            }
            Balance -= amount;
            LastDebitedAmount = amount;
        }
    }

    class BankExceptionExample
    {
        static void BlockAccount(Account account)
        {
            account.IsBlocked = true;
        }

        static void TransferFund(int amount, Account accountToDebit, Account accountToCredit)
        {
            Console.WriteLine("Initiating Transaction");
            try
            {
                Console.WriteLine($"Will debit account {accountToDebit.Name} for the sum of {amount}...\n");
                accountToDebit.Debit(amount);

                Console.WriteLine($"Will credit account {accountToCredit.Name} for the sum of {amount}...\n");
                accountToCredit.Credit(amount);

                Console.WriteLine("Transfer fund Transaction Completed");
            }
            catch (AccountBlockedException ex)
            {
                Console.WriteLine("Oh no! Something Went Wrong.");
                Console.WriteLine("Account name: " + ex.Message);
                Console.WriteLine("Transaction Type: " + ex.TransactionType);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Oh no! Something Went Wrong.");
                Console.WriteLine(ex.Message);
            }
        }

        public static void TestAccountBlocked()
        {
            var accountToDebit = new Account("Riya Jadhav", 1100);
            var accountToCredit = new Account("Riya A Jadhav", 900);
            //BlockAccount(accountToCredit);
            TransferFund(200, accountToDebit, accountToCredit);
            Console.WriteLine($"Debited {accountToDebit.LastDebitedAmount} from account {accountToDebit.Name}");
            Console.WriteLine($"Credited {accountToCredit.LastCreditedAmount} to account {accountToCredit.Name}");

        }
        static void Main(string[] args)
        {
            BankExceptionExample.TestAccountBlocked();
        }
    }
}