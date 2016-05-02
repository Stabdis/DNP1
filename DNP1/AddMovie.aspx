<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="DNP1.AddMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .list { 
            margin-top: 50px;
            margin-left: 70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        New movie title: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </div>

    <div class="list">
        <asp:ListBox ID="ListBox1" runat="server" Height="127px" Width="174px"></asp:ListBox>
        <p><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></p>
    </div>
</asp:Content>
