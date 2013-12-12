<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <asp:Image ID="Image1" runat="server" />
                <br />
                <br />
                <asp:Label ID="LabelUsername" CssClass="label" runat="server" Text="Vartotojo vardas:"></asp:Label>
                <br />
                <asp:TextBox ID="TextBoxUsername" CssClass="textbox" runat="server"></asp:TextBox>
                <br />
        <br />
        <asp:DropDownList ID="DropDownList" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Vasara</asp:ListItem>
            <asp:ListItem>Ziema</asp:ListItem>
            <asp:ListItem>Pavasaris</asp:ListItem>
        </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="ButtonLogin" CssClass="button" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
    <div>
    
    </div>
    <div>
    
    </div>
    </form>
</body>
</html>
