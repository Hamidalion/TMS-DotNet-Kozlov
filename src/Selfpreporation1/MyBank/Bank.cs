using System;
using System.Collections.Generic;
using System.Linq;



namespace MyBank
{
    class Bank
    {
        public delegate void BankHandler(string message);
        public event BankHandler Notify;

        
        private readonly IList<Client> clients = new List<Client>();

        public void PutIn(string accoundId, string clientId, decimal money)
        {
            Client client = clients.SingleOrDefault(c => c.id == clientId);
            if (client != null)
            {
                client.UpdateBalance(accoundId, money);
                Notify?.Invoke($"На сет поступило: {money}");
            }
            else
            {
                Notify?.Invoke("Клиент с данным ID не найден в системе");
            }
        }

        public void TakeOut(string accoundId, string clientId, decimal money)
        {
            Client client = clients.SingleOrDefault(c => c.id == accoundId);
            if (client != null)
            {
                decimal clientBalance = client.GetBalance(accoundId);
                if (clientBalance > money)
                {
                    client.UpdateBalance(accoundId, - money);
                    Notify?.Invoke($"Со счета была снята сумма: {money}");
                }
                else
                {
                    Notify?.Invoke("На счету не хвататет денежных средств");
                }
            }
        }

        public void AddNewClient(Client client)
        {
            clients.Add(client);
        }

        public void GetClientInfo(string id)
        {
            Client client = clients.SingleOrDefault(c => c.id == id);
            if (client != null)
            {
                client.GetInfo();
            }
            else
            {
                Notify?.Invoke("Клиент с данным ID не найден в системе");
            }
        }
        public void Exchange (Accaunt accBUN, Accaunt accUSD, Accaunt AccRUB, MoneyType type, decimal money)
        {
            switch (type)
            {
                case MoneyType.BYN:
                    {
                        accBUN.Balance -= money;
                        var m1 = Convert.ToDouble(money)/2.4;
                        accUSD.Balance += Convert.ToDecimal(m1); 
                    }
                    break;
                case MoneyType.USD:
                    {

                    }
                    break;
                case MoneyType.RUB:
                    {

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
