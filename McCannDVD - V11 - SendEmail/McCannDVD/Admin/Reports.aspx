<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="McCannDVD.Admin.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <h1>Reports</h1>
    
        <asp:Button ID="ButtonListCust" runat="server" OnClick="ButtonListCust_Click" Text="List Customers" />
        &nbsp;&nbsp;&nbsp;For Customer #: <asp:TextBox ID="TextBoxCustNum" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="ButtonGetOrders" runat="server" OnClick="ButtonGetOrders_Click" Text="Get Orders" />
        &nbsp;&nbsp;
        <asp:Button ID="ButtonLogoff" runat="server" OnClick="ButtonLogoff_Click" Text="Logoff" />
    

    <br />
    <br />
    

    <br />
    <asp:Label ID="CustomerError" runat="server" ForeColor="Red" Font-Bold="true" /><br />
    <asp:Label ID="CustomerLabel" runat="server" ForeColor="Red" Font-Bold="true" Font-Underline="true"/>
    <br />
    <br />
    <asp:DataList ID="Customerlist" runat="server">
        <ItemTemplate>
            Customer ID: <strong><%#Eval("CustomerID") %></strong> <span style="color:red;">|</span>
            First Name: <strong><%#Eval("FirstName") %></strong> <span style="color:red;">|</span>
            Last Name: <strong><%#Eval("LastName") %></strong>
            <hr />
        </ItemTemplate>

    </asp:DataList>

    <br />

    <br />
    <asp:Label ID="OrderListError" runat="server" ForeColor="Red" Font-Bold="true" /><br />
    <asp:Label ID="OrderListLabel" runat="server" ForeColor="Red" Font-Bold="true" Font-Underline="true" />
    <br />
    <br />
    <asp:DataList ID="Orderlist" runat="server">
        <ItemTemplate>
            Order ID: <strong><%#Eval("OrderID") %></strong> <span style="color:red">|</span>
            Customer ID: <strong><%#Eval("CustomerID") %></strong> <span style="color:red">|</span>
            DVD ID: <strong><%#Eval("DVDID") %></strong> <span style="color:red">|</span>
            Title: <strong><%#Eval("DVDtitle") %></strong>
            <hr />
        </ItemTemplate>
    </asp:DataList>







</asp:Content>
