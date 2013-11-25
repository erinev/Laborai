using System;
using System.Web.UI;

public partial class U3 : Page
{
    private string[] GautiGerimuMasyva()
    {
        var gerimuMasyvas = new string[4];
        gerimuMasyvas[0] = "Sultys";
        gerimuMasyvas[1] = "Pienas";
        gerimuMasyvas[2] = "Limonadas";
        gerimuMasyvas[3] = "Kokteilis";

        return gerimuMasyvas;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        GerimasLabel.Text = "Pirmasis gėrimas iš rikiuoto masyvo:";
        string[] gerimai = GautiGerimuMasyva();
        Array.Sort(gerimai);
        GerimasTextBox.Text = gerimai[0];
    }

    protected void PridetiButton_ServerClick(object sender, EventArgs e)
    {
        string[] gerimai = GautiGerimuMasyva();

        if (!string.IsNullOrEmpty(NaujasGerimasTextBox.Text))
        {
            gerimai[0] = NaujasGerimasTextBox.Text;
        }

        foreach (string gerimas in gerimai)
        {
            Response.Write(gerimas + ", ");
        }
    }
}