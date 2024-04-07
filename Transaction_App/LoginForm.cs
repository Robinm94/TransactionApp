using Transaction_App.Models.Entities;

namespace Transaction_App
{
    public partial class LoginForm : Form
    {

        public readonly static TransactionContext dbContext = new TransactionContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // exit forms and confirmation of exit
            DialogResult d = MessageBox.Show("Do you want to exit?", "Exit Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserId.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter User ID and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!int.TryParse(txtUserId.Text, out int userId))
            {
                MessageBox.Show("User ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dbContext.Users.Any(user => user.Id == userId && user.Password == txtPassword.Text))
            {
                User userAcc = dbContext.Users.Where(user => user.Id == userId).FirstOrDefault()!;
                AccountPage accForm = new AccountPage(userAcc);
                this.Hide();
                accForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID and Password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
