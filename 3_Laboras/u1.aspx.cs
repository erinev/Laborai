using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class U1 : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        table.BorderWidth = Unit.Pixel(5);
        table.BorderColor = Color.Green;
        this.CreateHtmlTable();
    }

    private void CreateHtmlTable()
    {
        table.Controls.Clear();
        const int rowsNumber = 5;
        const int columnsNumber = 3;

        for (int i = 0; i < rowsNumber; i++)
        {
            var row = new TableRow();
            table.Controls.Add(row);

            for (int j = 0; j < columnsNumber; j++)
            {
                var cell = new TableCell
                {
                    Text = string.Format("Eil. Nr. {0}, St. Nr. {1}", i+1, j+1),
                    HorizontalAlign = HorizontalAlign.Center,
                    BorderColor = Color.Black,
                    BorderWidth = Unit.Pixel(2)
                }; 

                row.Controls.Add(cell);
            }
        }
    }
}