using System;
using System.Configuration;
using System.Data;
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

    protected void ButtonAtrinkti_Click(object sender, EventArgs e)
    {
        var dataSet = new DataSet();
        SqlDataAdapter productsDataAdapter = GetProducts();
        productsDataAdapter.Fill(dataSet);
        GridView2.DataSource = dataSet;
        GridView2.DataBind();
    }

    private SqlDataAdapter GetProducts()
    {
        _conn.Open();
        var sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Products WHERE UnitsInStock <= 20", _conn);
        _conn.Close();
        return sqlDataAdapter;
    }

    protected void ButtonModifikuoti_Click(object sender, EventArgs e)
    {
        var dataSet = new DataSet();
        var updateCommand = new SqlCommand("UPDATE Products SET UnitPrice = UnitPrice*1.5 WHERE UnitsInStock <= 20",
            _conn);
        _conn.Open();
        updateCommand.ExecuteNonQuery();
        _conn.Close();

        SqlDataAdapter productsDataAdapter = GetProducts();
        productsDataAdapter.Fill(dataSet);
        GridView2.DataSource = dataSet;
        GridView2.DataBind();
    }
}