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
    public partial class Clients_Form : Form
    {
        BankingApp bank = new BankingApp();
        Client client = new Client();
        const string PATH_TO_DATA = ".//clients.txt";

        public Clients_Form()
        {
            InitializeComponent();

            if (!File.Exists(PATH_TO_DATA))
            {
                File.Create(PATH_TO_DATA);
                bank.SaveData(PATH_TO_DATA);
            }

            bank = bank.LoadData(PATH_TO_DATA);

            DateTime currentDate = DateTime.Now;
            if (bank.LastInterestCalculation != DateTime.MinValue)
            {
                int daysSinceLastCalculation = (currentDate - bank.LastInterestCalculation).Days;
                if (daysSinceLastCalculation > 0)
                {
                    bank.ApplyInterestForDays(daysSinceLastCalculation);
                    bank.SaveData(PATH_TO_DATA);
                }
            }
            CheckDepositTerm();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = bank.Search(nameBoxSrc.Text, idBoxSrc.Text, passportBoxSrc.Text, rnoBoxSrc.Text);
            if (result.Count == 0)
            {
                MessageBox.Show("Нічого не знайдено.");
            }
            else
            {
                clientBindingSource.DataSource = result;
            }
        }

        private void resultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedClient = resultGridView.Rows[e.RowIndex].DataBoundItem as Client;
            var infoClient = new ClientInfo_Form(bank, selectedClient);
            infoClient.ShowDialog();
            UpdateClientGrid();
        }

        private void Clients_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            bank.SaveData(PATH_TO_DATA);
        }
        private void UpdateClientGrid()
        {
            clientBindingSource.DataSource = null;
            clientBindingSource.DataSource = bank.Clients;
            resultGridView.Refresh();
        }

        private void CheckDepositTerm()
        {
            DateTime currentDate = DateTime.Now;
            foreach (var client in bank.Clients)
            {
                if (client.DepositCategory == "Терміновий вклад" && client.TerminDeposit > 0)
                {

                    DateTime depositEndDate = client.LastOperation.AddDays(client.TerminDeposit);

                    if (currentDate >= depositEndDate)
                    {
                        MessageBox.Show($"Срок депозиту {client.Name} вичерпано. Необходимо выдати гроші.");
                        ClientInfo_Form clientForm =  new ClientInfo_Form(bank, client);
                        clientForm.ShowDialog();
                        client.DepositCategory = "None";
                        client.TerminDeposit = 0;
                        bank.SaveData(PATH_TO_DATA);
                    }
                }
            }
        }
    }
}
