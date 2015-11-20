<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Thanks.aspx.cs" Inherits="McCannDVD.Thanks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <h1>Thank you for your order </h1>
    Your Customer Number is:
    <asp:Label ID="custNum" runat="server" Text="Label"></asp:Label>
    <br />
    Your movie is:
    <asp:Label ID="LabelTitle" runat="server" Text="Label"></asp:Label>
    <br />
    You paid:
    <asp:Label ID="LabelPaid" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="statusLabel" runat="server" Text="Label"></asp:Label>















</asp:Content>
