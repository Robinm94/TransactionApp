namespace Transaction_App
{
    partial class AccountPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtUserId = new TextBox();
            lblUserId = new Label();
            txtFname = new TextBox();
            lblFname = new Label();
            txtLname = new TextBox();
            lblLname = new Label();
            gridTransaction = new DataGridView();
            transactionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionHistoryBindingSource = new BindingSource(components);
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAccType = new TextBox();
            lblAccType = new Label();
            txtCurrentBalance = new TextBox();
            lblCurrentBalance = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionHistoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(112, 38);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(179, 30);
            txtUserId.TabIndex = 3;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(36, 41);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(70, 23);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User ID:";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(134, 83);
            txtFname.Name = "txtFname";
            txtFname.ReadOnly = true;
            txtFname.Size = new Size(307, 30);
            txtFname.TabIndex = 5;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(32, 86);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(96, 23);
            lblFname.TabIndex = 4;
            lblFname.Text = "First Name:";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(134, 131);
            txtLname.Name = "txtLname";
            txtLname.ReadOnly = true;
            txtLname.Size = new Size(307, 30);
            txtLname.TabIndex = 7;
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(32, 134);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(95, 23);
            lblLname.TabIndex = 6;
            lblLname.Text = "Last Name:";
            // 
            // gridTransaction
            // 
            gridTransaction.AllowUserToAddRows = false;
            gridTransaction.AllowUserToDeleteRows = false;
            gridTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridTransaction.AutoGenerateColumns = false;
            gridTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTransaction.Columns.AddRange(new DataGridViewColumn[] { transactionIdDataGridViewTextBoxColumn, transactionDateDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            gridTransaction.DataSource = transactionHistoryBindingSource;
            gridTransaction.Location = new Point(32, 193);
            gridTransaction.Name = "gridTransaction";
            gridTransaction.ReadOnly = true;
            gridTransaction.RowHeadersWidth = 30;
            gridTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTransaction.Size = new Size(861, 375);
            gridTransaction.TabIndex = 8;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            transactionIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            transactionIdDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            transactionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            transactionIdDataGridViewTextBoxColumn.Width = 148;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            transactionDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            transactionDateDataGridViewTextBoxColumn.HeaderText = "Date";
            transactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            transactionDateDataGridViewTextBoxColumn.Width = 225;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionHistoryBindingSource
            // 
            transactionHistoryBindingSource.DataSource = typeof(Models.Entities.TransactionHistory);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(586, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(307, 30);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(512, 41);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtAccType
            // 
            txtAccType.Location = new Point(647, 83);
            txtAccType.Name = "txtAccType";
            txtAccType.ReadOnly = true;
            txtAccType.Size = new Size(246, 30);
            txtAccType.TabIndex = 12;
            // 
            // lblAccType
            // 
            lblAccType.AutoSize = true;
            lblAccType.Location = new Point(512, 86);
            lblAccType.Name = "lblAccType";
            lblAccType.Size = new Size(117, 23);
            lblAccType.TabIndex = 11;
            lblAccType.Text = "Account Type:";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(654, 131);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.ReadOnly = true;
            txtCurrentBalance.Size = new Size(239, 30);
            txtCurrentBalance.TabIndex = 14;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(512, 134);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(136, 23);
            lblCurrentBalance.TabIndex = 13;
            lblCurrentBalance.Text = "Current Balance:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(793, 582);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(557, 582);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(676, 582);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(32, 582);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 18;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 634);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtCurrentBalance);
            Controls.Add(lblCurrentBalance);
            Controls.Add(txtAccType);
            Controls.Add(lblAccType);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(gridTransaction);
            Controls.Add(txtLname);
            Controls.Add(lblLname);
            Controls.Add(txtFname);
            Controls.Add(lblFname);
            Controls.Add(txtUserId);
            Controls.Add(lblUserId);
            Font = new Font("Segoe UI", 10F);
            Name = "AccountPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Account";
            Load += AccountPage_Load;
            ((System.ComponentModel.ISupportInitialize)gridTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionHistoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserId;
        private Label lblUserId;
        private TextBox txtFname;
        private Label lblFname;
        private TextBox txtLname;
        private Label lblLname;
        private DataGridView gridTransaction;
        private BindingSource transactionHistoryBindingSource;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAccType;
        private Label lblAccType;
        private TextBox txtCurrentBalance;
        private Label lblCurrentBalance;
        private DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnExit;
    }
}