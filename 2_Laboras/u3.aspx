<%@ Page Language="C#" AutoEventWireup="true" CodeFile="u3.aspx.cs" Inherits="u3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="GerimasLabel" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="GerimasTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Įrašykite naują gėrimą:<br />
        <asp:TextBox ID="NaujasGerimasTextBox" runat="server"></asp:TextBox>
        <input id="PridetiButton" type="button" runat="server" value="Spausti" onserverclick="PridetiButton_ServerClick" />

    </div>
    </form>
</body>
</html>
