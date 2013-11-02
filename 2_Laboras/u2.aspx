<%@ Page Language="C#" AutoEventWireup="true" CodeFile="u2.aspx.cs" Inherits="u2_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="RezultatasLabel" runat="server" Text="Label_tekstas"></asp:Label>
        <br />
        <br />
        Vartotojo vardas<br />
        <asp:TextBox ID="VartotojoVardasTextBox" runat="server" MaxLength="12"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="AdministratoriusCheckBox" runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="CheckedChanged" Text="Sistemos administratorius" />
        <br />
        <br />
        Aplikacijos roles<asp:RadioButtonList ID="AplikacijosRolesRadioButtonList" GroupName="AplikacijosRoles" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Vartotojas</asp:ListItem>
            <asp:ListItem>Vadybininkas</asp:ListItem>
            <asp:ListItem>Vadovas</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="SaugotiButton" runat="server" Text="Saugoti" OnClick="SaugotiButton_Click" style="height: 26px" />
    
    </div>
    </form>
</body>
</html>
