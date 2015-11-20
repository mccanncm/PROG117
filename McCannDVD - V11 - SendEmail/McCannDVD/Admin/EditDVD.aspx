<%@ Page Title="Edit DVD" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditDVD.aspx.cs" Inherits="McCannDVD.Admin.EditDVD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">






    <h2>Here you can edit an existing DVD</h2>
    

        <asp:Label ID ="editDVDError" ForeColor="Red" runat="server" />
        <br />
        <br />

    <div class="addDVD">
        <asp:DropDownList AppendDataBoundItems="true" AutoPostBack="true" ForeColor="Red" ID="DropDownListEditDVD" runat="server">
        </asp:DropDownList>
        
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonSelectDVD" runat="server" OnClick="ButtonSelectDVD_Click" Text="Select" />
        <br />
        <br />
        <br />
    <asp:Label class="widelabel" runat="server">Title:</asp:Label>
    <asp:TextBox ID="TextBoxDVDtitle" runat="server"></asp:TextBox>
    <br />
    <asp:Label class="widelabel" runat="server">Artist:</asp:Label>
    <asp:TextBox ID="TextBoxDVDartist" runat="server"></asp:TextBox>
    <br />
    <asp:Label class="widelabel" runat="server">Rating:</asp:Label>
    <asp:TextBox ID="TextBoxDVDrating" runat="server"></asp:TextBox>
    <br />
    <asp:Label class="widelabel" runat="server">Price:</asp:Label>
    <asp:TextBox ID="TextBoxDVDprice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonUpdateDVD" runat="server" OnClick="ButtonUpdateDVD_Click" Text="Update DVD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDeleteDVD" runat="server" Text="Delete DVD" OnClick="ButtonDeleteDVD_Click" />
    <br /><br />
        <asp:Label ID ="editSuccess" ForeColor="Red" runat="server" />
        </div>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click" />






</asp:Content>
