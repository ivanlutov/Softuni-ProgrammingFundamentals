using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var bankAccountList = new List<BankAccount>();

            while (input != "end")
            {
                var currentAccount = ReadBankAccount(input);

                bankAccountList.Add(currentAccount);
                input = Console.ReadLine();
            }

            foreach (BankAccount bankAccount in bankAccountList.OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
            }
        }

        public static BankAccount ReadBankAccount(string inputToString)
        {
            var bankAccountToString = inputToString.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var bank = bankAccountToString[0];
            var accountName = bankAccountToString[1];
            var accountBalance = decimal.Parse(bankAccountToString[2]);

            var bankAccount = new BankAccount
            {
                Name = accountName,
                Bank = bank,
                Balance = accountBalance
            };

            return bankAccount;
        }
    }

    public class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }
}