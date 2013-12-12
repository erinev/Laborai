using System;
using System.Web.UI;

public partial class Default : Page
{
    private readonly Random _random = new Random();

    protected void Page_Load(object sender, EventArgs e)
    {
        int img1Number = _random.Next(1, 4);
        Image1.ImageUrl = string.Format("Images\\{0}.png", img1Number);

        int img2Number = _random.Next(1, 4);
        Image2.ImageUrl = string.Format("Images\\{0}.png", img2Number);
    }

    protected void ButtonRefresh_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(4000);
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int img3Number = _random.Next(1, 4);
        Image3.ImageUrl = string.Format("Images\\{0}.png", img3Number);
    }
}