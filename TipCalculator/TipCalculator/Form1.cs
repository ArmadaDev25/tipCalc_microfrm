namespace TipCalculator
{
    public partial class TipCalculator : Form
    {

        public TipCalculator()
        {
            InitializeComponent();
        }
        //Function that determines if the inputs are valid
        private bool areInputsValid(string inputBA, string inputTA)
        {
            double checkedBA = 0;
            double checkedTA = 0;
            // Checks to make sure that the Inputed bill ammount is a number
            if (double.TryParse(inputBA, out checkedBA))
            {
                // Checks to make sure the inputed tip amount is a number
                if (double.TryParse(inputTA, out checkedTA))
                {
                    return true;
                    // returns false if the inputed tip amount is not a number
                }
                else
                {
                    return false;

                }
            }
            // If the inputted bill ammount is not a number, the function returns false
            else
            {
                return false;

            }

        }
        // Function that checks to see if the user is tipping to much, takes in the ammount tiped
        private void isTipAmmountTooMuch(string TA)
        {
            // Converts the tip ammount to a double and stores it
            double dTipAmount = Convert.ToDouble(TA);
            // Checks to see if the tip amount is below 31
            if (dTipAmount >= 31)
            {
                // if the ammount is above 31, then say they are tipping to much
                OutputLabel.Text = "Your Tipping Too Much";

            }
            else
            {
                // if the ammount is below 31 then say they are tipping the right ammount
                OutputLabel.Text = "Your Tip Amount is normal";


            }

        }
        // Function that calculates the final bill total
        // Takes in two strings and converts them to doubles, then perform the calculations to find the total bill amount
        private double calculateFinalBill(string billA, string tipA)
        {
            double fbillAmount = 0;
            // Converts the bill ammount to a double and stores it
            double dBillAmount = Convert.ToDouble(billA);
            // Converts the tip ammount to a double and stores it
            double dTipAmount = Convert.ToDouble(tipA);
            // This is the begining of the calculation Math
            // Divides the Tip amount by the bill amount to get the total cost of the tip
            double calTipAmmount = dTipAmount / dBillAmount;
            // Adds the calulated tip ammount to the bill amount to get the final bill amount
            fbillAmount = calTipAmmount + dBillAmount;
            // Returns the Final Bill Amount 
            return fbillAmount;



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // Holds the Inputed bill Amount
            string inputBillAmount = billInput.Text;
            // Holds the inputed tip amount
            string inputTipAmount = TipInput.Text;
            // if statement checks to make sure the output of areInputsValid is true, if not the program will error out
            if (areInputsValid(inputBillAmount, inputTipAmount) == true)
            {
                // outputLabel displays the amount calculated by the calculateFinalBill function as a string
                OutputLabel.Text = calculateFinalBill(inputBillAmount, inputTipAmount).ToString();
            }
            else
            {
                // Error that displays if areInputsValid comes back as false
                OutputLabel.Text = "Error: Please Input A Valid Number";

            }
        }

        private void FADTitle_Click(object sender, EventArgs e)
        {


        }

        private void TipAmountCheck_Click(object sender, EventArgs e)
        {
            // Holds the inputed tip amount
            string inputTipAmount = TipInput.Text;
            // Runs the isTipAmmountToMuch Function and passed the function the inputted tip ammount
            isTipAmmountTooMuch(inputTipAmount);
        }
    }
}
