﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HemligaTalet.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gissa det hemliga talet</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Gissa det hemliga talet</h1>
        <asp:ValidationSummary ID="ValidationSummary1" CssClass="error" HeaderText="Fel inträffade. Åtgärda felen och försök igen." runat="server" />
   
     <div>
        <asp:Label ID="GuessBoxLabel" for="GuessTextBox" runat="server" Text="Ange ett tal mellan 1 och 100"></asp:Label>
        <asp:TextBox ID="GuessTextBox" runat="server" autofocus="autofocus"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet får ej vara tomt" CssClass="error" ControlToValidate="GuessTextBox" Text="*" Display="Dynamic" ></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Talet måste vara ett heltal inom 1-100" CssClass="error" ControlToValidate="GuessTextBox" Text="*" Type="Integer" MaximumValue="100" MinimumValue="1" Display="Dynamic"></asp:RangeValidator>
        <asp:Button ID="SendGuessButton" runat="server" Text="Gissa" OnClick="SendGuessButton_Click" />
    </div>

    <asp:PlaceHolder ID="PlaceHolder" runat="server" Visible="false">
        <p>
            <asp:Label ID="GuessedLabel" CssClass="guessed" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="HelperLabel" runat="server"></asp:Label>
        </p>
    </asp:PlaceHolder>

    <asp:PlaceHolder ID="ButtonPlaceHolder" runat="server" Visible="false">
        <p>
            <asp:Button ID="ResetButton" runat="server" Text="Slumpa nytt hemligt tal" OnClick="ResetButton_Click"  CausesValidation="False" />
        </p>
    </asp:PlaceHolder>
       
    </form>
</body>
</html>
