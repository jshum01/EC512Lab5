<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Converter</title>
</head>
<body>
    <h1>Currency Converter</h1>
     <hr />
    <form id="form1" runat="server">
        <div style="float: left; width: 50%;">
        Target Currency<br />
&nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="121px" Width="196px" DataSourceID="SqlDataSource1" DataTextField="Currency" DataValueField="Currency" ></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" InsertCommand="INSERT INTO Rates(Currency, Exchange) VALUES (@newcurr, @newexch)" SelectCommand="SELECT * FROM [Rates]" DeleteCommand="DELETE FROM Rates WHERE (Currency = @value)" UpdateCommand="UPDATE Rates SET Exchange = @newvalue WHERE (Currency = @listcurr)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="ListBox1" Name="value" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="TextBox2" Name="newcurr" PropertyName="Text" />
                <asp:ControlParameter ControlID="TextBox3" Name="newexch" PropertyName="Text" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="TextBox4" Name="newvalue" PropertyName="Text" />
                <asp:ControlParameter ControlID="ListBox1" Name="listcurr" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
            
            <br />
            <b> See selected conversion rate:</b><br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Show" Width="221px" />


        <br />
            Conversion Rate:
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
        <br />
            <b>&nbsp;Enter amount to convert</b>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="172px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Convert" Width="199px" OnClick="Button1_Click" />
        <br />
        Conversion Amount:
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
            <br />
            <br />
            <b>Change Selected Exchange Rate<br />
            </b>
        &nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="167px"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" runat="server" Text="Change" Width="195px" OnClick="Button4_Click" />
            <br />
            <br />
        <b>Add New Exchange Rate</b><br />
        Currency Name: <asp:TextBox ID="TextBox2" runat="server" Width="148px"></asp:TextBox>
        <br />
        Exchange Rate:
        <asp:TextBox ID="TextBox3" runat="server" Width="152px"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Add Currency" Width="205px" OnClick="Button2_Click" />


        <br />
            Status:
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />

        </div>
        <div style="float: left; width: 50%;">
            Delete Selected Currency:
            <br />
            <asp:Button ID="Button3" runat="server" Text="Delete" Width="201px" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
