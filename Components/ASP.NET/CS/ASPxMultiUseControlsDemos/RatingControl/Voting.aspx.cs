using System;
using System.Web.UI;
using DevExpress.Web;
using System.Threading;
using System.Collections.Generic;

public partial class RatingControl_Example : Page {
    List<int> votingValues = new List<int>(new int[] { 5, 4, 3, 2, 4, 3, 5, 3 });

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            Array values = Enum.GetValues(typeof(RatingControlItemFillPrecision));
            foreach(object value in values)
                cmbPrecision.Items.Add(value.ToString());
            cmbPrecision.Value = allRating.FillPrecision.ToString();
        }
        allRating.FillPrecision = (RatingControlItemFillPrecision)cmbPrecision.SelectedIndex;

        if(!IsCallback) {
            allRating.Value = GetRating();
            lbAllVotes.Text = string.Format("{0} votes ({1})", votingValues.Count,
                allRating.Value.ToString("0.##"));
        }
    }

    protected void cbVoting_Callback(object sender, CallbackEventArgs e) {
        // Intentionally pauses server-side processing, 
        // to demonstrate the Rating Control functionality.
        Thread.Sleep(1000); 
        decimal ratingValue = GetRating();
        e.Result = string.Format("{0} {1} {1:0.##}", votingValues.Count, ratingValue);
    }

    public decimal GetRating() {
        if(myRating.Value > 0)
            this.votingValues.Add((int)myRating.Value);
        
        decimal sum = 0;
        foreach(int value in votingValues)
            sum += value;
        return sum / votingValues.Count;
    }
}
