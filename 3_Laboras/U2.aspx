<%@ Page Language="C#" AutoEventWireup="true" CodeFile="U2.aspx.cs" Inherits="U2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Wizard ID="AntrasLaborasWizard" runat="server" Height="250px" style="margin-bottom: 0px" Width="425px" ActiveStepIndex="0" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" OnActiveStepChanged="AntrasLaborasWizard_ActiveStepChanged" OnFinishButtonClick="Wizard1_FinishButtonClick">
                    <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
                    <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                    <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                    <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
                    <WizardSteps>
                        <asp:WizardStep ID="OfisasWizardStep" runat="server" Title="Pasirinkti ofisą">
                            <asp:ImageMap ID="OfisasImageMap" runat="server" ImageUrl="~/Paveikslai/3planas.jpg" OnClick="OfisasImageMap_Click"></asp:ImageMap>
                            <br />
                            Pasirinktas ofisas:
                            <asp:Label ID="PasirinktasOfisasLabel" runat="server"></asp:Label>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Gynimas">
                            <asp:Label ID="Label1" runat="server" Text="Gynimas"></asp:Label>
                        </asp:WizardStep>
                        <asp:WizardStep ID="DataWizardStep" runat="server" Title="Inventorizacijos data">Pasirinkite inventorizacijos data:<br />
                            <asp:Calendar ID="InventorizacijosCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="Gray" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" ID="SantraukaWizardStep" Title="Santrauka">
                            <asp:Label ID="SantraukaLabel" runat="server" Height="200px" Width="250px"></asp:Label>
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </div>
        </form>
       
    </body>
</html>