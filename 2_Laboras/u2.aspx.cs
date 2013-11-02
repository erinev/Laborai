using System;
using System.Web.UI;

public partial class u2_ : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void CheckedChanged(object sender, EventArgs e)
    {
        if (AdministratoriusCheckBox.Checked)
        {
            AdministratoriusCheckBox.Text = "Sistemos administratorius";
        }
        else
        {
            AdministratoriusCheckBox.Text = "Pažymėk, jei esi administratorius";
        }
    }

    protected void SaugotiButton_Click(object sender, EventArgs e)
    {
        RezultatasLabel.Text = "Duomenys išsaugoti";
    }
}