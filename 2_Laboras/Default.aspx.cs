using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Bendras(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "Groju")
        {
            Response.Write("Groju");
        }
        else if (e.CommandName == "Pauze")
        {
            Response.Write("Pauze");
        }
        else if (e.CommandName == "Stop")
        {
            Response.Write("Stop");
        }
        else 
        {
            Response.Write("Nezinoma komanda");
        }
    }
}