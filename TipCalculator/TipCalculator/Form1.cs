namespace TipCalculator
{
    public partial class TipCalculator : Form
    {

        public TipCalculator()
        {
            InitializeComponent();
        }
        //Function that determines if the inputs are valid
        private bool areInputsValid(string inputBA, string inputTA) {
            
            return true;
        }
        // Function that calculates the final bill total

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            string inputBillAmount = billInput.Text;
            string inputTipAmount = TipInput.Text;
            areInputsValid(inputBillAmount, inputTipAmount);
        }




    }
}
