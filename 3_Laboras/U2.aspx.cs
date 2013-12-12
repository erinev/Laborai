using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class U2 : Page
{
    private const string A2Ofisas = "2A";
    private const string B2Ofisas = "2B";
    private const string C2Ofisas = "2C";

    protected void Page_Load(object sender, EventArgs e)
    {
        OfisasImageMap.HotSpotMode = HotSpotMode.PostBack;
        OfisasImageMap.HotSpots.Add(Create2ARegion());
        OfisasImageMap.HotSpots.Add(Create2BRegion());
        OfisasImageMap.HotSpots.Add(Create2CRegion());
    }

    private HotSpot Create2ARegion()
    {
        var region = new RectangleHotSpot
        {
            Left = 50,
            Top = 60,
            PostBackValue = A2Ofisas
        };
        return region;
    }

    private HotSpot Create2BRegion()
    {
        var region = new RectangleHotSpot
        {
            Left = 98,
            Right = 50,
            Top = 60,
            PostBackValue = B2Ofisas
        };
        return region;
    }

    private HotSpot Create2CRegion()
    {
        var region = new RectangleHotSpot
        {
            Left = 196,
            Right = 100,
            Top = 60,
            PostBackValue = C2Ofisas
        };
        return region;
    }

    protected void OfisasImageMap_Click(object sender, ImageMapEventArgs e)
    {
        PasirinktasOfisasLabel.Text = e.PostBackValue;
    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        AntrasLaborasWizard.Visible = false;
        Response.Write("Ačiū, kad naudojote vedlį!");
    }

    protected void AntrasLaborasWizard_ActiveStepChanged(object sender, EventArgs e)
    {
        if (AntrasLaborasWizard.ActiveStep == SantraukaWizardStep)
        {
            string pasirinktasOfisas = PasirinktasOfisasLabel.Text;
            if (string.IsNullOrEmpty(pasirinktasOfisas))
            {
                pasirinktasOfisas = A2Ofisas;
            }
            SantraukaLabel.Text = string.Format("Pasirinkote: {0} Kambarys: {1} {0} Inventorizacijos data: {2}",
                Environment.NewLine, pasirinktasOfisas, InventorizacijosCalendar.SelectedDate.ToShortDateString());
        }
    }
}