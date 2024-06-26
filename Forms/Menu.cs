﻿using Banking_App.Models;
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
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
           
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            NewClient_Form newAccountForm = new NewClient_Form();
         
            newAccountForm.MdiParent = this;
            newAccountForm.Show();

        }

        private void attCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients_Form customers = new Clients_Form();
            customers.MdiParent = this;
            customers.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
