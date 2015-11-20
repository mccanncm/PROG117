<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="diceHomeworkMcCann._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Equal Di or Total of 7 or 11 Wins</h1>
        <asp:Image ID="Image1" runat="server" />
        &nbsp;&nbsp;
        <asp:Image ID="Image2" runat="server" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Your balance is: &nbsp;$
        <asp:Label ID="LabelBalance" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Select your bet:<br />
        <asp:RadioButtonList ID="BetSelect" runat="server">
            <asp:ListItem Selected="True">1</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:RadioButtonList>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="NotEnoughCash" runat="server" Text="Label"></asp:Label>
    </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBet" runat="server" OnClick="ButtonBet_Click" Text="click to bet" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonPlayAgain" runat="server" OnClick="ButtonPlayAgain_Click" Text="Play Again" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelResults" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
