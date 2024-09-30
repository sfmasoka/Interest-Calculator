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
    public partial class PeriodCalculator : Form
    {
        public PeriodCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            System.DateTime startDate = StartdateTimePicker.Value;
            System.DateTime endDate = EndDateTimePicker.Value;
            System.TimeSpan diff = endDate.Subtract(startDate);
            System.TimeSpan diff1 = endDate - startDate;
            double days = (endDate - startDate).TotalDays;
            double weeks = days / 7;
            double years = days / 365;
            DaystextBox.Text = days.ToString("n5");
            WeekstextBox.Text = weeks.ToString("n5");
            YearstextBox.Text = years.ToString("n5");

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DaystextBox.Text = "";
            WeekstextBox.Text = "";
            YearstextBox.Text = "";
        }
    }
}
