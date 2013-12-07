<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SecondLevel.aspx.cs" Inherits="SecondLevel" EnableEventValidation="false" %>
<%@ PreviousPageType VirtualPath="~/FirstLevel.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <asp:Label ID="MessageLabel" runat="server" Text="Dviejų skaičių suma = " Visible="False"></asp:Label>
        <asp:Label ID="ResultLabel" runat="server" Visible="False"></asp:Label>
    </p>
</asp:Content>

