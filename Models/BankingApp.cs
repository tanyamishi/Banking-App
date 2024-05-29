using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Banking_App.Models
{
    public class BankingApp
    {
        public BankingApp() {
            Clients = new List<Client>();
            FillWithTestData(100);
        }

        public List<Client> Clients { get; set; }
        public DateTime LastInterestCalculation { get; set; }
        public void FillWithTestData(int n)
        {
            Clients.Clear();
            for (int i = 1; i <= n; i++)
            {
                Clients.Add(new Client
                {
                    Id = i,
                    Name = $"Name{i}",
                    RNOKPP = i,
                    PassportNum = $"PS{i}",
                    Balance = 0,
                    DepositCategory = "None",
                    LastOperation = default,
                });
            }
        }
        public void AddNewClient(Client client)
        {
            Clients.Add(client);

        }

        public List<Client> Search(string name, string id, string passport, string rno)
        {
            var result = new List<Client>();

            foreach (var b in Clients)
            {
                if (b.Name.Contains(name) &&
                    b.PassportNum.Contains(passport) &&
                    b.Id.ToString().Contains(id) &&
                    b.RNOKPP.ToString().Contains(rno))
                {
                    result.Add(b);
                }
            }
            return result;
        }

        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);
        }

        public BankingApp LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<BankingApp>(jsonString);
        }

        public void ApplyDailyInterest()
        {
            foreach (var client in Clients)
            {
                if (client.DepositCategory != "None")
                {
                    decimal dailyInterestRate = client.DepositPercent / 100m / 365; 
                    client.Balance += client.Balance * dailyInterestRate;
                    client.LastOperation = DateTime.Now;
                }
            }
            LastInterestCalculation = DateTime.Now;
        }

        public void ApplyInterestForDays(int days)
        {
            foreach (var client in Clients)
            {
                if (client.DepositCategory != "None")
                {
                    decimal dailyInterestRate = client.DepositPercent / 100m / 365;
                    client.Balance += client.Balance * dailyInterestRate * days;
                    client.LastOperation = DateTime.Now;
                }
            }
        }
    }
}
