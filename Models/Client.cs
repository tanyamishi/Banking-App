using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RNOKPP {  get; set; }
        public string PassportNum {  get; set; }
        public decimal Balance { get; set; }
        public string DepositCategory { get; set; } = "None";
        public DateTime LastOperation { get; set; } = DateTime.Now;
        public int TerminDeposit {  get; set; }
        
        public int DepositPercent {  get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            LastOperation = DateTime.Now;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            LastOperation = DateTime.Now;
        }
    }
}
