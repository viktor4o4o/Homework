using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,decimal>> bankAndAccounts = new Dictionary<string, Dictionary<string, decimal>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string bankName = inputParams[0];
                string bankAccountName = inputParams[1];
                decimal bankAccountValue = decimal.Parse(inputParams[2]);

                if(!bankAndAccounts.ContainsKey(bankName))
                {
                    bankAndAccounts.Add(bankName, new Dictionary<string, decimal>());
                }
                if (!bankAndAccounts[bankName].ContainsKey(bankAccountName))
                {
                    bankAndAccounts[bankName].Add(bankAccountName, 0);
                }
                bankAndAccounts[bankName][bankAccountName] += bankAccountValue;
            }

            foreach (var bank in bankAndAccounts.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
            .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine("{1} -> {2} ({0})", bank.Key, account.Key, account.Value);
                }
            }

            //bankAndAccounts
            //    .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
            //    .ThenByDescending(bank => bank.Value.Max(account => account.Value))
            //    .ToList()
            //    .ForEach(bank => bank.Value
            //        .OrderByDescending(account => account.Value)
            //        .ToList()
            //        .ForEach(account => Console.WriteLine("{0} -> {1} ({2})",
            //        account.Key,
            //        account.Value,
            //        bank.Key)
            //        ));
        }
    }
}
