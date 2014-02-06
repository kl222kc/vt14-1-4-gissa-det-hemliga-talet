<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HemligaTalet.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gissa det hemliga talet</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="GuessTextBox" runat="server" autofocus=""></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet får ej vara tomt" ControlToValidate="GuessTextBox"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Talet måste vara ett heltal inom 1-100" ControlToValidate="GuessTextBox" Type="Double" MaximumValue="100" MinimumValue="1"></asp:RangeValidator>
        <asp:Button ID="SendGuessButton" runat="server" Text="Button" OnClick="SendGuessButton_Click" />
    </div>
    </form>
</body>
</html>
