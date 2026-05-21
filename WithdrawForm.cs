using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_BANK
{
    public partial class WithdrawForm : Form
    {
        private int accountId;
        private string accountName;

        public decimal UpdatedBalance { get; private set; }
        public WithdrawForm(int AccountId, string AccountName, decimal Balance)
        {
            InitializeComponent();
            accountId = AccountId;
            UpdatedBalance = Balance;

            lblBalance.Text = ($"₱{Balance}.00");

            txtbAmount.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };
    }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbAmount.Text))
            {
                MessageBox.Show("Please enter an amount.");
                return;
            }

            if (!decimal.TryParse(txtbAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (amount > UpdatedBalance)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
             $"Withdraw ₱{amount:N2}.00?\nRemaining Balance: ₱{UpdatedBalance - amount:N2}.00",
             "Confirm Withdrawal",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );
            if (confirm == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string updateQuery = "UPDATE AtmAccounts SET Balance = Balance - @amount WHERE AccountId = @id";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@amount", amount);
                        updateCmd.Parameters.AddWithValue("@id", accountId);
                        updateCmd.ExecuteNonQuery();


                        string logQuery = "INSERT INTO TransactionHistory (AccountId, TransactionType, Amount) VALUES(@id, 'Withdrawal', @amount)";
                        SqlCommand logCmd = new SqlCommand(logQuery, conn, transaction);
                        logCmd.Parameters.AddWithValue("@id", accountId);
                        logCmd.Parameters.AddWithValue("@amount", amount);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();
                        UpdatedBalance -= amount;
                        lblBalance.Text = $"₱{UpdatedBalance:N2}.00";
                        /*lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = $"₱{amount:N2} dispensed successfully!";*/
                        txtbAmount.Clear();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atm_interface menu = new atm_interface(accountId, accountName, UpdatedBalance);
            this.Close();
            menu.Show();
        }
    }
}
