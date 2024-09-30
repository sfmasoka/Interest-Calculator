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
    public partial class SimpleInterest : Form
    {
        public SimpleInterest()
        {
            InitializeComponent();
        }

        private void AVButton_Click(object sender, EventArgs e)
        {
            OutputlistBox.Items.Clear();
            double principle,interestRate,periodicRate,period,AV;

            if(double.TryParse(InputPrincipletextBox.Text,out principle))
            {
                if (double.TryParse(RatePerPeriodtextBox.Text, out periodicRate))
                {
                    if (double.TryParse(PeriodtextBox.Text, out period))
                    {
                        if (double.TryParse(InputIntRatetextBox.Text, out interestRate))
                        {
                            interestRate = interestRate / 100;
                            AV = principle * (1 + (interestRate)*(periodicRate * period));
                            Outputlabel.Text = "Accumulated value:";
                            OutputTextBox.Text = AV.ToString("n5");
                            int n = (int)period;
                            double residual = period - n;
                            double t = principle * interestRate;
                            double sum =principle;
                            for (int x = 0;x<n;x++)
                            {
                                sum = sum + (principle * interestRate)*periodicRate;
                                int f = x + 1;
                                string msg = "Accumulated value after period " + f.ToString() + " is: " + sum.ToString("n5"); 
                                OutputlistBox.Items.Add(msg);
                            }
                            if(residual!=0.0 )
                            {

                                string msg = "Accumulated value after period " + period.ToString() + " is: " + AV.ToString("n5");
                                OutputlistBox.Items.Add(msg);
                            }

                        }
                    }
                }
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputPrincipletextBox.Text = "";
            PeriodtextBox.Text = "";
            RatePerPeriodtextBox.Text = "";
            InputIntRatetextBox.Text="";
            //InputAVtextBox.Text = "";
            OutputlistBox.Items.Clear();
            OutputTextBox.Text = "";
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
