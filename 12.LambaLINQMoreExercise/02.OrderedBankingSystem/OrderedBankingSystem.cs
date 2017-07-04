using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            var bankAndAccount = new Dictionary<string, Dictionary<string, decimal>>();

            while (!inputLine.Equals("end"))
            {
                if (inputLine.Length > 1)
                {
                    var inputParams = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    var bank = inputParams[0];
                    var account = inputParams[1];
                    var balance = decimal.Parse(inputParams[2]);

                    if (!bankAndAccount.ContainsKey(bank))
                    {
                        bankAndAccount[bank] = new Dictionary<string, decimal>();
                    }
                    if (!bankAndAccount[bank].ContainsKey(account))
                    {
                        bankAndAccount[bank][account] = 0m;
                    }
                    bankAndAccount[bank][account] += balance;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var bank in bankAndAccount
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Max()))
            {
                foreach (var account in bank.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }
        }
    }
}