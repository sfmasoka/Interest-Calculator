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
    public partial class AnnuitiesConstant : Form
    {
        public AnnuitiesConstant()
        {
            InitializeComponent();
        }

        private void AVButton_Click(object sender, EventArgs e)
        {
            OutputlistBox.Items.Clear();
            double interestRate, periodicRate, period, principle,payment;

            if(InvestmentradioButton.Checked)
            {
                if(AdvanceRadioButton.Checked)
                {
                    if (double.TryParse(PaymentTextBox.Text, out payment))
                        {
                        if (double.TryParse(InputPrincipletextBox.Text, out principle))
                        {
                            if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                            {
                                if (double.TryParse(PeriodtextBox.Text, out period))
                                {
                                    if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                                    {

                                        interestRate = interestRate / 100;
                                        double AV =( principle * (Math.Pow((1 + interestRate), (periodicRate * period))) )+ ((payment * (1 + interestRate)) * (((Math.Pow((1 + interestRate), (period * periodicRate))) - 1) / interestRate));
                                        
                                        Outputlabel.Text = "Accumulated value:";
                                        OutputTextBox.Text = AV.ToString("n5");
                                        int n = (int)period;
                                        double residual = period - n;

                                        double sum = 0;
                                        double sum2 = principle;
                                        for (int x = 0; x < n; x++)
                                        {
                                           
                                            for (int r = 0; r < periodicRate; r++)
                                            { sum = (sum + payment) + ((sum + payment) * interestRate); }
                                            int f = x + 1;
                                            for (int r = 0; r < periodicRate; r++)
                                            { sum2 = sum2 + (sum2 * interestRate); }

                                            double sum3 = sum + sum2;
                                            string msg = "Accumulated value after period " + f.ToString() + " is: " + sum3.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }
                                        if (residual > 0)
                                        {

                                            string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                else if(ArrearsRadioButton.Checked)
                {
                    if (double.TryParse(InputPrincipletextBox.Text, out principle))
                    {
                        if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                        {
                            if (double.TryParse(PeriodtextBox.Text, out period))
                            {
                                if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                                {
                                    if (double.TryParse(PaymentTextBox.Text, out payment))
                                    {
                                        interestRate = interestRate / 100;
                                        double AV = (principle * (Math.Pow((1 + interestRate), (periodicRate * period)))) + (payment * (((Math.Pow((1 + interestRate), (period * periodicRate))) - 1) / interestRate));
                                        Outputlabel.Text = "Accumulated value:";
                                        OutputTextBox.Text = AV.ToString("n5");
                                        int n = (int)period;
                                        double residual = period - n;
                                        double sum2 = principle;
                                        double sum = 0;
                                        bool abc = false; 
                                        for (int x = 0; x < n; x++)
                                        {

                                           

                                            for (int r = 0; r < periodicRate; r++)
                                            {
                                                
                                                
                                                    if (abc)
                                                    {
                                                        sum = (sum + payment) + ((sum + payment) * interestRate);
                                                    }
                                                abc = true;

                                            }
                                            abc = true;
                                            int f = x + 1;
                                            for (int r = 0; r < periodicRate; r++)
                                            { sum2 = sum2 + (sum2 * interestRate); }

                                            double sum3 = sum + sum2 + payment;
                                            string msg = "Accumulated value after period " + f.ToString() + " is: " + sum3.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }
                                        if (residual > 0)
                                        {

                                            string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }

            }
            else if (LoadRepayradioButton.Checked)
            {
                if (AdvanceRadioButton.Checked)
                {
                    if (double.TryParse(PaymentTextBox.Text, out payment))
                    {
                        if (double.TryParse(InputPrincipletextBox.Text, out principle))
                        {
                            if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                            {
                                if (double.TryParse(PeriodtextBox.Text, out period))
                                {
                                    if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                                    {

                                        interestRate = interestRate / 100;
                                        double AV = (principle * (Math.Pow((1 + interestRate), (periodicRate * period)))) - ((payment * (1 + interestRate)) * (((Math.Pow((1 + interestRate), (period * periodicRate))) - 1) / interestRate));

                                        Outputlabel.Text = "Accumulated value:";
                                        OutputTextBox.Text = AV.ToString("n5");
                                        int n = (int)period;
                                        double residual = period - n;

                                        double sum = 0;
                                        double sum2 = principle;
                                        for (int x = 0; x < n; x++)
                                        {

                                            for (int r = 0; r < periodicRate; r++)
                                            { sum = (sum + payment) + ((sum + payment) * interestRate); }
                                            int f = x + 1;
                                            for (int r = 0; r < periodicRate; r++)
                                            { sum2 = sum2 + (sum2 * interestRate); }

                                            double sum3 = -(sum - sum2);

                                            string msg = "Accumulated value after period " + f.ToString() + " is: " + sum3.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }
                                        if (residual > 0)
                                        {

                                            string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                else if (ArrearsRadioButton.Checked)
                {
                    if (double.TryParse(InputPrincipletextBox.Text, out principle))
                    {
                        if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                        {
                            if (double.TryParse(PeriodtextBox.Text, out period))
                            {
                                if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                                {
                                    if (double.TryParse(PaymentTextBox.Text, out payment))
                                    {
                                        interestRate = interestRate / 100;
                                        double AV = (principle * (Math.Pow((1 + interestRate), (periodicRate * period)))) - (payment * (((Math.Pow((1 + interestRate), (period * periodicRate))) - 1) / interestRate));
                                        Outputlabel.Text = "Accumulated value:";
                                        OutputTextBox.Text = AV.ToString("n5");
                                        int n = (int)period;
                                        double residual = period - n;
                                        double sum2 = principle;
                                        double sum = 0;
                                        bool abc = false;
                                        for (int x = 0; x < n; x++)
                                        {



                                            for (int r = 0; r < periodicRate; r++)
                                            {


                                                if (abc)
                                                {
                                                    sum = (sum + payment) + ((sum + payment) * interestRate);
                                                }
                                               // else { sum = sum + payment; }
                                                abc = true;
                                                
                                            }
                                            abc = true;
                                            int f = x + 1;
                                            for (int r = 0; r < periodicRate; r++)
                                            { sum2 = sum2 + (sum2 * interestRate); }
                                            double sum3=0;
                                            //if (x == 0) { sum3 = (sum + (sum2 - payment)); }
                                              sum3 = sum2- (sum+payment); 
                                            string msg = "Accumulated value after period " + f.ToString() + " is: " + sum3.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }
                                        if (residual > 0)
                                        {

                                            string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }

            }

        }

        private void PVButton_Click(object sender, EventArgs e)
        {
            OutputlistBox.Items.Clear();
            double interestRate, periodicRate, period, AV;

            //if (InvestmentradioButton.Checked||LoadRepayradioButton.Checked)
            {
              //  if (AdvanceRadioButton.Checked||Arre
                {
                    
                    
                        if (double.TryParse(InputAVtextBox.Text, out AV))
                        {
                            if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                            {
                                if (double.TryParse(PeriodtextBox.Text, out period))
                                {
                                    if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                                    {

                                        interestRate = interestRate / 100;
                                        double PV = AV * (Math.Pow((1 + interestRate), (-(periodicRate * period))));

                                    Outputlabel.Text = "Present value:";
                                        OutputTextBox.Text = PV.ToString("n5");
                                        int n = (int)period;
                                        double residual = period - n;

                                        double sum = AV;
                                    int f = n;
                                        for (int x = 0; x < n; x++)
                                        {

                                        sum = sum * (Math.Pow((1 + interestRate), (-(periodicRate * 1))));
                                        f--;
                                        string msg = "Present value at period " + f.ToString() + " is: " + sum.ToString("n5");
                                        OutputlistBox.Items.Add(msg);
                                    }
                                        if (residual > 0)
                                        {

                                            string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString("n5");
                                            OutputlistBox.Items.Add(msg);
                                        }

                                    }
                                }
                            }
                        }
                    else
                    {
                        MessageBox.Show("Please enter a correct value for AV! (Check 'Main menu' > 'Help' for 'How to Guide' )");
                    }

                }/*
                else if (ArrearsRadioButton.Checked)
                {
                    if (double.TryParse(InputPrincipletextBox.Text, out principle))
                    {
                        if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                        {
                            if (double.TryParse(PeriodtextBox.Text, out period))
                            {
                                if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                                {
                                    if (double.TryParse(PaymentTextBox.Text, out payment))
                                    {
                                        interestRate = interestRate / 100;
                                        double AV = (principle * (Math.Pow((1 + interestRate), (periodicRate * period)))) + (payment * (((Math.Pow((1 + interestRate), (period * periodicRate))) - 1) / interestRate));
                                        Outputlabel.Text = "Accumulated value:";
                                        OutputTextBox.Text = AV.ToString();
                                        int n = (int)period;
                                        double residual = period - n;
                                        double sum2 = principle;
                                        double sum = 0;
                                        bool abc = false;
                                        for (int x = 0; x < n; x++)
                                        {



                                            for (int r = 0; r < periodicRate; r++)
                                            {


                                                if (abc)
                                                {
                                                    sum = (sum + payment) + ((sum + payment) * interestRate);
                                                }
                                                abc = true;

                                            }
                                            abc = true;
                                            int f = x + 1;
                                            for (int r = 0; r < periodicRate; r++)
                                            { sum2 = sum2 + (sum2 * interestRate); }

                                            double sum3 = sum + sum2 + payment;
                                            string msg = "Accumulated value after period " + f.ToString() + " is: " + sum3.ToString();
                                            OutputlistBox.Items.Add(msg);
                                        }
                                        if (residual > 0)
                                        {

                                            string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString();
                                            OutputlistBox.Items.Add(msg);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }*/

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputPrincipletextBox.Text = "";
            PaymentTextBox.Text = "";
            PeriodtextBox.Text = "";
            RatePerPeriodtextBox.Text = "";
            InputIntRatetextBox.Text = "";
            InputAVtextBox.Text = "";
            OutputlistBox.Items.Clear();
            OutputTextBox.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InterestConversionButton_Click(object sender, EventArgs e)
        {
            InterestConversion thisInterestConversion = new InterestConversion();
            thisInterestConversion.ShowDialog();
        }

        private void PeriodClculatorButton_Click(object sender, EventArgs e)
        {
            PeriodCalculator thisperiodCalculator = new PeriodCalculator();
            thisperiodCalculator.ShowDialog();
        }
    }
}
