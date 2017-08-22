using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class BetweenTwoCalendars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void calcButton_Click(object sender, EventArgs e)
        {
            DateTime firstCal = Calendar1.SelectedDate;
            DateTime secondCal = Calendar2.SelectedDate;

            TimeSpan firstDay = DateTime.Now.Subtract(firstCal);
            double day1 = firstDay.TotalDays;

            TimeSpan secondDay = DateTime.Now.Subtract(secondCal);
            double day2 = secondDay.TotalDays;

            double numDays = day2 - day1;

            if (numDays < 0)
            {
                numDays = (numDays * -1);
            }

            resultLabel.Text = numDays.ToString();
        }
    }
}