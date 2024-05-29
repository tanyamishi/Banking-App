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
    public partial class Withdraw_Form : Form
    {
        private Client client;
        private BankingApp bank;
        private const string PATH_TO_DATA = ".//clients.txt";
        public Withdraw_Form(BankingApp _bank, Client _client)
        {
            InitializeComponent();
            bank = _bank;
            client = _client;
        }

        private void withdrawSaveButton_Click(object sender, EventArgs e)
        {
            if (withdrawSumUpDown.Value > client.Balance)
            {
                MessageBox.Show("Недостатньо грошей на рахунку.");
            }
            else
            {
                client.Withdraw(withdrawSumUpDown.Value);
                bank.SaveData(PATH_TO_DATA);
                MessageBox.Show("Гроші знято.");
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
