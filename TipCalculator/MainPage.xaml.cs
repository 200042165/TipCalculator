namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        // Handler for 15% tip calculation
        private void OnTip15Clicked(object sender, EventArgs e)
        {
            CalculateTip(0.15);
        }



        // Handler for 20% tip calculation
        private void OnTip20Clicked(object sender, EventArgs e)
        {
            CalculateTip(0.20);
        }



        // Handler for 25% tip calculation
        private void OnTip25Clicked(object sender, EventArgs e)
        {
            CalculateTip(0.25);
        }



        // Method to calculate tip
        private void CalculateTip(double tipPercentage)
        {
            if (double.TryParse(BillAmountEntry.Text, out double billAmount))
            {
                double tipAmount = billAmount * tipPercentage;
                double totalAmount = billAmount + tipAmount;



                // Update result label
                ResultLabel.Text = $"%{tipPercentage * 100:F0} Tip: ${tipAmount:F2}   |   Total: ${totalAmount:F2}";
            }
            else
            {
                ResultLabel.Text = "Please enter a valid bill amount.";
            }
        }
    }
}