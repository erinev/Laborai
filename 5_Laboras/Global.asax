<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        Application["ApplicationCount"] = 0;

    }
    
    void Application_End(object sender, EventArgs e) 
    {
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
    }

    void Session_Start(object sender, EventArgs e) 
    {
        Session["SessionCount"] = 0;
    }

    void Session_End(object sender, EventArgs e) 
    {
    }
       
</script>
