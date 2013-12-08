<%@ Page Language="C#" Theme="Ziema" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_6_Laboras.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            <asp:Label ID="LabelUsername" CssClass="label" runat="server" Text="Vartotojo vardas:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxUsername" CssClass="textbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonLogin" CssClass="button" runat="server" Text="Login" />
        </div>
        </form>
    </body>
</html>