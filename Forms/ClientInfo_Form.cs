using Banking_App.Forms;
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

namespace Banking_App
{
    public partial class ClientInfo_Form : Form
    {
        private Client client;
        BankingApp bank ;
        public ClientInfo_Form(BankingApp _bank, Client _client)
        {
            InitializeComponent();

            client = _client;
            bank = _bank;
            UpdateClientInfo();
        }
        private void UpdateClientInfo()
        {
            idBoxInf.Text = client.Id.ToString();
            nameBoxInf.Text = client.Name;
            rnoBoxInf.Text = client.RNOKPP.ToString();
            passportBoxInf.Text = client.PassportNum.ToString();
            balanceBox.Text = client.Balance.ToString();
            lastOperationBox.Text = client.LastOperation.ToString();
            categoryTextBox.Text = client.DepositCategory;
            terminBox.Text = client.TerminDeposit.ToString();
        }

        private void dpositButton_Click(object sender, EventArgs e)
        {
            if (client.DepositCategory != "None")
            {
                MessageBox.Show("Внесок вже був зроблений.");
            }
            else
            {
                Deposit_Form deposit = new Deposit_Form(bank, client);
                deposit.ShowDialog();
                UpdateClientInfo();

            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (client.DepositCategory == "Терміновий вклад")
            {
                MessageBox.Show("Неможливо зняти кошти через категорію вкладу(терміновий вклад). ");
            }
            else
            {
                Withdraw_Form withdraw = new Withdraw_Form(bank, client);
                withdraw.ShowDialog();
                UpdateClientInfo();
            }
        }

     
    }
}
