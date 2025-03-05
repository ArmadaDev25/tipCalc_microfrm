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
            double checkedBA = 0;
            double checkedTA = 0;
            if (double.TryParse(inputBA, out checkedBA))
            {
                if (double.TryParse(inputTA, out checkedTA)){
                    return true;

                } else {
                    return false;
                
                }
            }
            else {
                return false;

            }
                
        }
        // Function that calculates the final bill total

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            string inputBillAmount = billInput.Text;
            string inputTipAmount = TipInput.Text;
            // if statement checks to make sure the output of areInputsValid is true, if not the program will error out
            if (areInputsValid(inputBillAmount, inputTipAmount) == true)
            {
                OutputLabel.Text = "ertor";
            }
            else {
                OutputLabel.Text = "error";
                
            }
        }




    }
}
