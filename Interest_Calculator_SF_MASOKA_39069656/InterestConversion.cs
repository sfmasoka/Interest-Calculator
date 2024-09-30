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
    public partial class InterestConversion : Form
    {
        public InterestConversion()
        {
            InitializeComponent();
        }



        private void InterestConversion_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //double Nominal;
            //double EffectiveAnnual;
            //double EffectivePeriod;
            //double continuous;
            double Inputperiod, outputPeriod;
            double inputInterestRate, resultInterestRate;

            
            if (InputListBox.SelectedIndex == 0)
            {
                InputPeriodTextBox.Text = "1";
                if (OutputListBox.SelectedIndex == 0)
                {
                    OutputPeriodTextBox.Text = "1";
                    if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                    { ResultTextBox.Text = InputInterestRateTextBox.Text; }


                }
                else if (OutputListBox.SelectedIndex == 1)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = (Math.Pow((1 + inputInterestRate), (1 / outputPeriod)) - 1) * outputPeriod;
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }
                else if (OutputListBox.SelectedIndex == 2)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = (Math.Pow((1 + inputInterestRate), (1 / outputPeriod)) - 1);
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }
                else if (OutputListBox.SelectedIndex == 3)
                {
                    OutputPeriodTextBox.Text = "1";
                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = Math.Log(1 + inputInterestRate);
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }


            }
            else if (InputListBox.SelectedIndex == 1)
            {
                if (OutputListBox.SelectedIndex == 0)
                {
                    OutputPeriodTextBox.Text = "1";
                    if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                    {
                        if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                        {
                            inputInterestRate = inputInterestRate / 100;
                            resultInterestRate = (Math.Pow((1 + (inputInterestRate / Inputperiod)), Inputperiod)) - 1;
                            resultInterestRate = resultInterestRate * 100;
                            ResultTextBox.Text = resultInterestRate.ToString();
                        }
                    }


                }
                else if (OutputListBox.SelectedIndex == 1)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = ((Math.Pow((1 + (inputInterestRate/Inputperiod)), (Inputperiod / outputPeriod))) - 1) * outputPeriod;
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }
                else if (OutputListBox.SelectedIndex == 2)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = ((Math.Pow((1 + (inputInterestRate/Inputperiod)), (Inputperiod / outputPeriod))) - 1);
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }
                else if (OutputListBox.SelectedIndex == 3)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        //if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        // {
                        if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                        {
                            inputInterestRate = inputInterestRate / 100;
                            OutputPeriodTextBox.Text = "1";
                            resultInterestRate = Math.Log(1 + (((Math.Pow((1 + (inputInterestRate / Inputperiod)), Inputperiod)) - 1)));
                            resultInterestRate = resultInterestRate * 100;
                            ResultTextBox.Text = resultInterestRate.ToString();
                        }

                        //}
                    }



                }

            }
            else if (InputListBox.SelectedIndex == 2)
            {
                if (OutputListBox.SelectedIndex == 0)
                {
                    OutputPeriodTextBox.Text = "1";
                    if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                    {
                        if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                        {
                            inputInterestRate = inputInterestRate / 100;
                            resultInterestRate = (Math.Pow((1 + inputInterestRate), Inputperiod)) - 1;
                            resultInterestRate = resultInterestRate * 100;
                            ResultTextBox.Text = resultInterestRate.ToString();
                        }
                    }


                }
                else if (OutputListBox.SelectedIndex == 1)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = ((Math.Pow((1 + (inputInterestRate)), (Inputperiod / outputPeriod))) - 1)*outputPeriod;
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }
                else if (OutputListBox.SelectedIndex == 2)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                                inputInterestRate = inputInterestRate / 100;
                                resultInterestRate = ((Math.Pow((1 + (inputInterestRate)), (Inputperiod / outputPeriod))) - 1);
                                resultInterestRate = resultInterestRate * 100;
                                ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                    }



                }
                else if (OutputListBox.SelectedIndex == 3)
                {

                    if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    {
                        //if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        // {
                        if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                        {
                            inputInterestRate = inputInterestRate / 100;
                            OutputPeriodTextBox.Text = "1";
                            resultInterestRate = Math.Log(1 + (((Math.Pow((1 + (inputInterestRate)), Inputperiod)) - 1)));
                            resultInterestRate = resultInterestRate * 100;
                            ResultTextBox.Text = resultInterestRate.ToString();
                        }

                        //}
                    }



                }


            }
            else if (InputListBox.SelectedIndex == 3)
            {
                InputPeriodTextBox.Text = "1";
                if (OutputListBox.SelectedIndex == 0)
                {
                    OutputPeriodTextBox.Text = "1";
                    if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                    {
                        // if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                        // {
                        inputInterestRate = inputInterestRate / 100;
                        resultInterestRate = Math.Exp(inputInterestRate) - 1;
                        resultInterestRate = resultInterestRate * 100;    
                        ResultTextBox.Text = resultInterestRate.ToString();
                       // }
                    }


                }
                else if (OutputListBox.SelectedIndex == 1)
                {

                   // if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                   // {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                            inputInterestRate = inputInterestRate / 100;
                            resultInterestRate = (Math.Exp(inputInterestRate / outputPeriod) - 1) * outputPeriod;
                            resultInterestRate = resultInterestRate * 100;    
                            ResultTextBox.Text = resultInterestRate.ToString();
                            }

                       // }
                    }



                }
                else if (OutputListBox.SelectedIndex == 2)
                {

                    //if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                   // {
                        if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        {
                            if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                            {
                            inputInterestRate = inputInterestRate / 100;
                            resultInterestRate = (Math.Exp(inputInterestRate / outputPeriod) - 1);
                            resultInterestRate = resultInterestRate * 100;
                            ResultTextBox.Text = resultInterestRate.ToString();
                            }

                        }
                   // }



                }
                else if (OutputListBox.SelectedIndex == 3)
                {

                    //if (double.TryParse(InputPeriodTextBox.Text, out Inputperiod))
                    //{
                        //if (double.TryParse(OutputPeriodTextBox.Text, out outputPeriod))
                        // {
                        if (double.TryParse(InputInterestRateTextBox.Text, out inputInterestRate))
                        {
                        
                        OutputPeriodTextBox.Text = "1";
                        resultInterestRate = inputInterestRate;
                            ResultTextBox.Text = resultInterestRate.ToString();
                        }

                        //}
                   // }



                }


            }
            else
            {
                MessageBox.Show("Please Select the type of Interest Rate in the List Box");
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputInterestRateTextBox.Text = "";
            InputPeriodTextBox.Text = "";
            OutputPeriodTextBox.Text = "";
            ResultTextBox.Text = "";
            
        }
    }
}
