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
    public partial class Deposit : Form
    {
        private int accountId;
        private string accountName;
        public decimal UpdatedBalance { get; private set; }

        public Deposit(int AccountId, string AccountName, decimal Balance)
        {
            InitializeComponent();
            accountId = AccountId; accountName = AccountName;
            UpdatedBalance = Balance;
            lblBalance.Text = ($"₱{Balance}.00");

            txtbAmount.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtbAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
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

           
            DialogResult confirm = MessageBox.Show(
             $"Deposit ₱{amount:N2}?\nNew Balance will be: ₱{UpdatedBalance + amount:N2}.00",
             "Confirm Deposit",
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
                        string updateQuery = "UPDATE AtmAccounts SET Balance = Balance + @amount WHERE AccountId = @id";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@amount", amount);
                        updateCmd.Parameters.AddWithValue("@id", accountId);
                        updateCmd.ExecuteNonQuery();


                        string logQuery = "INSERT INTO TransactionHistory (AccountId, TransactionType, Amount) VALUES(@id, 'Deposit', @amount)";
                        SqlCommand logCmd = new SqlCommand(logQuery, conn, transaction);
                        logCmd.Parameters.AddWithValue("@id", accountId);
                        logCmd.Parameters.AddWithValue("@amount", amount);
                        logCmd.ExecuteNonQuery();

                        transaction.Commit();

                        UpdatedBalance += amount;
                        MessageBox.Show($"Current Balance: ₱{UpdatedBalance:N2}.00\n" + $"₱{amount:N2}.00 deposited successfully!");
                        lblBalance.Text = ($"₱{UpdatedBalance}");
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atm_interface menu = new atm_interface(accountId,accountName,UpdatedBalance);
            this.Close();
            menu.Show();

        }
    }
}
