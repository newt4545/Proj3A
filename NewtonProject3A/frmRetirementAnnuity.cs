using System;
using System.Windows.Forms;

namespace ProjectPlutoCalculator
{
	public partial class frmRetirementAnnuity : Form
	{
		public frmRetirementAnnuity()
		{
			InitializeComponent();
		}

		private void frmRetirementAnnuity_Load(object sender, EventArgs e)
		{

		}

		private void btnCalcRetAnu_Click(object sender, EventArgs e)
		{
			try
			{
				if (retAnuPymtBox.Text == "" || retAnuRateBox.Text == "" || retAnuNumPerBox.Text == "")
				{
					//Will throw if any input fields are empty
					throw new MissingFieldException();
				}

				decimal payment = Convert.ToDecimal(retAnuPymtBox.Text);
				decimal rateperperiod = Convert.ToDecimal(retAnuRateBox.Text) / 100;
				decimal numperiods = Convert.ToDecimal(retAnuNumPerBox.Text);

				decimal presentvalue = payment * ((1 - (decimal)Math.Pow((double)(1 + rateperperiod), (double)(numperiods * -1))) / rateperperiod);

				retAnuPVbox.Text = Math.Round(presentvalue, 2).ToString();
			}
			catch (FormatException)
			{
				// This will catch non-numeric value inputs
				MessageBox.Show("All entries must be numeric values!", "Error!");
			}
			catch (OverflowException ex)
			{
				//This will catch values that exceed memory capacity
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
			catch (DivideByZeroException)
			{
				//This will catch if rate per period is 0
				MessageBox.Show("You cannot divide by zero!", "You know better!");
			}
			catch (MissingFieldException)
			{
				//This will catch missing inputs
				MessageBox.Show("All fields must be filled in!", "Error!");
			}
		}
		
	}
}
