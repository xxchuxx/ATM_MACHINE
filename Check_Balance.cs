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
    public partial class Check_Balance : Form
    {
        private int accountId; private string accountName; private decimal balance;

        public Check_Balance(int AccountId, string AccountName, decimal Balance)
        {
            InitializeComponent();
            accountId = AccountId; accountName = AccountName; balance = Balance;
            lblBalance.Text = $"₱{balance}.00";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            atm_interface menu = new atm_interface(accountId, accountName, balance);
            menu.Show();
            this.Close();
        }
    }
}
