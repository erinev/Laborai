using System;
using System.Web.UI;

namespace _6_Laboras
{
    public class Default : Page
    {
        private const string Ziema = "Ziema";
        private const string Vasara = "Vasara";

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
            if (Session["Theme"].ToString().Equals(Ziema, StringComparison.InvariantCultureIgnoreCase))
            {
                Session["Theme"] = Vasara;
            }
            else if (Session["Theme"].ToString().Equals(Vasara, StringComparison.InvariantCultureIgnoreCase))
            {
                Session["Theme"] = Ziema;
            }
            Response.Redirect("Default.aspx");
        }
    }
}