<%@ Page Title="The DVD Store" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="McCannDVD._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--code goes here--%>

<br />
<h2>Please browse the list of DVD’s. </h2>


    <asp:DataList id="DVDrepeater" runat="server" OnItemCommand="DVDrepeater_ItemCommand">
   <ItemTemplate> 
      DVD Title: <strong><%#Eval("DVDtitle")%></strong><br />
      Artist: <strong><%#Eval("DVDartist")%></strong><br />
      Rating: <strong><%#Eval("DVDrating")%></strong><br />
      Price: <strong><%#DataBinder.Eval(Container.DataItem, "DVDprice", "{0:C}")%></strong>  <%--is there are better way to show only two decimal places--%>
              
       &nbsp;
       &nbsp;
       &nbsp;
       &nbsp;

      <asp:LinkButton ID ="DetailsButton" runat ="server" Text="Details" CommandName ="details" 
          CommandArgument = <%# Eval("DVDID")%> ForeColor="Red" Font-Bold="true" Width="75px"/>

      <asp:LinkButton ID ="BuyButton" runat="server" Text="Buy Now" CommandName="buy" 
          CommandArgument= <%# Eval("DVDID")%> ForeColor="Red" Font-Bold="true" />

   </ItemTemplate> 
    <SeparatorTemplate> 
    <hr style="height:2px; background-color:black" /> 
    </SeparatorTemplate>  
</asp:DataList>



</asp:Content>
