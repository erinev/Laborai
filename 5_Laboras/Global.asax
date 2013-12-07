<%@ Application Language="C#" %>

<script runat="server">

    private void Application_Start(object sender, EventArgs e)
    {
        Application["ApplicationCount"] = 0;
    }

    private void Application_End(object sender, EventArgs e)
    {
    }

    private void Application_Error(object sender, EventArgs e)
    {
    }

    private void Session_Start(object sender, EventArgs e)
    {
        Session["SessionCount"] = 0;
        Session["SessionName"] = string.Empty;
        Session["SessionMasterPage"] = null;
    }

    private void Session_End(object sender, EventArgs e)
    {
    }

</script>