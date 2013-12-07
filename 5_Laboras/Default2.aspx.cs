using System;
using System.Globalization;
using System.Web;
using System.Web.UI;

public partial class Default2 : Page
{
    private static int ViewStateCount { get; set; }
    private static int CookieCount { get; set; }
    private static int QueryStringCount { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Show ViewState values
            ViewState.Add("ViewStateCount", ViewStateCount);

            //Reset Cookie values
            if (Request.Cookies["CookieCount"] != null)
            {
                Response.Cookies.Add(new HttpCookie("CookieCount", CookieCount.ToString(CultureInfo.InvariantCulture)));
            }

            this.ProcessQueryStringClicks();
        }
        else
        {
            this.ProcessViewStateClicks();
            this.ProcessCookieClicks();
        }

        //Show ViewState clicks if button not pressed
        if (ViewState["ViewStateCount"] != null)
        {
            LabelViewState.Text = string.Format("ViewState paspaudimai: {0}", ViewState["ViewStateCount"]);
        }

        //Show Cookie clicks if button not pressed
        if (Response.Cookies["CookieCount"] != null)
        {
            LabelCookie.Text = string.Format("Cookie paspaudimai: {0}", Response.Cookies["CookieCount"].Value);
        }

        this.ProcessApplicationClicks();

        this.ProcessSessionClicks();
    }

    private void ProcessSessionClicks()
    {
        Session["SessionCount"] = ((int)Session["SessionCount"] + 1);
        LabelSession.Text = string.Format("Session paspaudimai: {0}", Session["SessionCount"]);
    }

    private void ProcessApplicationClicks()
    {
        Application.Lock();
        Application["ApplicationCount"] = ((int)Application["ApplicationCount"] + 1);
        Application.UnLock();
        LabelApplication.Text = string.Format("Application paspaudimai: {0}", Application["ApplicationCount"]);
    }

    private void ProcessQueryStringClicks()
    {
        if (Request.QueryString["count"] != null)
        {
            QueryStringCount = int.Parse(Request.QueryString["count"]) + 1;
        }

        HyperLink1.NavigateUrl += string.Format("?count={0}", QueryStringCount);
        LabelQueryString.Text = string.Format("Query string paspaudimai: {0}", QueryStringCount);
    }

    private void ProcessCookieClicks()
    {
        CookieCount++;
        HttpCookie cookie = Response.Cookies["CookieCount"];
        if (cookie != null)
        {
            cookie.Value = (CookieCount).ToString(CultureInfo.InvariantCulture);
        }
        if (cookie != null)
        {
            LabelCookie.Text = string.Format("Cookie paspaudimai: {0}", cookie.Value);
        }
    }

    private void ProcessViewStateClicks()
    {
        ViewStateCount++;
        ViewState["ViewStateCount"] = ViewStateCount;
        LabelViewState.Text = string.Format("ViewState paspaudimai: {0}", ViewState["ViewStateCount"]);
    }
}