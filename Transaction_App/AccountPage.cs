
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction_App.Models.Entities;

namespace Transaction_App
{
    public partial class AccountPage : Form
    {
        private readonly User userAcc;
        private readonly Models.Entities.Account accountToUpdate;
        public AccountPage(User userAcc)
        {
            InitializeComponent();
            this.userAcc = userAcc;
            accountToUpdate = LoginForm.dbContext.Accounts.Where(acc => acc.UserId == userAcc.Id).FirstOrDefault()!;
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            Account? account = LoginForm.dbContext.Accounts.Where(acc => acc.UserId == userAcc.Id).FirstOrDefault();
            if (account == null)
            {
                DialogResult d = MessageBox.Show("No account found for this user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                txtUserId.Text = userAcc.Id.ToString();
                txtFname.Text = userAcc.Firstname;
                txtLname.Text = userAcc.Lastname;
                txtEmail.Text = userAcc.Email;
                txtAccType.Text = account.AccountType;
                txtCurrentBalance.Text = account.CurrentBalance.ToString();
                RefreshTransactions();
            }
        }

        private void RefreshTransactions()
        {
            gridTransaction.DataSource = null;
            txtCurrentBalance.Text = accountToUpdate.CurrentBalance.ToString();
            gridTransaction.DataSource = LoginForm.dbContext.TransactionHistories
                .OrderByDescending(th => th.TransactionDate)
                .Join(LoginForm.dbContext.Accounts, th => th.AccountId, acc => acc.AccountId, (th, acc) => new { th, acc.UserId })
                .Join(LoginForm.dbContext.Users, thacc => thacc.UserId, user => user.Id, (thacc, user) => new { thacc, user.Id })
                .Where(thaccuser => thaccuser.Id == userAcc.Id)
                .Select(thaccuser => thaccuser.thacc.th).ToList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (gridTransaction.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TransactionHistory historyToDelete = (TransactionHistory)gridTransaction.SelectedRows[0].DataBoundItem!;
            accountToUpdate.CurrentBalance += (double)historyToDelete.Amount!;

            LoginForm.dbContext.TransactionHistories.Remove(historyToDelete);
            LoginForm.dbContext.SaveChanges();
            RefreshTransactions();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateHistoryForm addUpdateHistoryForm = new AddUpdateHistoryForm(null,(accountToUpdate.CurrentBalance ?? 0));
            addUpdateHistoryForm.ShowDialog();
            if (addUpdateHistoryForm.newTransactionHistory != null)
            {
                addUpdateHistoryForm.newTransactionHistory.AccountId = accountToUpdate.AccountId;
                LoginForm.dbContext.TransactionHistories.Add(addUpdateHistoryForm.newTransactionHistory);
                accountToUpdate.CurrentBalance -= (double)addUpdateHistoryForm.newTransactionHistory.Amount!;
                LoginForm.dbContext.SaveChanges();
                RefreshTransactions();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (gridTransaction.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TransactionHistory historyToUpdate = (TransactionHistory)gridTransaction.SelectedRows[0].DataBoundItem!;
            AddUpdateHistoryForm addUpdateHistoryForm = new AddUpdateHistoryForm(historyToUpdate, (accountToUpdate.CurrentBalance ?? 0));
            addUpdateHistoryForm.ShowDialog();
            if (addUpdateHistoryForm.newTransactionHistory != null)
            {
                TransactionHistory updatedHistory = addUpdateHistoryForm.newTransactionHistory;
                accountToUpdate.CurrentBalance += (double)historyToUpdate.Amount!;
                historyToUpdate.Description = updatedHistory.Description;
                historyToUpdate.Amount = updatedHistory.Amount;
                historyToUpdate.TransactionDate = updatedHistory.TransactionDate;
                accountToUpdate.CurrentBalance -= (double)historyToUpdate.Amount!;
                LoginForm.dbContext.SaveChanges();
                RefreshTransactions();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
