namespace Transaction_App
{
    partial class AddUpdateHistoryForm
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
            lblTrnsatnDate = new Label();
            datelTrnsatnDate = new DateTimePicker();
            lbllTrnsatnAmnt = new Label();
            numTrnsatnAmnt = new NumericUpDown();
            lblTrnsatnDscrptn = new Label();
            txtTrnsatnDscrptn = new RichTextBox();
            btnAddUpdate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numTrnsatnAmnt).BeginInit();
            SuspendLayout();
            // 
            // lblTrnsatnDate
            // 
            lblTrnsatnDate.AutoSize = true;
            lblTrnsatnDate.Location = new Point(41, 38);
            lblTrnsatnDate.Name = "lblTrnsatnDate";
            lblTrnsatnDate.Size = new Size(142, 23);
            lblTrnsatnDate.TabIndex = 10;
            lblTrnsatnDate.Text = "Transaction Date:";
            // 
            // datelTrnsatnDate
            // 
            datelTrnsatnDate.Location = new Point(231, 32);
            datelTrnsatnDate.Name = "datelTrnsatnDate";
            datelTrnsatnDate.Size = new Size(200, 30);
            datelTrnsatnDate.TabIndex = 1;
            // 
            // lbllTrnsatnAmnt
            // 
            lbllTrnsatnAmnt.AutoSize = true;
            lbllTrnsatnAmnt.Location = new Point(41, 102);
            lbllTrnsatnAmnt.Name = "lbllTrnsatnAmnt";
            lbllTrnsatnAmnt.Size = new Size(168, 23);
            lbllTrnsatnAmnt.TabIndex = 10;
            lbllTrnsatnAmnt.Text = "Transaction Amount:";
            // 
            // numTrnsatnAmnt
            // 
            numTrnsatnAmnt.DecimalPlaces = 2;
            numTrnsatnAmnt.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numTrnsatnAmnt.Location = new Point(231, 100);
            numTrnsatnAmnt.Name = "numTrnsatnAmnt";
            numTrnsatnAmnt.Size = new Size(200, 30);
            numTrnsatnAmnt.TabIndex = 2;
            numTrnsatnAmnt.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTrnsatnDscrptn
            // 
            lblTrnsatnDscrptn.AutoSize = true;
            lblTrnsatnDscrptn.Location = new Point(41, 163);
            lblTrnsatnDscrptn.Name = "lblTrnsatnDscrptn";
            lblTrnsatnDscrptn.Size = new Size(192, 23);
            lblTrnsatnDscrptn.TabIndex = 4;
            lblTrnsatnDscrptn.Text = "Transaction Description:";
            // 
            // txtTrnsatnDscrptn
            // 
            txtTrnsatnDscrptn.Location = new Point(41, 189);
            txtTrnsatnDscrptn.Name = "txtTrnsatnDscrptn";
            txtTrnsatnDscrptn.Size = new Size(390, 130);
            txtTrnsatnDscrptn.TabIndex = 3;
            txtTrnsatnDscrptn.Text = "";
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Location = new Point(331, 333);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(100, 40);
            btnAddUpdate.TabIndex = 5;
            btnAddUpdate.Text = "&Add";
            btnAddUpdate.UseVisualStyleBackColor = true;
            btnAddUpdate.Click += BtnAddUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // AddUpdateHistoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(482, 393);
            Controls.Add(btnCancel);
            Controls.Add(btnAddUpdate);
            Controls.Add(txtTrnsatnDscrptn);
            Controls.Add(lblTrnsatnDscrptn);
            Controls.Add(numTrnsatnAmnt);
            Controls.Add(lbllTrnsatnAmnt);
            Controls.Add(datelTrnsatnDate);
            Controls.Add(lblTrnsatnDate);
            Font = new Font("Segoe UI", 10F);
            Name = "AddUpdateHistoryForm";
            Text = "Add/Update Transaction";
            ((System.ComponentModel.ISupportInitialize)numTrnsatnAmnt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrnsatnDate;
        private DateTimePicker datelTrnsatnDate;
        private Label lbllTrnsatnAmnt;
        private NumericUpDown numTrnsatnAmnt;
        private Label lblTrnsatnDscrptn;
        private RichTextBox txtTrnsatnDscrptn;
        private Button btnAddUpdate;
        private Button btnCancel;
    }
}