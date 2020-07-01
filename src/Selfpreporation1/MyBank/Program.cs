using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank ();
            bank.Notify += ShowMessage;

            var client = new Client("Nick", 98.01M);

            var accountBYN = new Accaunt
            {
                id = Guid.NewGuid().ToString(),
                Type = MoneyType.BYN,
                Balance = 100.25M
            };

            var accountUSD = new Accaunt
            {
                id = Guid.NewGuid().ToString(),
                Type = MoneyType.USD,
                Balance = 0.15M
            };
            var accountRUB = new Accaunt
            {
                id = Guid.NewGuid().ToString(),
                Type = MoneyType.RUB,
                Balance = 4000.50M
            };

            client.accaunts.Add(accountBYN);
            client.accaunts.Add(accountUSD);
            client.accaunts.Add(accountRUB);

            bank.AddNewClient(client);
            bank.GetClientInfo(client.id);
            Console.WriteLine();
            bank.Exchange(accountBYN, accountUSD, accountRUB, MoneyType.BYN, 98);
            bank.GetClientInfo(client.id);
            Console.WriteLine();
            //bank.GetClientInfo(client.id);
            //bank.AddNewClient(client);
            //bank.GetClientInfo(client.id);
            //bank.TakeOut(client.id, 98.02M);
            //bank.TakeOut(client.id, 42M);
            //bank.GetClientInfo(client.id); 
            Console.ReadKey();
        }

        private static void ShowMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
