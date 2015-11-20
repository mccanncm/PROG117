<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="McCannDVD.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



        <h2>Please Login Here</h2>

    <p> 
   Username:<br /> 
   <asp:TextBox id ="usernameTextBox" runat ="server" Width="128px" />
   <asp:RequiredFieldValidator id ="usernameReq" runat ="server" 
        ControlToValidate ="usernameTextBox"  SetFocusOnError = "true"
        ErrorMessage ="Username is required!"  /> 
</p> 

<p> 
   Password:<br />
   <asp:TextBox id ="passwordTextBox" runat ="server" TextMode ="Password" Width="128px" />
   <asp:RequiredFieldValidator id ="passwordReq" runat ="server" 
        ControlToValidate ="passwordTextBox" SetFocusOnError = "true"
        ErrorMessage ="Password is required!"  />
</p> 
<p>
<asp:Button id ="ButtonLogin" runat ="server" Text ="Login" OnClick="ButtonLogin_Click" />
</p>













</asp:Content>
