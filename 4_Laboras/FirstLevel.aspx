<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FirstLevel.aspx.cs" Inherits="FirstLevel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <form method="GET">    
    <table style="width:100%;">
            <tr>
                <td colspan="2"><strong>Sudėties skaičiavimas</strong><asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" style="font-size: small" />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 188px">Įveskite pirmą skaičių</td>
                <td>
                    <asp:TextBox ID="FirstNumberTextBox"  runat="server" Width="53px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstNumberTextBox" Display="Dynamic" ErrorMessage="Required" ForeColor="Red" ToolTip="Required">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 188px">Įveskite antrą skaičių: </td>
                <td>
                    <asp:TextBox ID="SecondNumberTextBox" runat="server" Width="51px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="SecondNumberTextBox" Display="Dynamic" ErrorMessage="Required" ForeColor="Red" ToolTip="Required">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 188px">&nbsp;</td>
                <td>
                    <asp:Button ID="CountButton" runat="server" Text="Skaičiuoti" />
                </td>
            </tr>
        </table>
        </form>
</asp:Content>

