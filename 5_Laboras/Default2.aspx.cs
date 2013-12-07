using System;
using System.Web.UI;

public partial class Default2 : Page
{
    private static int Count { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Count++;
        ViewState["Count"] = Count - 1;
        LabelViewState.Text = string.Format("paspaudimai: {0}", ViewState["Count"]);
    }
}