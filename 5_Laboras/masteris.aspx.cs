using System;
using System.Web.UI;

public partial class Masteris : Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["SessionMasterPage"] != null && Session["SessionMasterPage"].ToString().Length > 0)
        {
            MasterPageFile = string.Format("~/{0}.master", Session["SessionMasterPage"]);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ButtonPasirinkti_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ButtonPasirinkti.Text.Trim(' ')))
        {
            Session["SessionName"] = TextBoxVardas.Text;
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }

    protected void DropDownListMaster_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(DropDownListMaster.Text))
        {
            Session["SessionMasterPage"] = DropDownListMaster.Text;
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}