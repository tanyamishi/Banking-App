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
    public partial class NewClient_Form : Form
    {
     
        Client newClient = new Client();
        BankingApp bank = new BankingApp();
        const string PATH_TO_DATA = ".//clients.txt";

        public NewClient_Form()
        {
            InitializeComponent();
            bank = bank.LoadData(PATH_TO_DATA);
            idBox.Text = (bank.Clients.Count() + 1).ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Trim().Length == 0)
            {
                nameErrorProvider.SetError(nameBox, "Введіть ім'я нового клієнта.");
                return;
            }
            else if (nameBox.Text.Any(char.IsDigit) || nameBox.Text.Any(char.IsPunctuation))
            {
                nameErrorProvider.SetError(nameBox, "Ім'я не може містити цифри або розділових знаків.");
                return;
            }
            else
            {
                nameErrorProvider.SetError(nameBox, string.Empty);
            }

            if (rnoBox.Text.Trim().Length == 0)
            {
                nameErrorProvider.SetError(rnoBox, "Введіть РНОКПП нового клієнта.");
                return;
            }
            else if (rnoBox.Text.Any(char.IsLetter) || rnoBox.Text.Any(char.IsPunctuation))
            {
                nameErrorProvider.SetError(rnoBox, "РНОКПП не може містити букв або розділових знаків.");
                return;
            }
            else
            {
                nameErrorProvider.SetError(rnoBox, string.Empty);
            }

            if (passportBox.Text.Trim().Length == 0)
            {
                nameErrorProvider.SetError(passportBox, "Введіть номер паспорта нового клієнта.");
                return;
            }
            else if (passportBox.Text.Length < 6)
            {
                nameErrorProvider.SetError(passportBox, "Номер паспорта не може містити меньше ніж 6 символів.");
                return;
            }
            else if (passportBox.Text.Any(char.IsPunctuation))
            {
                nameErrorProvider.SetError(passportBox, "Номер паспорта не може містити розділових знаків.");
                return;
            }
            else
            {
                nameErrorProvider.SetError(passportBox, string.Empty);
            }

                newClient.Name = nameBox.Text;
                newClient.PassportNum = passportBox.Text;
                newClient.RNOKPP = Convert.ToInt32(rnoBox.Text);
                newClient.Id = Convert.ToInt32(idBox.Text);

                bank.AddNewClient(newClient);
                bank.SaveData(PATH_TO_DATA);

                MessageBox.Show("Збережено.");
                Close();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
