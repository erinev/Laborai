using System;
using System.Web.UI;

public partial class Default2 : Page
{
    private const string Ziema = "Ziema";

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["Theme"] != null)
            {
                Theme = Session["Theme"].ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Theme"] == null)
            {
                Session["Theme"] = Ziema;
            }
        }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        Session["Theme"] = DropDownList.Text;
        Response.Redirect("Default2.aspx");
    }
}