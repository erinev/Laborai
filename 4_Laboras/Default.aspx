<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>


<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <p>
        <table style="width: 100%;">
            <tr>
                <td style="font-size: large; height: 62px; vertical-align: top;" colspan="2">Vartotojo registracija<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" style="font-size: medium" />
                </td>
            </tr>
            <tr>
                <td style="height: 22px; width: 191px;">Vartotojo vardas</td>
                <td style="height: 22px; width: 479px;">
                    <asp:TextBox ID="UsernameTextBox" runat="server" MaxLength="14" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UsernameTextBox" Display="Dynamic" ErrorMessage="*Vartotojo vardas privalomas" ForeColor="Red" ToolTip="*Vartotojo vardas privalomas">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UsernameTextBox" Display="Dynamic" ErrorMessage="*Igis 6 - 14 simbolių. Simboliai gali būti : didelės raidės, mažos raidės, skaičiai ir pabraukimas" ForeColor="Red" ToolTip="*Igis 6 - 14 simbolių. Simboliai gali būti : didelės raidės, mažos raidės, skaičiai ir pabraukimas" ValidationExpression="\w{6,14}.">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 22px; width: 191px;">E-paštas</td>
                <td style="height: 22px; width: 479px">
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="*E-paštas privalomas" ForeColor="Red" ToolTip="*E-paštas privalomas">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="*Blogas e-pašto formatas(pvz: info@ktu.lt)" ForeColor="Red" ToolTip="*Blogas e-pašto formatas(pvz: info@ktu.lt)" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 27px; width: 191px;">Slaptažodis</td>
                <td style="height: 27px; width: 479px;">
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="*Slaptažodis privalomas" ForeColor="Red" ToolTip="*Slaptažodis privalomas">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="*Slaptažodis turi turėti nors vieną didelę raidę, nors vieną mažą raidę ir nors vieną skaičių. Jo ilgis 6-14 simbolių." ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ToolTip="*Slaptažodis turi turėti nors vieną didelę raidę, nors vieną mažą raidę ir nors vieną skaičių. Jo ilgis 6-14 simbolių.">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 24px; width: 191px;">Slaptažodžio pakartojimas</td>
                <td style="height: 24px; width: 479px;">
                    <asp:TextBox ID="RepeatPasswordTextBox" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="RepeatPasswordTextBox" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="*Slaptažodžiai nesutampa." ForeColor="Red" ToolTip="*Slaptažodžiai nesutampa.">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 28px; width: 191px;"></td>
                <td style="height: 28px; width: 479px;">
                    <asp:Button ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" Text="Registruotis" ValidateRequestMode="Enabled" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Label ID="RegistrationFinishedLabel" runat="server"></asp:Label>
    </p>
</asp:Content>