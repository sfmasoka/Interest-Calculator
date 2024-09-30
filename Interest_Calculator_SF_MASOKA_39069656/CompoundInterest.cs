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
    public partial class CompoundInterest : Form
    {
        public CompoundInterest()
        {
            InitializeComponent();
        }

        private void AVButton_Click(object sender, EventArgs e)
        {
            OutputlistBox.Items.Clear();
            double principle, interestRate, periodicRate, period, AV;

            if (double.TryParse(InputPrincipletextBox.Text, out principle))
            {
                if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                {
                    if (double.TryParse(PeriodtextBox.Text, out period))
                    {
                        if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                        {
                            interestRate = interestRate / 100;
                            AV = principle *(Math.Pow((1 + interestRate),(periodicRate*period)));
                            Outputlabel.Text = "Accumulated value:";
                            OutputTextBox.Text = AV.ToString("n5");
                            int n = (int)period;
                            double residual = period - n;
                            
                            double sum = principle;
                            for (int x = 0; x < n; x++)
                            {
                                //double t = principle * interestRate;
                                for (int r = 0; r < periodicRate; r++)
                                { sum = sum + (sum * interestRate); }
                                int f = x + 1;
                                string msg = "Accumulated value after period " + f.ToString() + " is: " + sum.ToString("n5");
                                OutputlistBox.Items.Add(msg);
                            }
                            if (residual>0)
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
                MessageBox.Show("Please enter a correct value for Principle! (Check 'Main menu' > 'Help' for 'How to Guide' )");
            }
        }

        private void PVButton_Click(object sender, EventArgs e)
        {
            OutputlistBox.Items.Clear();

            double interestRate, periodicRate, period, AV,PV;

            if (double.TryParse(InputAVtextBox.Text, out AV))
            {
                if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                {
                    if (double.TryParse(PeriodtextBox.Text, out period))
                    {
                        if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                        {
                            interestRate = interestRate / 100;
                            PV = AV * (Math.Pow((1 + interestRate), (-(periodicRate * period))));
                            Outputlabel.Text = "Present value:";
                            OutputTextBox.Text = PV.ToString("n5");
                            int n = (int)period;
                            double residual = period - n;
                            int f = n;
                            double sum = AV;
                            for (int x = 0; x < n; x++)
                            {
                                //double t = principle * interestRate;
                                sum = sum * (Math.Pow((1 + interestRate), (-(periodicRate * 1))));
                                f--;
                                string msg = "Present value at period " + f.ToString() + " is: " + sum.ToString("n5");
                                OutputlistBox.Items.Add(msg);
                                
                            }
                            if (residual > 0)
                            {

                                string msg = "Present value at period " + period.ToString() + " is: " + AV.ToString("n5");
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
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputPrincipletextBox.Text = "";
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
