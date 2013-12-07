using System;
using System.Web.UI;

public partial class Spalvotas : MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["SessionName"].ToString().Trim(' ')))
        {
            LabelSpalvotasMaster.Text = string.Format("Labas, {0}", Session["SessionName"]);
        }
    }
}