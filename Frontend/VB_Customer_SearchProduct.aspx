<%@ Page Title="Search Product" Language="C#" MasterPageFile="~/VB_MasterPage.master" AutoEventWireup="true" CodeFile="VB_Customer_SearchProduct.aspx.cs" Inherits="Staff_SearchProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >


   <h2 style="text-align:center ">Search Products: <asp:TextBox ID="TextBox1" runat="server" Width="213px" Height="16px"></asp:TextBox>
       <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Buttons/Search.jpg" Width="100px" Height="100px" ImageAlign="Middle" />
    </h2>
    
   <table style="width: 900px">
  <tr>
    <th rowspan="3" style="width: 900px"><asp:ListBox ID="ListBox1" runat="server" Width="700px" Height="400px"></asp:ListBox></th>
    <td>
        &nbsp;</td>
  </tr>
  <tr>
    <td>
        <asp:ImageButton ID="BtnReturn" runat="server" ImageUrl="~/Buttons/return.jpg" Width="125PX" Height="125px" ImageAlign="Middle" OnClick="BtnReturn_Click" /></td>
  </tr>
  <tr>
    <td>
        <asp:ImageButton ID="BtnBuy" runat="server" ImageUrl="~/Buttons/buy.jpg" Width="125PX" Height="125px" ImageAlign="Middle" OnClick="BtnBuy_Click" /></td>
  </tr>
</table>

     </asp:Content>

