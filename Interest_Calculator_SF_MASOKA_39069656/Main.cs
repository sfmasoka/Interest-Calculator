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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void InterestConversionButton_Click(object sender, EventArgs e)
        {
            InterestConversion thisInterestConversion = new InterestConversion();
            thisInterestConversion.ShowDialog();
        }

        private void SimpleInterestButton_Click(object sender, EventArgs e)
        {
            SimpleInterest thisSimpleInterest = new SimpleInterest();
            thisSimpleInterest.ShowDialog();
        }

        private void CompoundInterestButton_Click(object sender, EventArgs e)
        {
            CompoundInterest thiscompoundInterest = new CompoundInterest();
            thiscompoundInterest.ShowDialog();
        }

        private void AnnuitiesConstantButton_Click(object sender, EventArgs e)
        {
            AnnuitiesConstant thisannuitiesConstant = new AnnuitiesConstant();
            thisannuitiesConstant.ShowDialog();
        }

        private void AnnuitiesIncreasingbutton_Click(object sender, EventArgs e)
        {
            AnnuitiesIncreases thisannuitiesIncreases = new AnnuitiesIncreases();
            thisannuitiesIncreases.ShowDialog();
        }

        private void PeriodClculatorButton_Click(object sender, EventArgs e)
        {
            PeriodCalculator thisperiodCalculator = new PeriodCalculator();
            thisperiodCalculator.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AnnuitiesButton_Click(object sender, EventArgs e)
        {
            Annuities annuities = new Annuities();
            annuities.ShowDialog();
        }

        private void ContinuousButton_Click(object sender, EventArgs e)
        {
            ContinuousInterest continuousInterest = new ContinuousInterest();
            continuousInterest.ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
