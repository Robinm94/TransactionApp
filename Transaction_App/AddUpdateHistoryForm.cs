using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Transaction_App.Models.Entities;

namespace Transaction_App
{
    public partial class AddUpdateHistoryForm : Form
    {
        public TransactionHistory? newTransactionHistory = null;
        private TransactionHistory? transactionHistoryToBeUpdated = null;
        public AddUpdateHistoryForm(TransactionHistory? transactionHistoryToBeUpdated, double maxAmount)
        {
            InitializeComponent();
            datelTrnsatnDate.MaxDate = DateTime.Now.AddDays(7);
            
            if (transactionHistoryToBeUpdated != null)
            {
                this.newTransactionHistory = transactionHistoryToBeUpdated;
                this.Text = "Update Transaction";
                btnAddUpdate.Text = "&Update";
                numTrnsatnAmnt.Maximum = (decimal)maxAmount + (decimal)transactionHistoryToBeUpdated.Amount!;
                txtTrnsatnDscrptn.Text = transactionHistoryToBeUpdated.Description;
                numTrnsatnAmnt.Value = (decimal)transactionHistoryToBeUpdated.Amount!;
                datelTrnsatnDate.Value = (DateTime)transactionHistoryToBeUpdated.TransactionDate!;
            }
            else
            {
                numTrnsatnAmnt.Maximum = (decimal)maxAmount;
                this.Text = "Add Transaction";
                btnAddUpdate.Text = "&Add";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddUpdate_Click(object sender, EventArgs e)
        {
            if (transactionHistoryToBeUpdated != null)
            {
                this.newTransactionHistory = new TransactionHistory()
                {
                    TransactionId = transactionHistoryToBeUpdated.TransactionId,
                    AccountId = transactionHistoryToBeUpdated.AccountId,
                    Description = txtTrnsatnDscrptn.Text,
                    Amount = numTrnsatnAmnt.Value,
                    TransactionDate = datelTrnsatnDate.Value
                };
            }
            else
            {
                this.newTransactionHistory = new TransactionHistory()
                {
                    Description = txtTrnsatnDscrptn.Text,
                    Amount = numTrnsatnAmnt.Value,
                    TransactionDate = datelTrnsatnDate.Value
                };
            }
            this.Close();
        }
    }
}
