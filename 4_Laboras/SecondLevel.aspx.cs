using System;
using System.Globalization;
using System.Web.UI;

public partial class SecondLevel : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            MessageLabel.Visible = true;
            ResultLabel.Visible = true;

            int sum = PreviousPage.FirstNumber + PreviousPage.SecondNumber;
            ResultLabel.Text = sum.ToString(CultureInfo.InvariantCulture);
        }
    }
}