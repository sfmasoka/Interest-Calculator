using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Calculator_SF_MASOKA_39069656
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void SimpleInterestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Interest How to Guide\n\n" + "- Calculating Accummulated Value\n\n" + "1. Enter the principle, interest rate, periodic rate, period in the textboxes povided.\n"+ "2. Press the Calculate Accumulation Value button\n"+"3. The result will be visible on the result Panel on the right\n"+"4. The List Box show a period by period accumulation\n\n"+"TroubleShooting\n\n"+"1. Make sure all neccessary variable are entered before Calculating\n"+"2. Use (,)  instead of (.)\n3. Use percentages only.\n"+"4. Leave no spaces between number.\n"+"5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");
        }

        private void ContinuousButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continuous Interest How to Guide\n\n" + "- Calculating Accummulated Value\n\n" + "1. Enter the principle, interest rate, periodic rate, period in the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (,)  instead of (.)\n3. Use percentages only.\n" + "4. Leave no spaces between number.\n" + "5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n" + "- Calculating Present Value\n\n" + "1. Enter the AV, interest rate, periodic rate, period on the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (, ) instead of (.)\n3. Use percentages only.\n4. Leave no spaces between number.\n5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");

        }

        private void AnnuitiesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Annuities How to Guide\n\n" + "- Calculating Accummulated Value\n\n" + "1. Enter the payment amount, interest rate, periodic rate, period in the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (,)  instead of (.)\n3. Use percentages only.\n" + "4. Leave no spaces between number.\n" + "5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n" + "- Calculating Present Value\n\n" + "1. Enter the AV, interest rate, periodic rate, period on the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (, ) instead of (.)\n3. Use percentages only.\n4. Leave no spaces between number.\n5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");

        }

        private void CompoundInterestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compound Interest How to Guide\n\n" + "- Calculating Accummulated Value\n\n" + "1. Enter the principle, interest rate, periodic rate, period in the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (,)  instead of (.)\n3. Use percentages only.\n" + "4. Leave no spaces between number.\n" + "5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n" + "- Calculating Present Value\n\n" + "1. Enter the AV, interest rate, periodic rate, period on the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (, ) instead of (.)\n3. Use percentages only.\n4. Leave no spaces between number.\n5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");

        }

        private void AnnuitiesConstantButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Investments/Loan Repayment (constant Amount) How to Guide\n\n" + "- Calculating Accummulated Value\n\n" + "1. Enter the principle, interest rate, periodic rate, period and the payment amount in the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (,)  instead of (.)\n3. Use percentages only.\n" + "4. Leave no spaces between number.\n" + "5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n" + "- Calculating Present Value\n\n" + "1. Enter the AV, interest rate, periodic rate, period on the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (, ) instead of (.)\n3. Use percentages only.\n4. Leave no spaces between number.\n5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");

        }

        private void AnnuitiesIncreasingbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Investments/Loan Repayment (Increasing Amount) How to Guide\n\n" + "- Calculating Accummulated Value\n\n" + "1. Enter the principle, interest rate, periodic rate, period,increasing rate and the payment amount in the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (,)  instead of (.)\n3. Use percentages only.\n" + "4. Leave no spaces between number.\n" + "5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n" + "- Calculating Present Value\n\n" + "1. Enter the AV, interest rate, periodic rate, period on the textboxes povided.\n" + "2. Press the Calculate Accumulation Value button\n" + "3. The result will be visible on the result Panel on the right\n" + "4. The List Box show a period by period accumulation\n\n" + "TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (, ) instead of (.)\n3. Use percentages only.\n4. Leave no spaces between number.\n5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");

        }

        private void PeriodClculatorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Period Calculator How to Guide\n\n" + "1. Choose the start date of the period by pressing the down error to expand the calendar and choose the date.\n" + "2. Choose the end date of the period by pressing the down error to expand the calendar and choose the date.\n" + "3. Press the calculate button to calculate\n" + "4. The period will be displayed in terms of years, weeks and months.\n");
        }

        private void InterestConversionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Interest rate Converter How to Guide\n\n" + "- Convert interest rate\n\n" + "1. Choose the interest type of the INPUT interest rate you want to convert in the list box using the downward and upward navigator\n" + "2. Enter the INPUT periodic rate of the interest you want to convert in the provided textbox\n" + "3. Enter the INPUT interest rate you want to convert in the provided textbox\n" + "4. Choose the interest type of the OUTPUT interest rate you want to convert in the list box using the downward and upward navigator\n" + "5. Enter the OUTPUT periodic rate of the interest you want to convert in the provided textbox\n" + "6. Press the convert button.\n" + "7. The converted interest rate will be visible on the result box.\n\n" + "- TroubleShooting\n\n" + "1. Make sure all neccessary variable are entered before Calculating\n" + "2. Use (,)  instead of (.)\n3. Use percentages only.\n" + "4. Leave no spaces between number.\n" + "5. Make sure only numbers are entered and no foreign character are present, 1.e. do not enter the currency symbol.\n\n");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
