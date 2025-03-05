namespace TipCalculator
{
    partial class TipCalculator
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
            billInput = new TextBox();
            billtitle = new Label();
            tipTitle = new Label();
            TipInput = new TextBox();
            CalcButton = new Button();
            FADTitle = new Label();
            OutputLabel = new Label();
            TipAmountCheck = new Button();
            SuspendLayout();
            // 
            // billInput
            // 
            billInput.Location = new Point(12, 91);
            billInput.Name = "billInput";
            billInput.Size = new Size(150, 31);
            billInput.TabIndex = 0;
            // 
            // billtitle
            // 
            billtitle.AutoSize = true;
            billtitle.Location = new Point(12, 63);
            billtitle.Name = "billtitle";
            billtitle.Size = new Size(104, 25);
            billtitle.TabIndex = 1;
            billtitle.Text = "Bill Amount";
            billtitle.Click += label1_Click;
            // 
            // tipTitle
            // 
            tipTitle.AutoSize = true;
            tipTitle.Location = new Point(8, 137);
            tipTitle.Name = "tipTitle";
            tipTitle.Size = new Size(106, 25);
            tipTitle.TabIndex = 2;
            tipTitle.Text = "Tip Amount";
            // 
            // TipInput
            // 
            TipInput.Location = new Point(10, 165);
            TipInput.Name = "TipInput";
            TipInput.Size = new Size(150, 31);
            TipInput.TabIndex = 3;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(10, 222);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(152, 54);
            CalcButton.TabIndex = 4;
            CalcButton.Text = "Calculate Bill";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // FADTitle
            // 
            FADTitle.AutoSize = true;
            FADTitle.Location = new Point(317, 76);
            FADTitle.Name = "FADTitle";
            FADTitle.Size = new Size(155, 25);
            FADTitle.TabIndex = 5;
            FADTitle.Text = "Final Amount Due";
            FADTitle.Click += FADTitle_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(317, 110);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(69, 25);
            OutputLabel.TabIndex = 6;
            OutputLabel.Text = "Output";
            // 
            // TipAmountCheck
            // 
            TipAmountCheck.Location = new Point(10, 282);
            TipAmountCheck.Name = "TipAmountCheck";
            TipAmountCheck.Size = new Size(202, 34);
            TipAmountCheck.TabIndex = 7;
            TipAmountCheck.Text = "Check Tip Amount";
            TipAmountCheck.UseVisualStyleBackColor = true;
            TipAmountCheck.Click += TipAmountCheck_Click;
            // 
            // TipCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TipAmountCheck);
            Controls.Add(OutputLabel);
            Controls.Add(FADTitle);
            Controls.Add(CalcButton);
            Controls.Add(TipInput);
            Controls.Add(tipTitle);
            Controls.Add(billtitle);
            Controls.Add(billInput);
            Name = "TipCalculator";
            Text = "Tip Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox billInput;
        private Label billtitle;
        private Label tipTitle;
        private TextBox TipInput;
        private Button CalcButton;
        private Label FADTitle;
        private Label OutputLabel;
        private Button TipAmountCheck;
    }
}
