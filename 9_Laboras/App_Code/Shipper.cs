using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

[DataObject]
public class Shipper
{
    private static readonly string ConnString =
        ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ToString();

    private readonly SqlConnection _conn = new SqlConnection(ConnString);

    [DataObjectMethod(DataObjectMethodType.Insert)]
    public void InsertShipper(string companyName, string phoneNumber)
    {
        var cmd = new SqlCommand(
            "INSERT INTO Shippers (CompanyName, Phone) VALUES (@CompanyName, @Phone)", _conn);

        cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar, 40).Value = companyName;
        cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 24).Value = phoneNumber;

        _conn.Open();
        cmd.ExecuteNonQuery();
        _conn.Close();
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataTable SelectShippers()
    {
        const string tableName = "Shippers";
        var dataSet = new DataSet(tableName);

        _conn.Open();
        var dataAdapter = new SqlDataAdapter("SELECT * FROM Shippers", _conn);
        _conn.Close();

        dataAdapter.Fill(dataSet, tableName);
        return dataSet.Tables[tableName];
    }

    [DataObjectMethod(DataObjectMethodType.Update)]
    public void UpdateShipper(string companyName, string phoneNumber, int shipperId)
    {
        var cmd = new SqlCommand(
            "UPDATE Shippers SET CompanyName = @CompanyName, Phone = @Phone WHERE ShipperID = @ShipperID", _conn);

        cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar, 40).Value = companyName;
        cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 24).Value = phoneNumber;
        cmd.Parameters.Add("@ShipperID", SqlDbType.Int, 4).Value = shipperId;

        _conn.Open();
        cmd.ExecuteNonQuery();
        _conn.Close();
    }

    [DataObjectMethod(DataObjectMethodType.Delete)]
    public void DeleteShipper(int shipperId)
    {
        var cmd = new SqlCommand(
            "DELETE FROM Shippers WHERE ShipperID = @ShipperID", _conn);

        cmd.Parameters.Add("@ShipperID", SqlDbType.Int, 4).Value = shipperId;

        _conn.Open();
        cmd.ExecuteNonQuery();
        _conn.Close();
    }
}