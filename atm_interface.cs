using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_BANK
{
    public partial class atm_interface : Form
    {
        private int accountId; private string accountName; private decimal balance;

        public atm_interface(int AccountId, string AccountName, decimal Balance)
        {
            InitializeComponent();
            accountId = AccountId; accountName = AccountName; balance = Balance;
            lblWelcome.Text = $"Welcome, {accountName}";

        }

        private void txtbDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit depo = new Deposit(accountId, accountName,balance);
            depo.Show();

            balance = depo.UpdatedBalance;
            
        }

        private void txtbBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Balance cb = new Check_Balance(accountId,accountName, balance);
            cb.Show();

            
        }

        private void txtbCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawForm depo = new WithdrawForm(accountId,accountName, balance);
            depo.Show();

            balance = depo.UpdatedBalance;
        }
    }
}
