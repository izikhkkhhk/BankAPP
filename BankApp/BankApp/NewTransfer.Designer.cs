namespace BankApp
{
    partial class NewTransfer
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
            sourceTextBox = new TextBox();
            targetTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            amountTextBox = new TextBox();
            label3 = new Label();
            MakeTransferButton = new Button();
            SuspendLayout();
            // 
            // sourceTextBox
            // 
            sourceTextBox.Location = new Point(271, 72);
            sourceTextBox.Name = "sourceTextBox";
            sourceTextBox.ReadOnly = true;
            sourceTextBox.Size = new Size(100, 23);
            sourceTextBox.TabIndex = 0;
            // 
            // targetTextBox
            // 
            targetTextBox.Location = new Point(271, 101);
            targetTextBox.Name = "targetTextBox";
            targetTextBox.Size = new Size(100, 23);
            targetTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 75);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Rachunek źródłowy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 104);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Rachunek docelowy:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(271, 130);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 133);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Kwota:";
            // 
            // MakeTransferButton
            // 
            MakeTransferButton.Location = new Point(155, 159);
            MakeTransferButton.Name = "MakeTransferButton";
            MakeTransferButton.Size = new Size(216, 23);
            MakeTransferButton.TabIndex = 6;
            MakeTransferButton.Text = "Wykonaj przelew";
            MakeTransferButton.UseVisualStyleBackColor = true;
            MakeTransferButton.Click += MakeTransferButton_Click;
            // 
            // NewTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 324);
            Controls.Add(MakeTransferButton);
            Controls.Add(label3);
            Controls.Add(amountTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(targetTextBox);
            Controls.Add(sourceTextBox);
            Name = "NewTransfer";
            Text = "NewTransfer";
            Load += NewTransfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sourceTextBox;
        private TextBox targetTextBox;
        private Label label1;
        private Label label2;
        private TextBox amountTextBox;
        private Label label3;
        private Button MakeTransferButton;
    }
}