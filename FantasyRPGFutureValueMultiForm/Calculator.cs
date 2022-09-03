using System.Globalization;

namespace FantasyRPGFutureValueMultiForm
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }
        //    gold,   silver, copper, intrate, years, months, totalG, totalS, totalC
        List<(string, string, string, string, string, string, string, string, string)> values = new List<(string, string, string, string, string, string, string, string, string)>();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    long monthlyInvestmentGold = long.Parse(txtMonthlyGold.Text, NumberStyles.Number);
                    long monthlyInvestmentSilver = long.Parse(txtMonthlySilver.Text, NumberStyles.Number);
                    long monthlyInvestmentCopper = long.Parse(txtMonthlyCopper.Text, NumberStyles.Number);
                    decimal interestRate = decimal.Parse(txtRate.Text, NumberStyles.Number); ;
                    int years = int.Parse(cboYears.SelectedItem.ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
                    int monthsPerYear = int.Parse(cboMonths.SelectedItem.ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);

                    decimal monthlyInvestment = MonthlyInvestmentDecimal(monthlyInvestmentGold, monthlyInvestmentSilver, monthlyInvestmentCopper);

                    monthlyInvestment = CalculateFutureValue(monthlyInvestment, interestRate, years, monthsPerYear);

                    string[] strMonthlyInvestment = monthlyInvestment.ToString().Split(".");
                    string temp = String.Format("{0:c}", strMonthlyInvestment[0]);
                    string gold = temp + " gp";
                    temp = String.Format("{0:c}", strMonthlyInvestment[1].Substring(0, 1));
                    string silver = temp + " sp";
                    temp = String.Format("{0:c}", strMonthlyInvestment[1].Substring(1, 1));
                    string copper = temp + " cp";
                    txtValueGold.Text = gold;
                    txtValueSilver.Text = silver;
                    txtValueCopper.Text = copper;

                    values.Add(((monthlyInvestmentGold.ToString() + " gp"), (monthlyInvestmentSilver.ToString() + " sp"), (monthlyInvestmentCopper.ToString() + " cp"), (interestRate / 100).ToString("P2"),
                        years.ToString(), monthsPerYear.ToString(), gold, silver, copper));
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value is too large. Enter a smaller value", "Entry Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal interestRate, int years, int monthsPerYear)
        {
            decimal result = 0;
            decimal monthlyInterestRate = ((interestRate / monthsPerYear) / 100);
            int months = monthsPerYear * years;

            for (int x = 0; x < months; x++)
            {
                result = (result + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return result;
        }

        private decimal MonthlyInvestmentDecimal(long monthlyInvestmentGold, long monthlyInvestmentSilver, long monthlyInvestmentCopper)
        {
            decimal monthlyInvestment = 0;

            monthlyInvestment = (monthlyInvestmentCopper / 100) + (monthlyInvestmentSilver / 10) + monthlyInvestmentGold;

            return monthlyInvestment;
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            if (txtMonthlyGold.Text == "" && txtMonthlySilver.Text == "" && txtMonthlyCopper.Text == "")
            {
                errorMessage += "Monthly Gold, Monthly Silver and Monthly Copper can't be all null.\n";
            }
            if (txtMonthlyGold.Text == "")
            {
                txtMonthlyGold.Text = "0";
            }
            if (txtMonthlySilver.Text == "")
            {
                txtMonthlySilver.Text = "0";
            }
            if (txtMonthlyCopper.Text == "")
            {
                txtMonthlyCopper.Text = "0";
            }

            errorMessage += IsDecimal(txtMonthlyGold.Text, txtMonthlyGold.Tag.ToString());
            errorMessage += IsWithinRange(txtMonthlyGold.Text, txtMonthlyGold.Tag.ToString(), 0, 100000);

            errorMessage += IsDecimal(txtMonthlySilver.Text, txtMonthlySilver.Tag.ToString());
            errorMessage += IsWithinRange(txtMonthlySilver.Text, txtMonthlySilver.Tag.ToString(), 0, 100000);

            errorMessage += IsDecimal(txtMonthlyCopper.Text, txtMonthlyCopper.Tag.ToString());
            errorMessage += IsWithinRange(txtMonthlyCopper.Text, txtMonthlyCopper.Tag.ToString(), 0, 100000);

            errorMessage += IsDecimal(txtRate.Text, txtRate.Tag.ToString());
            errorMessage += IsWithinRange(txtRate.Text, txtRate.Tag.ToString(), 1, 20);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private string IsInt32(string value, string? name)
        {
            string msg = "";
            
            if (!Int32.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string? name, decimal min, decimal max)
        {
            string msg = "";

            if (Decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private string IsDecimal(string value, string? name)
        {
            string msg = "";

            if (!Decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }

            return msg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (values.Count > 0)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    msg += "Monthly Gold \tMonthly Silver \tMonthly Copper \tInt Rate \tYears \tMonths Per Year \tGold \tSilver \tCopper\n";

                    msg += values[i].Item1 + " \t" + values[i].Item2 + " \t" + values[i].Item3 + " \t" + values[i].Item4 + " \t" + values[i].Item5 + " \t" + values[i].Item6 + " \t" + values[i].Item7 + "\t" + values[i].Item8 + "\t" + values[i].Item9 + "\n";
                }

                this.Tag = msg;
            }
            else
            {
                this.Tag = null;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmFutureValue_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                cboYears.Items.Add(i);
            }
            cboYears.SelectedIndex = 0;

            for (int i = 0; i < 21; i++)
            {
                cboMonths.Items.Add(i);
            }
            cboMonths.SelectedIndex = 12;
        }
    }
}