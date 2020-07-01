using System;
using System.Collections.Generic;
using System.Linq;


namespace MyBank
{

    class Client
    {
        public readonly string id;
        private string _fullName;

        public readonly List<Accaunt> accaunts = new List<Accaunt>();


        public Client(string fullName, decimal money)
        {
            id = Guid.NewGuid().ToString();
            _fullName = fullName;
        }

        public void SetFullName (string fullName)
        {
            if (!string.IsNullOrEmpty(fullName))
            {
                _fullName = fullName;
            }
            else
            {
                Console.WriteLine("Не могу сменить имя");
            }
        }

        public void UpdateBalance(string id, decimal money)
            {
                Accaunt accaunt = accaunts.SingleOrDefault(a => a.id == id);
                accaunt.Balance += money;
            }

        public decimal GetBalance(string id)
        {
            Accaunt accaunt = accaunts.SingleOrDefault(a => a.id == id);
            return accaunt.Balance;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"ФИО: {_fullName}");

            foreach (var account in accaunts)
            {
                Console.WriteLine($"Счет: {account.id}, Валюта: {account.Type}, Баланс: {account.Balance} ");
            }
        }
   
    }
}
