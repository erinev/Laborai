using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Default : Page
{
    private static readonly string ConnString =
        ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ToString();

    private readonly SqlConnection _conn = new SqlConnection(ConnString);

    protected void Page_Load(object sender, EventArgs e)
    {
        _conn.Open();
        LabelServerVersion.Text = string.Format("Serverio versija: {0}", _conn.ServerVersion);
        _conn.Close();
        LabelConnOpen.Text = string.Format("Connection busena: {0}", _conn.State);
    }
}