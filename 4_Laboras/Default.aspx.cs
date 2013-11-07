using System;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            RegistrationFinishedLabel.Text = "Registracija sėkminga!";
            RegistrationFinishedLabel.Font.Bold = true;
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = false;

        string inputValue = args.Value;

        if (inputValue.Length < 6 || inputValue.Length > 14) return;

        bool upperCaseExist = CheckIfStringContainsUpperCase(inputValue);
        if (!upperCaseExist) return;

        bool loweCaseExist = CheckIfStringContainsLowerCase(inputValue);
        if (!loweCaseExist) return;

        bool numberExist = CheckIfStringContainsNumber(inputValue);
        if (numberExist) return;

        args.IsValid = true;
    }

    private bool CheckIfStringContainsUpperCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        return Regex.IsMatch(str, "[A-Z]");
    }

    private bool CheckIfStringContainsLowerCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        return Regex.IsMatch(str, "[a-z]");
    }

    private bool CheckIfStringContainsNumber(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        return Regex.IsMatch(str, "[0-9]");
    }
}