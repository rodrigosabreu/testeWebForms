<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Formulario.aspx.cs" Inherits="Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2><%: Title %>.</h2>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
            <asp:BoundField DataField="email" HeaderText="E-mail" SortExpression="email" />
        </Columns>
    </asp:GridView>


    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>


</asp:Content>

