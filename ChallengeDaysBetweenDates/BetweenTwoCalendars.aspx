<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BetweenTwoCalendars.aspx.cs" Inherits="ChallengeDaysBetweenDates.BetweenTwoCalendars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h3>How many days have elapsed?</h3></div>
        <div><p>Chose the first date:<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br /></p></div>
        <div><p>Chose the second date:<asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
            </p></div>
        <div><br />
            <asp:Button ID="calcButton" runat="server" Text="Calculate" OnClick="calcButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
