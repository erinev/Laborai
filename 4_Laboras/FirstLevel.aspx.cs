using System;
using System.Web.UI;
using Microsoft.AspNet.FriendlyUrls;

public partial class FirstLevel : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public int FirstNumber
    {
        get
        {
            string firstTextBoxValue = FirstNumberTextBox.Text;
            int firstNumber = Convert.ToInt32(firstTextBoxValue);
            return firstNumber;
        }
    }

    public int SecondNumber
    {
        get
        {
            string secondTextBoxValue = SecondNumberTextBox.Text;
            int secondNumber = Convert.ToInt32(secondTextBoxValue);
            return secondNumber;
        }
    }
    protected void CountButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("SecondLevel.aspx");
    }
}