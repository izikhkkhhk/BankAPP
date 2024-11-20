namespace BankApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AccountDetailsGroupBox = new GroupBox();
            AccountAmountTextBox = new TextBox();
            label4 = new Label();
            AccountNumberTextBox = new TextBox();
            label3 = new Label();
            AccountNameTextBox = new TextBox();
            label2 = new Label();
            tokenTextBox = new TextBox();
            newTransferButton = new Button();
            AccountDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AccountDetailsGroupBox
            // 
            AccountDetailsGroupBox.Controls.Add(AccountAmountTextBox);
            AccountDetailsGroupBox.Controls.Add(label4);
            AccountDetailsGroupBox.Controls.Add(AccountNumberTextBox);
            AccountDetailsGroupBox.Controls.Add(label3);
            AccountDetailsGroupBox.Controls.Add(AccountNameTextBox);
            AccountDetailsGroupBox.Controls.Add(label2);
            AccountDetailsGroupBox.Location = new Point(12, 35);
            AccountDetailsGroupBox.Name = "AccountDetailsGroupBox";
            AccountDetailsGroupBox.Size = new Size(433, 125);
            AccountDetailsGroupBox.TabIndex = 3;
            AccountDetailsGroupBox.TabStop = false;
            AccountDetailsGroupBox.Text = "Rachunek";
            // 
            // AccountAmountTextBox
            // 
            AccountAmountTextBox.Location = new Point(135, 80);
            AccountAmountTextBox.Name = "AccountAmountTextBox";
            AccountAmountTextBox.ReadOnly = true;
            AccountAmountTextBox.Size = new Size(278, 23);
            AccountAmountTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 83);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 4;
            label4.Text = "Kwota na rachunku:";
            // 
            // AccountNumberTextBox
            // 
            AccountNumberTextBox.Location = new Point(135, 51);
            AccountNumberTextBox.Name = "AccountNumberTextBox";
            AccountNumberTextBox.ReadOnly = true;
            AccountNumberTextBox.Size = new Size(278, 23);
            AccountNumberTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 54);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Numer rachunku:";
            // 
            // AccountNameTextBox
            // 
            AccountNameTextBox.Location = new Point(135, 22);
            AccountNameTextBox.Name = "AccountNameTextBox";
            AccountNameTextBox.ReadOnly = true;
            AccountNameTextBox.Size = new Size(278, 23);
            AccountNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Nazwa rachunku:";
            // 
            // tokenTextBox
            // 
            tokenTextBox.Dock = DockStyle.Bottom;
            tokenTextBox.Location = new Point(0, 226);
            tokenTextBox.Name = "tokenTextBox";
            tokenTextBox.ReadOnly = true;
            tokenTextBox.Size = new Size(463, 23);
            tokenTextBox.TabIndex = 4;
            // 
            // newTransferButton
            // 
            newTransferButton.Location = new Point(222, 182);
            newTransferButton.Name = "newTransferButton";
            newTransferButton.Size = new Size(203, 23);
            newTransferButton.TabIndex = 5;
            newTransferButton.Text = "Nowy przelew";
            newTransferButton.UseVisualStyleBackColor = true;
            newTransferButton.Click += newTransferButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 249);
            Controls.Add(newTransferButton);
            Controls.Add(tokenTextBox);
            Controls.Add(AccountDetailsGroupBox);
            Name = "Form1";
            Text = "Form1";
            Load += OnAppLoad;
            Shown += GetAccountData;
            AccountDetailsGroupBox.ResumeLayout(false);
            AccountDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox AccountDetailsGroupBox;
        private TextBox AccountAmountTextBox;
        private Label label4;
        private TextBox AccountNumberTextBox;
        private Label label3;
        private TextBox AccountNameTextBox;
        private Label label2;
        private TextBox tokenTextBox;
        private Button newTransferButton;
    }
}
