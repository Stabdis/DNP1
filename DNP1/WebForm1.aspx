<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DNP1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VIA-cinema</title>

    <style>
        .list { 
            margin-top: 50px;
            margin-left: 70px;
        }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            New movie title: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>

        <div class="list">
            <asp:ListBox ID="ListBox1" runat="server" Height="127px" Width="174px"></asp:ListBox>
            <p><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></p>
        </div>
    </form>
</body>
</html>
