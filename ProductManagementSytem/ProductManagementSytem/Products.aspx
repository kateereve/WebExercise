<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ProductManagementSytem.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Search product ID:"></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>

    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtProdID" runat="server"></asp:TextBox>
         <asp:Label ID="Label3" runat="server" Text="Cost"></asp:Label>
        <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
    </asp:Panel>
    
    <asp:Panel ID="Panel3" runat="server">
        <asp:Label ID="Label4" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox>
         <asp:Label ID="Label5" runat="server" Text="Qty"></asp:Label>
        <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
        <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" />
    </asp:Panel>
  <br />

    <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
     <asp:Panel ID="Panel4" runat="server">
        <asp:Label ID="Label6" runat="server" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
    
    </asp:Panel>
      <asp:Panel ID="Panel5" runat="server">
        <asp:Label ID="Label7" runat="server" Text="Cash"></asp:Label>
        <asp:TextBox ID="txtCash" runat="server"></asp:TextBox>
    
    </asp:Panel>

    <asp:Panel ID="Panel6" runat="server">
        <asp:Label ID="Label8" runat="server" Text="Change"></asp:Label>
        <asp:TextBox ID="txtChange" runat="server"></asp:TextBox>
        
    </asp:Panel>

   <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
</asp:Content>
