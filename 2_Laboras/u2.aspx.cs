using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class u2_ : System.Web.UI.Page
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