using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_BANK
{
    public partial class Form1 : Form
    {

        private int failedloginAttempts = 0;
        private int maxAttempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string cardNumber = txtbCardNumber.Text;
            string pin = txtbPin.Text;

            if (failedloginAttempts >= maxAttempts)
            {
                lblMessage.Text = "Card Blocked";
                btnEnter.Enabled = false;
                return;
            }


            if (cardNumber.Length != 12 || pin.Length != 6)
            {
                lblMessage.Text = "Invalid card numner or PIN format";
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT AccountId, AccountName, Balance FROM AtmAccounts WHERE CardNumber=@card AND PIN=@pin";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@card", cardNumber);
                    cmd.Parameters.AddWithValue("@pin", pin);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        failedloginAttempts = 0;

                        int AccountId = Convert.ToInt32(reader["AccountId"]);
                        string AccountName = Convert.ToString(reader["AccountName"]);
                        int Balance = Convert.ToInt32(reader["Balance"]);

                        atm_interface menu = new atm_interface(AccountId, AccountName, Balance);
                        menu.Show();
                        this.Hide();

                        txtbCardNumber.Clear(); txtbPin.Clear();
                        lblMessage.Text = ""; btnEnter.Enabled = true; failedloginAttempts = 0;


                    }
                    else
                    {
                        failedloginAttempts++;

                        int remaining = maxAttempts - failedloginAttempts;

                        if (remaining > 0)
                        {
                            lblMessage.ForeColor = Color.Red;
                            lblMessage.Text = $"Incorrect Card Number or Pin. {remaining} attempts left";
                        }
                        else
                        {
                            lblMessage.ForeColor = Color.Red;
                            lblMessage.Text = "Card Blocked! Too many failed attempts";
                            btnEnter.Enabled = false;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
