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
            SuspendLayout();
            // 
            // billInput
            // 
            billInput.Location = new Point(298, 62);
            billInput.Name = "billInput";
            billInput.Size = new Size(150, 31);
            billInput.TabIndex = 0;
            // 
            // billtitle
            // 
            billtitle.AutoSize = true;
            billtitle.Location = new Point(298, 34);
            billtitle.Name = "billtitle";
            billtitle.Size = new Size(104, 25);
            billtitle.TabIndex = 1;
            billtitle.Text = "Bill Amount";
            billtitle.Click += label1_Click;
            // 
            // tipTitle
            // 
            tipTitle.AutoSize = true;
            tipTitle.Location = new Point(296, 128);
            tipTitle.Name = "tipTitle";
            tipTitle.Size = new Size(106, 25);
            tipTitle.TabIndex = 2;
            tipTitle.Text = "Tip Amount";
            // 
            // TipInput
            // 
            TipInput.Location = new Point(298, 156);
            TipInput.Name = "TipInput";
            TipInput.Size = new Size(150, 31);
            TipInput.TabIndex = 3;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(230, 228);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(280, 83);
            CalcButton.TabIndex = 4;
            CalcButton.Text = "Calculate Bill";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // TipCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
