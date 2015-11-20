<%@ Page Title="Add DVD" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddDVD.aspx.cs" Inherits="McCannDVD.Admin.AddDVD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h2>Here you can add another DVD to the store.</h2>


    <asp:Label ID ="addDVDError" ForeColor="Red" runat="server" />

    <div class="addDVD">
        <asp:Label class="widelabel" runat="server">Title:</asp:Label>
        <asp:TextBox ID="TextBoxDVDtitle" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="titleReq" runat="server"
            ControlToValidate="TextBoxDVDtitle" ForeColor="Red"
            ErrorMessage="DVD Title Required"
            Display="Dynamic" SetFocusOnError="true" />
        <br />

        <asp:Label class="widelabel" runat="server">Artist:</asp:Label>
        <asp:TextBox ID="TextBoxDVDartist" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="artistReq" runat="server"
            ControlToValidate="TextBoxDVDartist" ForeColor="Red"
            ErrorMessage="DVD Artist Required"
            Display="Dynamic" SetFocusOnError="true" />
        <br />

        <asp:Label class="widelabel" runat="server">Rating:</asp:Label>
        <asp:TextBox ID="TextBoxDVDrating" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ratingReq" runat="server"
            ControlToValidate="TextBoxDVDrating" ForeColor="Red"
            ErrorMessage="DVD Rating Required"
            Display="Dynamic" SetFocusOnError="true" />
        <asp:RangeValidator ID="rateRange" runat="server"
            ControlToValidate="TextBoxDVDrating" ForeColor="Red"
            MinimumValue="1" MaximumValue="5" Type="Integer"
            ErrorMessage="Rating must be from 1-5"
            Display="Dynamic" SetFocusOnError="true" />
        <br />

        <asp:Label class="widelabel" runat="server">Price:</asp:Label>
        <asp:TextBox ID="TextBoxDVDprice" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="priceReq" runat="server"
            ControlToValidate="TextBoxDVDprice" ForeColor="Red"
            ErrorMessage-="DVD Price Required"
            Display="Dynamic" SetFocusOnError="true" />
        <asp:CompareValidator ID="priceValidFormat" runat="server"
            ControlToValidate="TextBoxDVDprice" ForeColor="Red"
            Type="Currency" Operator="DataTypeCheck"
            ErrorMessage="Invalid Price"
            Display="Dynamic" SetFocusOnError="true" />
        <asp:RangeValidator ID="priceRange" runat="server"
            ControlToValidate="TextBoxDVDprice" ForeColor="Red"
            MinimumValue="0.01" MaximumValue="1000000000" Type="Currency"
            ErrorMessage="Invalid Price Range"
            Display="Dynamic" SetFocusOnError="true" />
        <br />

    <br />
    <asp:Button ID="ButtonAddDVD" runat="server" Text="Add DVD" OnClick="ButtonAddDVD_Click" />
        <br />
        <br />
        <asp:Label ID="addSuccess" ForeColor="Red" runat="server" />


        </div>











</asp:Content>
