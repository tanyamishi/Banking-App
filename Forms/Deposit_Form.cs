using Banking_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App.Forms
{
    public partial class Deposit_Form : Form
    {

        private Client client;
        private BankingApp bank;
        private const string PATH_TO_DATA = ".//clients.txt";

        public Deposit_Form(BankingApp _bank, Client _client)
        {
            InitializeComponent();
            client = _client;
            bank = _bank;
            
            categoryBox.Text = client.DepositCategory;
            sumUpDown.Value = client.Balance;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            client.DepositCategory = categoryBox.Text;
            client.DepositPercent = (int)percentUpDown.Value;
            client.Deposit(sumUpDown.Value);
            client.TerminDeposit = (int)terminUpDown.Value;
            MessageBox.Show("Успішно оновлено.");
            bank.SaveData(PATH_TO_DATA);
            Close();
        }
    }
}
